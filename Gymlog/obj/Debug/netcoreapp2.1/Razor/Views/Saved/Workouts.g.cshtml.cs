#pragma checksum "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workouts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8b643e8c18facd917d00218be6482cc6a2cb43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Saved_Workouts), @"mvc.1.0.view", @"/Views/Saved/Workouts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Saved/Workouts.cshtml", typeof(AspNetCore.Views_Saved_Workouts))]
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
#line 1 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog;

#line default
#line hidden
#line 2 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8b643e8c18facd917d00218be6482cc6a2cb43", @"/Views/Saved/Workouts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221afc43e64317c4f1fa0904c7b9307c191dcbcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Saved_Workouts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Gymlog.Models.Workout>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Workout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workouts.cshtml"
  
    ViewData["Title"] = "Saved Workouts";

#line default
#line hidden
            BeginContext(95, 34, true);
            WriteLiteral("<h2>Saved Workouts</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "016f11ca72994424b45068f7b49336dc", async() => {
                BeginContext(186, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(200, 275, true);
            WriteLiteral(@"
</p>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                
            </th>
            <th>
                
            </th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 28 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workouts.cshtml"
         foreach (var workout in Model)
        {

#line default
#line hidden
            BeginContext(527, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(566, 12, false);
#line 31 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workouts.cshtml"
               Write(workout.Name);

#line default
#line hidden
            EndContext();
            BeginContext(578, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 629, "\"", 665, 2);
            WriteAttributeValue("", 636, "/Saved/Workout?id=", 636, 18, true);
#line 33 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workouts.cshtml"
WriteAttributeValue("", 654, workout.Id, 654, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(666, 78, true);
            WriteLiteral(">View</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 744, "\"", 783, 2);
            WriteAttributeValue("", 751, "/Saved/LogWorkout?id=", 751, 21, true);
#line 36 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workouts.cshtml"
WriteAttributeValue("", 772, workout.Id, 772, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(784, 62, true);
            WriteLiteral(">Log Workout</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Users\lance\Documents\Programs\gymClone12_9\Gymlog\Gymlog\Views\Saved\Workouts.cshtml"
        }

#line default
#line hidden
            BeginContext(857, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Gymlog.Models.Workout>> Html { get; private set; }
    }
}
#pragma warning restore 1591
