#pragma checksum "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ea220946cf0a5db68184982ea3ba9e524bea34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
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
#nullable restore
#line 2 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
using OnlineMovieTicketBookingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ea220946cf0a5db68184982ea3ba9e524bea34", @"/Views/User/Register.cshtml")]
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieTicketBookingApp.Models.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<style>\n");
            WriteLiteral(@"        body {
            /*color: white;*/
            /*background-color: #252526;*/
            overflow-x: hidden;
        }
        .heading {
            text-align: center;
            position:relative;
            top: 50px;
        }
        section{
            left:425px;
            position:relative;
            top:80px;

        }
        .age-restrict{
            color:red;
            font-size:13px;
            text-align:center;
            position:absolute;
            top:200px;
            left:500px;
        }

</style>


<div class=""heading"">
    <h4>Registration</h4>
    <p>
        Please provide the following information to register.
        <br />
        You have to be at least 12 years of age to be eligible for registration.
        <br />
    </p>
</div>
<div class=""age-restrict"">");
#nullable restore
#line 52 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
                     Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n");
            WriteLiteral("\n<section>\n");
#nullable restore
#line 143 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
     using (Html.BeginForm("Register", "User", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<form>\n    <div class=\"form-group col-md-4\">\n        <label for=\"inputUsername\">Username</label>\n        ");
#nullable restore
#line 148 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
   Write(Html.EditorFor(m => m.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 149 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
   Write(Html.ValidationMessageFor(m => m.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <br />\n    </div>\n    <div class=\"form-row\">\n        <div class=\"form-group col-md-4\">\n            <label for=\"inputPassword\">Password</label>\n            ");
#nullable restore
#line 155 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.PasswordFor(m => m.UserPassword, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 156 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.UserPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n        </div>\n    </div>\n    <div class=\"form-group col-md-4\">\n        <label for=\"inputPassword2\">Confirm Password</label>\n        ");
#nullable restore
#line 162 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
   Write(Html.PasswordFor(m => m.Confirm_Password, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 163 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
   Write(Html.ValidationMessageFor(m => m.Confirm_Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <br />\n    </div>\n\n    <div class=\"form-row\">\n        <div class=\"form-group col-md-4\">\n            <label for=\"inputFirstName\">First Name</label>\n            ");
#nullable restore
#line 170 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.EditorFor(m => m.First_Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 171 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.First_Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <br />\n        <div class=\"form-group col-md-4\">\n            <label for=\"inputLastName\">Last Name</label>\n            ");
#nullable restore
#line 176 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.EditorFor(m => m.Last_Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 177 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Last_Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <br />\n        <div class=\"form-group col-md-4\">\n            ");
#nullable restore
#line 181 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 182 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.EditorFor(m => m.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <br />\n        <div class=\"form-group col-md-4\">\n            <label for=\"inputDOB\">Date of Birth</label>\n            ");
#nullable restore
#line 187 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(model => model.Date_Of_Birth, new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 188 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Date_Of_Birth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n        </div>\n\n\n        <div class=\"form-group col-md-4\">\n            <label for=\"inputPhone\">Phone no.</label>\n            ");
#nullable restore
#line 195 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.EditorFor(m => m.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 196 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <br />\n        <div class=\"form-group col-md-4\">\n            <label for=\"inputEmail\">Email</label>\n            ");
#nullable restore
#line 201 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.EditorFor(m => m.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 202 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <br />\n    </div>\n    <div class=\"form-group col-md-4\">\n        <label for=\"inputAddress\">Address</label>\n        <br />\n        ");
#nullable restore
#line 209 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
   Write(Html.TextAreaFor(model => model.Address, new { @class = "form-control", @cols = 80, @rows = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <br />\n    </div>\n    <div>\n        <p>\n            <button type=\"submit\" class=\"btn btn-light\">Register</button>\n            <a");
            BeginWriteAttribute("href", " href=\'", 9303, "\'", 9338, 1);
#nullable restore
#line 215 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
WriteAttributeValue("", 9310, Url.Action("Index", "Home"), 9310, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <input type=\"button\" class=\"btn btn-secondary\" value=\"Cancel\" />\n            </a>\n            <br /><br /><br />\n        </p>\n    </div>\n\n</form>");
#nullable restore
#line 222 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Register.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\n<br />\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieTicketBookingApp.Models.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
