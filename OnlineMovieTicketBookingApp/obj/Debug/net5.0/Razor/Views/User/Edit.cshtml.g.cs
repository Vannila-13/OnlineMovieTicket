#pragma checksum "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "481a602148d95299258af3037991e886a1cbd97f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"481a602148d95299258af3037991e886a1cbd97f", @"/Views/User/Edit.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieTicketBookingApp.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
   ViewData["Title"] = "Customer Edit";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<style>\n    .heading {\n        text-align: center;\n        position: relative;\n        top: 50px;\n    }\n\n    .container {\n        position: relative;\n        top: 50px;\n    }\n</style>\n\n");
#nullable restore
#line 20 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <p class=\"alert alert-primary\">");
#nullable restore
#line 23 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
                                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>");
#nullable restore
#line 24 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"heading\">\n    <h4> Edit Profile</h4>\n</div>\n<br />\n\n<div class=\"container\">\n    <div class=\"row justify-content-md-center\">\n        <div class=\"col-md-4\">\n");
#nullable restore
#line 34 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
             using (Html.BeginForm("Edit", "User", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.LabelFor(m => m.First_Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.EditorFor(m => m.First_Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.LabelFor(m => m.Last_Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.EditorFor(m => m.Last_Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.LabelFor(m => m.Gender));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.EditorFor(m => m.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label for=\"inputAddress\">Address</label>\n");
#nullable restore
#line 43 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.TextAreaFor(model => model.Address, new { @class = "form-control", @cols = 80, @rows = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label for=\"inputDOB\">Date of Birth</label>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "481a602148d95299258af3037991e886a1cbd97f8079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 45 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Date_Of_Birth);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <br />\n");
#nullable restore
#line 47 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.LabelFor(m => m.Phone));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.EditorFor(m => m.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
           Write(Html.EditorFor(m => m.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\n");
            WriteLiteral("                <button class=\"btn btn-secondary\">Update Profile</button>");
#nullable restore
#line 54 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Edit.cshtml"
                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "481a602148d95299258af3037991e886a1cbd97f11493", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <br />\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieTicketBookingApp.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
