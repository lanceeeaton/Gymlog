﻿using Gymlog.Data;
using Gymlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Services
{
    public class WorkoutService
    {
        private readonly ApplicationDbContext _context;

        public WorkoutService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddWorkout(Workout workout, ApplicationUser user)
        {
            workout.Id = Guid.NewGuid().ToString();
            workout.UserId = user.Id;
            _context.Workouts.Add(workout);

            foreach(var workoutExercise in workout.WorkoutExericses)
            {
                workoutExercise.Id = Guid.NewGuid().ToString();
                workoutExercise.WorkoutId = workout.Id;
                _context.WorkoutExercises.Add(workoutExercise);
                foreach (var set in workoutExercise.Sets)
                {
                    set.Id = Guid.NewGuid().ToString();
                    set.WorkoutExerciseId = workoutExercise.Id;
                    _context.Sets.Add(set);
                }
            }

            return await saveAsync();
        }

        private async Task<bool> saveAsync()
        {
            int result = await _context.SaveChangesAsync(); // pushes to DB
            return result == 3;
        }
        public async Task<Workout[]> ListWorkouts(ApplicationUser user)
        {
            return await _context.Workouts
                .Where((workout) => user.Id == workout.UserId)
                .ToArrayAsync();
        }
    }
}
