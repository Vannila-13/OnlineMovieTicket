#pragma checksum "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c31bc68dbea3c4756852664b33a6c9a411e48a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c31bc68dbea3c4756852664b33a6c9a411e48a9", @"/Views/Movie/Details.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieTicketBookingApp.Models.MovieTimeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n\n<style>\n    .view-details{\n        background-image:url(");
#nullable restore
#line 15 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                        Write(Model.Movie.BgImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
        background-size:cover;
        background-repeat: no-repeat;
        height:1000px;

    }
    video{
        width:40%;
        height: auto;
        position: relative;
        left:50px;
        top: 100px;

    }
        .watch {
            top: 100px;
            position: relative;
            text-align: center;
            width: 600px;
            color:darkgrey;
        }
        .details {
            color: white;
            left: 50px;
            top: 110px;
            position: relative;
            text-align: left;
            font-size: 14px;
            font-family: Arial, Helvetica, sans-serif;
            width: 550px;
        }
        .label {
            color:darkgrey;
        }
    .show-times {
        text-align: center;
        background-color: black;
        height: auto;
        color: white;
    }
        .view-showtimes{
            /*left: 80px;*/
           /* position: relative;*/
            text-align:center;
            margin-left: auto;
            margi");
            WriteLiteral(@"n-right: auto;
            
        }
        .button-container{
            width:100px;
            margin: 5px;
            padding:5px;
            border: 1px solid white;
            float:left;
            left:370px;
            position: relative;
         }
        .showtime-date{
            position:absolute;
            left:550px;
            float:left;
        }
</style>

<section class=""view-details"">

    <div class=""watch"">
        <h4>Watch the trailer</h4>
    </div>

    <video");
            BeginWriteAttribute("src", " src=", 1824, "", 1851, 1);
#nullable restore
#line 85 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
WriteAttributeValue("", 1829, Model.Movie.Trailer, 1829, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" controls> </video>\n\n    <div class=\"details\">\n        <h5>Movie Details</h5>\n        <table>\n            <tr>\n                <td class=\"label\">Genre: </td>\n                <td>");
#nullable restore
#line 92 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Html.DisplayFor(model => model.Movie.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> </td>\n                <td class=\"label\">Cast:        </td>\n                <td>");
#nullable restore
#line 95 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Html.DisplayFor(model => model.Movie.Cast));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n            </tr>\n            <tr>\n                <td class=\"label\">Rating: </td>\n                <td>");
#nullable restore
#line 101 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Html.DisplayFor(model => model.Movie.Age_Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> </td>\n                <td class=\"label\">Director:     </td>\n                <td>");
#nullable restore
#line 104 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Html.DisplayFor(model => model.Movie.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n            </tr>\n            <tr>\n                <td class=\"label\">Language: </td>\n                <td>");
#nullable restore
#line 110 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Html.DisplayFor(model => model.Movie.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> </td>\n                <td class=\"label\">Distributor:    </td>\n                <td>");
#nullable restore
#line 113 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Html.DisplayFor(model => model.Movie.Distributor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n            </tr>\n            <tr>\n                <td class=\"label\">Release: </td>\n                <td>");
#nullable restore
#line 119 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", Model.Movie.Release_Date)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> </td>\n                <td class=\"label\">Runtime: </td>\n                <td>");
#nullable restore
#line 122 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
               Write(Html.DisplayFor(model => model.Movie.Run_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes</td>\n            </tr>\n        </table>\n        <br /><br />\n        <h5>Synopsis</h5>\n        <p>\n            ");
#nullable restore
#line 128 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n\n    </div>\n\n</section>\n<section class=\"show-times\">\n    <div>\n        <br />\n        <h4>View Showtimes</h4>\n");
            WriteLiteral("        ");
#nullable restore
#line 139 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    <div>\n");
#nullable restore
#line 143 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
           int prevDate = 0;
            int currDate = 0;

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
             foreach (var item in Model.Shows)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                 if (item.Date_And_Time.Date >= DateTime.Now.Date)
                {
                    prevDate = currDate;
                    currDate = item.Date_And_Time.Day;


                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                     if (item.Date_And_Time.Day != prevDate)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br /><br /><br />\n");
            WriteLiteral("                        <p class=\"showtime-date\"><b>");
#nullable restore
#line 158 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                                               Write(item.Date_And_Time.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n                        <br />");
            WriteLiteral("                              <div class=\"button-container\"> ");
#nullable restore
#line 160 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                                                        Write(item.Date_And_Time.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 173 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                              
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"button-container\"> ");
#nullable restore
#line 177 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                              Write(item.Date_And_Time.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 190 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                              

                        prevDate = currDate;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 193 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n");
            WriteLiteral("    </div>\n    <br /><br /><br />\n                <div>\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 8498, "\"", 8553, 3);
            WriteAttributeValue("", 8508, "location.href=\'", 8508, 15, true);
#nullable restore
#line 248 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
WriteAttributeValue("", 8523, Url.Action("Index", "Movie"), 8523, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8552, "\'", 8552, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Return to Movies</button>\n\n");
#nullable restore
#line 250 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                     if (Model.Shows.Count() != 0) { 
                        
                            var pageName = "Index";
                            var controller = "Booking";
                            if (TempData.Peek("CustomerId") == null)
                            {
                                pageName = "Login";
                                controller = "User";
                            }
                        
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 260 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                   Write(Html.ActionLink("Buy Tickets", pageName, controller, new { movieId = Model.Movie.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 260 "C:\Users\user\Downloads\TicketBooking-master (2)\TicketBooking-master\OnlineMovieTicketBookingApp\Views\Movie\Details.cshtml"
                                                                                                                                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br /><br /><br />\n                </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieTicketBookingApp.Models.MovieTimeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
