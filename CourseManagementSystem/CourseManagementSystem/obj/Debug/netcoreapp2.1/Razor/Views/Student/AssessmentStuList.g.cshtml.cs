#pragma checksum "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a80cfdf20d6124b701d37e6a7c615e77144394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AssessmentStuList), @"mvc.1.0.view", @"/Views/Student/AssessmentStuList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/AssessmentStuList.cshtml", typeof(AspNetCore.Views_Student_AssessmentStuList))]
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
#line 1 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\_ViewImports.cshtml"
using dgubbaFinalProject;

#line default
#line hidden
#line 2 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\_ViewImports.cshtml"
using dgubbaFinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\_ViewImports.cshtml"
using dgubbaFinalProject.Models.DomainModels;

#line default
#line hidden
#line 4 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\_ViewImports.cshtml"
using dgubbaFinalProject.Models.Database;

#line default
#line hidden
#line 5 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\_ViewImports.cshtml"
using dgubbaFinalProject.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a80cfdf20d6124b701d37e6a7c615e77144394", @"/Views/Student/AssessmentStuList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72e7f641b793b37f095b11e24629f6b81cae1cbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AssessmentStuList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentAssignmentData>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
  
    ViewData["Title"] = "Students List";

#line default
#line hidden
            BeginContext(85, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(114, 1246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc12bcea6a5f47d7aa4a9c6b7c7add33", async() => {
                BeginContext(120, 111, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"page-header row\">\r\n            <h5 class=\"col-sm-2\">Course: ");
                EndContext();
                BeginContext(232, 18, false);
#line 12 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                                    Write(ViewBag.CourseName);

#line default
#line hidden
                EndContext();
                BeginContext(250, 49, true);
                WriteLiteral("</h5>\r\n            <h5 class=\"col-sm-2\">Teacher: ");
                EndContext();
                BeginContext(300, 19, false);
#line 13 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                                     Write(ViewBag.TeacherName);

#line default
#line hidden
                EndContext();
                BeginContext(319, 23, true);
                WriteLiteral("</h5>\r\n        </div>\r\n");
                EndContext();
#line 15 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
           if (ViewBag.sadlcount == 0)
            {

#line default
#line hidden
                BeginContext(395, 138, true);
                WriteLiteral(" <div class=\"jumbotron\">\r\n                 <p class=\"info\">No Assignments were posted. Check back again later</p>\r\n                 </div>");
                EndContext();
#line 18 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                       }
            else
            {

#line default
#line hidden
                BeginContext(567, 332, true);
                WriteLiteral(@" <table class=""table"">
                    <thead>
                        <tr>
                            <th>Assessment Name</th>
                            <th>Marks Obtained</th>
                            <th>Maximum Marks</th>
                        </tr>
                    </thead>
                    <tbody>
");
                EndContext();
#line 29 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                         foreach (var ite in Model)
                        {

#line default
#line hidden
                BeginContext(979, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(1050, 16, false);
#line 32 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                               Write(ite.assignmentID);

#line default
#line hidden
                EndContext();
                BeginContext(1066, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1110, 19, false);
#line 33 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                               Write(ite.assignmentMarks);

#line default
#line hidden
                EndContext();
                BeginContext(1129, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1173, 22, false);
#line 34 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                               Write(ite.assignmentMaxmarks);

#line default
#line hidden
                EndContext();
                BeginContext(1195, 42, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n");
                EndContext();
#line 36 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                        }

#line default
#line hidden
                BeginContext(1264, 53, true);
                WriteLiteral("                    </tbody>\r\n               </table>");
                EndContext();
#line 38 "C:\Users\Deepa\Downloads\UCM\Summer\SSS\FInal Project\final project\dgubbaFinalProject\dgubbaFinalProject\Views\Student\AssessmentStuList.cshtml"
                       }
        

#line default
#line hidden
                BeginContext(1331, 22, true);
                WriteLiteral("        \r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1360, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentAssignmentData>> Html { get; private set; }
    }
}
#pragma warning restore 1591