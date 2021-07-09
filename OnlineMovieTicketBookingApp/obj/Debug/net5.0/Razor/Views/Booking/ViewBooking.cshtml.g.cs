#pragma checksum "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f8add867a3215763483df7d6e04a2853ea5e35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ViewBooking), @"mvc.1.0.view", @"/Views/Booking/ViewBooking.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f8add867a3215763483df7d6e04a2853ea5e35", @"/Views/Booking/ViewBooking.cshtml")]
    public class Views_Booking_ViewBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<OnlineMovieTicketBookingApp.Models.Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
  
    ViewData["Title"] = "View Booking";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .button{
        text-align:center;
    }
</style>
<div style=""padding:50px 0px 30px 0px"" class=""text-center"">
    <h3>My Booking</h3>
</div>

<div class=""table-responsive-lg"">
    <table class=""table"">
        <thead class=""thead-light"">
            <tr>
                <th>
                    Booking Id
                </th>
                <th>
                    Movie Name
                </th>
                <th>
                    Show Date & Time
                </th>
                <th>
                    Ticket Price
                </th>
                <th>
                    Total Ticket(s)
                </th>
                <th>
                    Total Price
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
             if (Model != null)
            {
                foreach (OnlineMovieTicketBookingApp.Models.Booking item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n\n                        <td>\n                            ");
#nullable restore
#line 49 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
                       Write(Html.DisplayFor(Model => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 52 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
                       Write(Html.DisplayFor(Model => item.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 55 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
                       Write(Html.DisplayFor(Model => item.Show.Date_And_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 58 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
                       Write(Html.DisplayFor(Model => item.Movie.Ticket_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 61 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
                       Write(Html.DisplayFor(Model => item.Total_Tickets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 64 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Total_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 67 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n<br /><br />\n<div class=\"button\">\n    ");
#nullable restore
#line 74 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Booking\ViewBooking.cshtml"
Write(Html.ActionLink("Return to Profile", "Index", "User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<OnlineMovieTicketBookingApp.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591