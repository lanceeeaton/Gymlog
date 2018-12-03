﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymlog.Models;
using Gymlog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gymlog.Controllers
{
    public class SavedController : Controller
    {
        private readonly ExerciseService _exerciseService;
        private readonly WorkoutService _workoutService;
        private readonly UserManager<ApplicationUser> _userManager;

        public SavedController(ExerciseService exerciseService, WorkoutService workoutService, UserManager<ApplicationUser> userManager)
        {
            _workoutService = workoutService;
            _exerciseService = exerciseService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Workouts()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {   // make them login
                return Challenge();
            }

            var workouts = await _workoutService.ListWorkouts(currentUser);
            return View(workouts);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Workout(string id)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {   // make them login
                return Challenge();
            }

            var workout = await _workoutService.getWorkout(id);

            if (currentUser.Id == workout.UserId)
            {
                return View(workout);
            }
            return RedirectToAction(nameof(HomeController.Index), "Home");

        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LogWorkout(string id)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {   // make them login
                return Challenge();
            }

            var workout = await _workoutService.getWorkout(id);

            if (currentUser.Id == workout.UserId)
            {
                return View(workout);
            }
            return RedirectToAction(nameof(HomeController.Index), "Home");

        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LogWorkout(string Id,string[] RepsCompleted,string[] Weight, string[] Notes)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {   // make them login
                return Challenge();
            }
            var workout = await _workoutService.getWorkout(Id);

            if (currentUser.Id == workout.UserId)
            {
                LoggedWorkout model = new LoggedWorkout();
                model.WorkoutId = Id;
                model.RepsCompleted = RepsCompleted;
                model.Weight = Weight;
                model.Notes = Notes;
                await _workoutService.LogWorkout(currentUser, model);
            }
            return RedirectToAction(nameof(HomeController.Index), "Home");

        }
        /*[HttpPost]
        public IActionResult Exercise()
        {
            return View();
        }*/

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Exercises()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var exercises = await _exerciseService.ListExercises(currentUser);
            return View(exercises);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteExercise(string exericseId)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var exercise = await _exerciseService.getExercise(exericseId);

            if (exercise.UserId == currentUser.Id)
            {
                await _exerciseService.deleteExercise(exercise);
                return RedirectToAction("Exercises");
            }
            else
            {
                return Challenge();
            }
        }
    }
}