#pragma checksum "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42e52cf338949b4b4b0db409194c12c61242280e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Saved_LogWorkout), @"mvc.1.0.view", @"/Views/Saved/LogWorkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Saved/LogWorkout.cshtml", typeof(AspNetCore.Views_Saved_LogWorkout))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog;

#line default
#line hidden
#line 2 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e52cf338949b4b4b0db409194c12c61242280e", @"/Views/Saved/LogWorkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221afc43e64317c4f1fa0904c7b9307c191dcbcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Saved_LogWorkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymlog.Models.Workout>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Saved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Workouts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
            BeginContext(74, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(81, 10, false);
#line 6 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(91, 16, true);
            WriteLiteral("</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(107, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1e21a2baf354dfd8e7ef8eb5736cbb8", async() => {
                BeginContext(167, 19, true);
                WriteLiteral("View Saved Workouts");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(198, 2068, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a5a26362cf54c6cb134ddf8ebb93b8c", async() => {
                BeginContext(218, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(224, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc104cf4a05043e9a687df74f7be2b88", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 11 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(260, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 13 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
     foreach (var workoutExercise in Model.WorkoutExercises)
    {

#line default
#line hidden
                BeginContext(333, 12, true);
                WriteLiteral("        <h3>");
                EndContext();
                BeginContext(346, 28, false);
#line 15 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
       Write(workoutExercise.ExerciseName);

#line default
#line hidden
                EndContext();
                BeginContext(374, 7, true);
                WriteLiteral("</h3>\r\n");
                EndContext();
                BeginContext(383, 654, true);
                WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Set
                    </th>
                    <th>
                        Reps
                    </th>
                    <th>
                        Reps Completed
                    </th>
                    <th>
                        Comments
                    </th>
                    <th>
                        Weight
                    </th>
                    <th>
                        Notes
                    </th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 41 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
                 foreach (var set in workoutExercise.Sets)
                {

#line default
#line hidden
                BeginContext(1116, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1201, 13, false);
#line 45 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
                       Write(set.SetNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1214, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1306, 8, false);
#line 48 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
                       Write(set.Reps);

#line default
#line hidden
                EndContext();
                BeginContext(1314, 135, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <input min=\"0\" max=\"9999\" style=\"width:50px\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1449, "\"", 1466, 1);
#line 51 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
WriteAttributeValue("", 1457, set.Reps, 1457, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1467, 129, true);
                WriteLiteral(" type=\"number\" name=\"RepsCompleted\" />\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1597, 12, false);
#line 54 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
                       Write(set.Comments);

#line default
#line hidden
                EndContext();
                BeginContext(1609, 402, true);
                WriteLiteral(@"
                        </td>
                        <td>
                            <input maxlength=""50"" style=""width:80px"" placeholder=""Weight"" type=""text"" name=""Weight"" />
                        </td>
                        <td>
                            <input maxlength=""500"" placeholder=""Notes"" type=""text"" name=""Notes"" />
                        </td>
                    </tr>
");
                EndContext();
#line 63 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
                }

#line default
#line hidden
                BeginContext(2030, 40, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
                EndContext();
#line 66 "C:\Users\epere\OneDrive\Gymlog\Gymlog\Views\Saved\LogWorkout.cshtml"
    }

#line default
#line hidden
                BeginContext(2077, 182, true);
                WriteLiteral("    <input type=\"submit\" class=\"btn btn-default\" value=\"Log Workout\"\r\n               style=\"position: fixed; bottom: 50px; right: 50px; color:#9d9d9d; background-color:#101010;\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymlog.Models.Workout> Html { get; private set; }
    }
}
#pragma warning restore 1591
