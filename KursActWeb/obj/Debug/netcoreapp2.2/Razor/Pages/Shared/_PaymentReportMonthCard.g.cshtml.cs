#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d8f1e160603b8395dc6554de1ece759ede55bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__PaymentReportMonthCard), @"mvc.1.0.view", @"/Pages/Shared/_PaymentReportMonthCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_PaymentReportMonthCard.cshtml", typeof(AspNetCore.Pages_Shared__PaymentReportMonthCard))]
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
#line 1 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
using KursActWeb.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d8f1e160603b8395dc6554de1ece759ede55bf", @"/Pages/Shared/_PaymentReportMonthCard.cshtml")]
    public class Pages_Shared__PaymentReportMonthCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentReportMonthCard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 575, true);
            WriteLiteral(@"<style>
    .month-head {
        margin-top: -1rem;
        margin-left: 5%;
        width: 90%;
        border-radius: 5px;
        background-color: rgb(19, 132, 177);
        box-shadow: 2px 2px 8px #0000008a;
        color: aliceblue;
        user-select: none;
    }

    .doc-icon {
        cursor: pointer;
        color: rgb(131, 131, 131);
        user-select: none;
    }

        .doc-icon:hover {
            color: rgb(36, 36, 36)
        }
</style>
<div class=""card m-3 mt-4 shadow"" style=""width: 10rem;"">
    <div class=""card-head month-head text-center p-2"">");
            EndContext();
            BeginContext(631, 16, false);
#line 26 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                                                 Write(Model.PeriodName);

#line default
#line hidden
            EndContext();
            BeginContext(647, 59, true);
            WriteLiteral("</div>\n    <div class=\"d-flex justify-content-around m-3\">\n");
            EndContext();
#line 28 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
         if (Model.First.IsEnable)
        {

#line default
#line hidden
            BeginContext(751, 74, true);
            WriteLiteral("            <div>\n                <div class=\"d-flex flex-column doc-icon\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 825, "\"", 865, 1);
#line 31 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
WriteAttributeValue("", 835, Model.First.ReportIconOnClick, 835, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(866, 85, true);
            WriteLiteral(">\n                    <div style=\"font-size: 12px\">АВАНС</div>\n                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 951, "\"", 992, 3);
#line 33 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
WriteAttributeValue("", 959, Model.First.ReportIcon, 959, 23, false);

#line default
#line hidden
            WriteAttributeValue(" ", 982, "fa-3x", 983, 6, true);
            WriteAttributeValue(" ", 988, "p-1", 989, 4, true);
            EndWriteAttribute();
            BeginContext(993, 112, true);
            WriteLiteral("></i>\n                </div>\n                <div>\n                    <i class=\"fas fa-clipboard-list p-1\"></i>");
            EndContext();
            BeginContext(1106, 26, false);
#line 36 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                                                        Write(Model.First.CountAviablePU);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 121, true);
            WriteLiteral("\n                </div>\n                <div>\n                    <i class=\"fas fa-clipboard-check p-1 text-warning\"></i>");
            EndContext();
            BeginContext(1254, 27, false);
#line 39 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                                                                      Write(Model.First.CountPULinkIsOk);

#line default
#line hidden
            EndContext();
            BeginContext(1281, 24, true);
            WriteLiteral("\n                </div>\n");
            EndContext();
#line 41 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                 if (Model.First.CountAviableUSPD > 0)
                {

#line default
#line hidden
            BeginContext(1378, 97, true);
            WriteLiteral("                    <div>\n                        <i class=\"fab fa-hubspot p-1 text-warning\"></i>");
            EndContext();
            BeginContext(1476, 28, false);
#line 44 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                                                                  Write(Model.First.CountAviableUSPD);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 46 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                }

#line default
#line hidden
            BeginContext(1550, 19, true);
            WriteLiteral("            </div>\n");
            EndContext();
#line 48 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
        }

#line default
#line hidden
            BeginContext(1579, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 49 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
         if (Model.Second.IsEnable)
        {

#line default
#line hidden
            BeginContext(1625, 74, true);
            WriteLiteral("            <div>\n                <div class=\"d-flex flex-column doc-icon\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1699, "\"", 1740, 1);
#line 52 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
WriteAttributeValue("", 1709, Model.Second.ReportIconOnClick, 1709, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1741, 86, true);
            WriteLiteral(">\n                    <div style=\"font-size: 12px\">РАСЧЕТ</div>\n                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1827, "\"", 1869, 3);
#line 54 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
WriteAttributeValue("", 1835, Model.Second.ReportIcon, 1835, 24, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1859, "fa-3x", 1860, 6, true);
            WriteAttributeValue(" ", 1865, "p-1", 1866, 4, true);
            EndWriteAttribute();
            BeginContext(1870, 112, true);
            WriteLiteral("></i>\n                </div>\n                <div>\n                    <i class=\"fas fa-clipboard-list p-1\"></i>");
            EndContext();
            BeginContext(1983, 27, false);
#line 57 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                                                        Write(Model.Second.CountAviablePU);

#line default
#line hidden
            EndContext();
            BeginContext(2010, 121, true);
            WriteLiteral("\n                </div>\n                <div>\n                    <i class=\"fas fa-clipboard-check p-1 text-warning\"></i>");
            EndContext();
            BeginContext(2132, 28, false);
#line 60 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                                                                      Write(Model.Second.CountPULinkIsOk);

#line default
#line hidden
            EndContext();
            BeginContext(2160, 24, true);
            WriteLiteral("\n                </div>\n");
            EndContext();
#line 62 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                 if (Model.Second.CountAviableUSPD > 0)
                {

#line default
#line hidden
            BeginContext(2258, 97, true);
            WriteLiteral("                    <div>\n                        <i class=\"fab fa-hubspot p-1 text-warning\"></i>");
            EndContext();
            BeginContext(2356, 29, false);
#line 65 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                                                                  Write(Model.Second.CountAviableUSPD);

#line default
#line hidden
            EndContext();
            BeginContext(2385, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 67 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
                }

#line default
#line hidden
            BeginContext(2431, 19, true);
            WriteLiteral("            </div>\n");
            EndContext();
#line 69 "D:\Repos\kurs-act-master\KursActWeb\Pages\Shared\_PaymentReportMonthCard.cshtml"
        }

#line default
#line hidden
            BeginContext(2460, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentReportMonthCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
