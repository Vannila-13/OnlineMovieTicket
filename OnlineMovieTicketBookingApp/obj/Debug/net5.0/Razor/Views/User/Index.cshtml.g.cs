#pragma checksum "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df6ddb6d7a5f031107e3c6e1855994625ee77bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df6ddb6d7a5f031107e3c6e1855994625ee77bc", @"/Views/User/Index.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieTicketBookingApp.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
   ViewData["Title"] = "UserProfile";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    .container1{\n        width:1000px;\n        position: relative;\n        float: left;\n        left:100px;\n        margin:5px;\n        top:50px;\n    }\n</style>\n<div class=\"container1\">\n        <h3>My Profile</h3>   ");
#nullable restore
#line 16 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
                         Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <br /><br />\n    <table>\n        <tr>\n            <th>First Name</th>\n            <td> ");
#nullable restore
#line 21 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
            Write(Html.DisplayFor(Model => Model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n        </tr>\n        <tr>\n            <th> Last Name </th>\n            <td> ");
#nullable restore
#line 25 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
            Write(Html.DisplayFor(Model => Model.Last_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th>Gender</th>\n            <td> ");
#nullable restore
#line 29 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
            Write(Html.DisplayFor(Model => Model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th>Date of Birth</th>\n            <td>");
#nullable restore
#line 33 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
           Write(Model.Date_Of_Birth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th>Address</th>\n            <td>");
#nullable restore
#line 37 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
           Write(Html.DisplayFor(Model => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th>Phone no.</th>\n            <td>");
#nullable restore
#line 41 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th>Email</th>\n            <td>");
#nullable restore
#line 45 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </table>\n    <br /><br />\n    <h3> View Bookings</h3>\n    <div>\n        ");
#nullable restore
#line 51 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\User\Index.cshtml"
   Write(Html.ActionLink("View Booking Details", "ViewBooking", "Booking", new { customerId = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <br /><br />\n</div>\n");
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
