#pragma checksum "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojoSurveyWithValidations/Views/Home/results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "057cbae96ce551ced377138c0a3577fe2906ff8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_results), @"mvc.1.0.view", @"/Views/Home/results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/results.cshtml", typeof(MyApp.Namespace.Home.Views_Home_results))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 11 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojoSurveyWithValidations/Views/Home/results.cshtml"
using dojoSurveyWithValidations.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057cbae96ce551ced377138c0a3577fe2906ff8d", @"/Views/Home/results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24053b7747947c5ce814887f1b435a94cf54603a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 364, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057cbae96ce551ced377138c0a3577fe2906ff8d3263", async() => {
                BeginContext(39, 351, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
        <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(397, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(398, 1122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057cbae96ce551ced377138c0a3577fe2906ff8d4786", async() => {
                BeginContext(404, 2, true);
                WriteLiteral("\n\n");
                EndContext();
                BeginContext(454, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(474, 618, true);
                WriteLiteral(@"            <div class=""container text-center"">
        <h1 class=""text-center m-4"">Submitted Info</h1>

                <div class=""shadow row"">
                    <div class=""col"">
                        <h3 class=""p-4"">Name:</h3>
                        <hr>
                        <h3 class=""p-4"">Location:</h3>
                        <hr>
                        <h3 class=""p-4"">Favorite Stack:</h3>
                        <hr>
                        <h3 class=""p-4"">Comment:</h3>
                    </div>
                    <div class=""col"">
                        <h3 style=""color: blue;"" class=""p-4"">");
                EndContext();
                BeginContext(1093, 10, false);
#line 27 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojoSurveyWithValidations/Views/Home/results.cshtml"
                                                        Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1103, 96, true);
                WriteLiteral("</h3>\n                        <hr>\n                        <h3 style=\"color: blue;\" class=\"p-4\">");
                EndContext();
                BeginContext(1200, 14, false);
#line 29 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojoSurveyWithValidations/Views/Home/results.cshtml"
                                                        Write(Model.Location);

#line default
#line hidden
                EndContext();
                BeginContext(1214, 96, true);
                WriteLiteral("</h3>\n                        <hr>\n                        <h3 style=\"color: blue;\" class=\"p-4\">");
                EndContext();
                BeginContext(1311, 14, false);
#line 31 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojoSurveyWithValidations/Views/Home/results.cshtml"
                                                        Write(Model.Language);

#line default
#line hidden
                EndContext();
                BeginContext(1325, 96, true);
                WriteLiteral("</h3>\n                        <hr>\n                        <h3 style=\"color: blue;\" class=\"p-4\">");
                EndContext();
                BeginContext(1422, 13, false);
#line 33 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojoSurveyWithValidations/Views/Home/results.cshtml"
                                                        Write(Model.Comment);

#line default
#line hidden
                EndContext();
                BeginContext(1435, 78, true);
                WriteLiteral("</h3>\n                    </div>\n                </div>\n    </div>\n    </div>\n");
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
            BeginContext(1520, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
