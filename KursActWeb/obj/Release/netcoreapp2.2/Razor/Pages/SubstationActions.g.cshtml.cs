#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ffdb6e9bab7ab148a71be3a05c3a40319f8133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_SubstationActions), @"mvc.1.0.razor-page", @"/Pages/SubstationActions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SubstationActions.cshtml", typeof(AspNetCore.Pages_SubstationActions), @"{id}/{date?}")]
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
#line 2 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
using System.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}/{date?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ffdb6e9bab7ab148a71be3a05c3a40319f8133", @"/Pages/SubstationActions.cshtml")]
    public class Pages_SubstationActions : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
  
    ViewData["Title"] = Model.PageName;
    Layout = "~/Views/Shared/_Layout.cshtml";
    var ActiveSelector = "active";

#line default
#line hidden
            BeginContext(212, 86, true);
            WriteLiteral("\n<div class=\"panel pageAction--panel d-flex align-content-start flex-wrap\">\n    <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 298, "\"", 341, 2);
            WriteAttributeValue("", 305, "/SubstationPage/", 305, 16, true);
#line 11 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
WriteAttributeValue("", 321, Model.Substation.Id, 321, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(342, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(344, 21, false);
#line 11 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
                                                  Write(Model.Substation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(365, 322, true);
            WriteLiteral(@"</a></h4>
    <i class=""fas fa-angle-right panelAction--divider""></i>
    <h4 class=""active"">История изменений</h4>
</div>

<div class=""panel p-2 mt-2"">
    <div class=""d-flex flex-row horizontal-timeline"">
        <i class=""far fa-calendar-alt fa-2x m-2 ml-3 align-self-center"" title=""Даты, доступные для просмотра""></i>
");
            EndContext();
#line 19 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
         foreach (var day in Model.ActionDates)
        {

#line default
#line hidden
            BeginContext(745, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 759, "\"", 835, 4);
            WriteAttributeValue("", 766, "/substationactions/", 766, 19, true);
#line 21 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
WriteAttributeValue("", 785, Model.Substation.Id, 785, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 805, "/", 805, 1, true);
#line 21 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
WriteAttributeValue("", 806, day.Date.ToShortDateString(), 806, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 836, "\"", 928, 6);
            WriteAttributeValue("", 844, "btn", 844, 3, true);
            WriteAttributeValue(" ", 847, "btn-outline-warning", 848, 20, true);
            WriteAttributeValue(" ", 867, "m-2", 868, 4, true);
            WriteAttributeValue(" ", 871, "mr-0", 872, 5, true);
#line 21 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
WriteAttributeValue(" ", 876, @Model.SelectedDate == day.Date ? "active" : "", 877, 50, false);

#line default
#line hidden
            WriteAttributeValue(" ", 927, "", 928, 1, true);
            EndWriteAttribute();
            BeginContext(929, 18, true);
            WriteLiteral(">\n                ");
            EndContext();
            BeginContext(948, 23, false);
#line 22 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
           Write(day.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(971, 18, true);
            WriteLiteral("\n            </a>\n");
            EndContext();
#line 24 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
        }

#line default
#line hidden
            BeginContext(999, 144, true);
            WriteLiteral("    </div>\n</div>\n\n<div class=\"panel p-4\">\n    <div class=\"vertical-timeline\">\n        <ul class=\"list-unstyled\">\n            <li class=\"title\">");
            EndContext();
            BeginContext(1144, 38, false);
#line 31 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
                         Write(Model.SelectedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1182, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 32 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
             foreach (var action in Model.ActionsForToday)
            {

#line default
#line hidden
            BeginContext(1261, 60, true);
            WriteLiteral("                <li>\n                    <span class=\"time\">");
            EndContext();
            BeginContext(1322, 29, false);
#line 35 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
                                  Write(action.Time.ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 45, true);
            WriteLiteral("</span>\n                    <span class=\"dot\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1396, "\"", 1450, 3);
            WriteAttributeValue("", 1404, "background-color:", 1404, 17, true);
#line 36 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
WriteAttributeValue(" ", 1421, action.DotColor, 1422, 16, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1438, "!important;", 1439, 12, true);
            EndWriteAttribute();
            BeginContext(1451, 96, true);
            WriteLiteral("></span>\n                    <div class=\"content\">\n                        <h3 class=\"subtitle\">");
            EndContext();
            BeginContext(1548, 15, false);
#line 38 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
                                        Write(action.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1565, 23, false);
#line 38 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
                                                         Write(action.Action.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(1588, 49, true);
            WriteLiteral("</h3>\n                        <p class=\"comment\">");
            EndContext();
            BeginContext(1638, 14, false);
#line 39 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
                                      Write(action.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 54, true);
            WriteLiteral("</p>\n                    </div>\n                </li>\n");
            EndContext();
#line 42 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationActions.cshtml"
            }

#line default
#line hidden
            BeginContext(1720, 33, true);
            WriteLiteral("        </ul>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KursActWeb.Pages.SubstationActionsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.SubstationActionsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.SubstationActionsModel>)PageContext?.ViewData;
        public KursActWeb.Pages.SubstationActionsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
