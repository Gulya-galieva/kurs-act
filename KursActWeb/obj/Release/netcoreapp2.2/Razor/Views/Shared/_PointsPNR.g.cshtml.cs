#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99958047d613101badc7f08fd0b218443a956b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PointsPNR), @"mvc.1.0.view", @"/Views/Shared/_PointsPNR.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PointsPNR.cshtml", typeof(AspNetCore.Views_Shared__PointsPNR))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99958047d613101badc7f08fd0b218443a956b0e", @"/Views/Shared/_PointsPNR.cshtml")]
    public class Views_Shared__PointsPNR : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KursActWeb.ViewModels.RegPointRowViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(84, 434, true);
            WriteLiteral(@"    <div class=""panel"">
        <table class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">№</th>
                    <th scope=""col"">Адрес объекта</th>
                    <th scope=""col"">Место установки</th>
                    <th scope=""col"">Тип ПУ</th>
                    <th scope=""col"">Заводской №</th>
                    <th scope=""col"">Номер тел.</th>
");
            EndContext();
#line 15 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                     if (User.IsInRole("pnr") || User.IsInRole("administrator"))
                    {

#line default
#line hidden
            BeginContext(621, 45, true);
            WriteLiteral("                        <th scope=\"col\"></th>");
            EndContext();
#line 17 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                                             }

#line default
#line hidden
            BeginContext(668, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 18 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                     if (User.IsInRole("ascuemaster") || User.IsInRole("administrator"))
                    {

#line default
#line hidden
            BeginContext(779, 45, true);
            WriteLiteral("                        <th scope=\"col\"></th>");
            EndContext();
#line 20 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                                             }

#line default
#line hidden
            BeginContext(826, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 21 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                     if (User.IsInRole("pnr") || User.IsInRole("administrator"))
                    {

#line default
#line hidden
            BeginContext(929, 45, true);
            WriteLiteral("                        <th scope=\"col\"></th>");
            EndContext();
#line 23 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                                             }

#line default
#line hidden
            BeginContext(976, 63, true);
            WriteLiteral("                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 27 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                  
                    int n = 0;
                    foreach (var item in Model)
                    {
                        n++;

#line default
#line hidden
            BeginContext(1188, 59, true);
            WriteLiteral("                <tr>\n                    <th scope=\"row\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1247, "\"", 1280, 2);
            WriteAttributeValue("", 1254, "/RegPoint/Edit?id=", 1254, 18, true);
#line 33 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 1272, item.Id, 1272, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1281, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1283, 1, false);
#line 33 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                                                                    Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 34, true);
            WriteLiteral("</a></th>\n                    <td>");
            EndContext();
            BeginContext(1319, 12, false);
#line 34 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                   Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1362, 17, false);
#line 35 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                   Write(item.InstallPlace);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1410, 11, false);
#line 36 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                   Write(item.TypePU);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1452, 14, false);
#line 37 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                   Write(item.SerialNum);

#line default
#line hidden
            EndContext();
            BeginContext(1466, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1497, 13, false);
#line 38 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                   Write(item.PhoneNum);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 39 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                     if (User.IsInRole("pnr") || User.IsInRole("administrator"))
                    {

#line default
#line hidden
            BeginContext(1619, 179, true);
            WriteLiteral("                        <td>\n                            <div class=\"zoom\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Флаг \'Связь с ПУ\'\">\n                                <i");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1798, "\"", 1831, 3);
            WriteAttributeValue("", 1808, "Switch_LinkOk(", 1808, 14, true);
#line 43 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 1822, item.Id, 1822, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1830, ")", 1830, 1, true);
            EndWriteAttribute();
            BeginContext(1832, 31, true);
            WriteLiteral(" class=\"fab fa-gg-circle fa-2x\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1863, "\"", 1914, 5);
            WriteAttributeValue("", 1871, "color:", 1871, 6, true);
#line 43 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 1877, item.IsLinkOkColor, 1877, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1896, ";", 1896, 1, true);
            WriteAttributeValue(" ", 1897, "cursor:", 1898, 8, true);
            WriteAttributeValue(" ", 1905, "pointer;", 1906, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1915, "\"", 1937, 2);
            WriteAttributeValue("", 1920, "IsLinkOk_", 1920, 9, true);
#line 43 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 1929, item.Id, 1929, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1938, 71, true);
            WriteLiteral("></i>\n                            </div>\n                        </td>\n");
            EndContext();
#line 46 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                    }

#line default
#line hidden
            BeginContext(2031, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 47 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                     if (User.IsInRole("ascuemaster") || User.IsInRole("administrator"))
                    {
                    }

#line default
#line hidden
            BeginContext(2164, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 50 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                     if (User.IsInRole("pnr") || User.IsInRole("administrator"))
                    {

#line default
#line hidden
            BeginContext(2267, 189, true);
            WriteLiteral("                        <td>\n                            <div class=\"zoom\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Флаг \'Добавлено в ПО АСКУЭ\'\">\n                                <i");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2456, "\"", 2495, 3);
            WriteAttributeValue("", 2466, "Switch_AscueChecked(", 2466, 20, true);
#line 54 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 2486, item.Id, 2486, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2494, ")", 2494, 1, true);
            EndWriteAttribute();
            BeginContext(2496, 33, true);
            WriteLiteral(" class=\"fas fa-plus-circle fa-2x\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2529, "\"", 2586, 5);
            WriteAttributeValue("", 2537, "color:", 2537, 6, true);
#line 54 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 2543, item.IsAscueCheckedColor, 2543, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 2568, ";", 2568, 1, true);
            WriteAttributeValue(" ", 2569, "cursor:", 2570, 8, true);
            WriteAttributeValue(" ", 2577, "pointer;", 2578, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2587, "\"", 2615, 2);
            WriteAttributeValue("", 2592, "IsAscueChecked_", 2592, 15, true);
#line 54 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 2607, item.Id, 2607, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2616, 259, true);
            WriteLiteral(@"></i>
                            </div>
                        </td>
                        <td>
                            <div class=""zoom"" data-toggle=""tooltip"" data-placement=""top"" title=""Флаг 'Работает в ПО АСКУЭ'"">
                                <i");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2875, "\"", 2909, 3);
            WriteAttributeValue("", 2885, "Switch_AscueOk(", 2885, 15, true);
#line 59 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 2900, item.Id, 2900, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2908, ")", 2908, 1, true);
            EndWriteAttribute();
            BeginContext(2910, 34, true);
            WriteLiteral(" class=\"fas fa-check-circle fa-2x\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2944, "\"", 2996, 5);
            WriteAttributeValue("", 2952, "color:", 2952, 6, true);
#line 59 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 2958, item.IsAscueOkColor, 2958, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 2978, ";", 2978, 1, true);
            WriteAttributeValue(" ", 2979, "cursor:", 2980, 8, true);
            WriteAttributeValue(" ", 2987, "pointer;", 2988, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2997, "\"", 3020, 2);
            WriteAttributeValue("", 3002, "IsAscueOk_", 3002, 10, true);
#line 59 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 3012, item.Id, 3012, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3021, 249, true);
            WriteLiteral("></i>\n                            </div>\n                        </td>\n                        <td>\n                            <div class=\"zoom\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Флаг \'Замена ПУ\'\">\n                                <i");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3270, "\"", 3306, 3);
            WriteAttributeValue("", 3280, "Switch_ReplaceOk(", 3280, 17, true);
#line 64 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 3297, item.Id, 3297, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3305, ")", 3305, 1, true);
            EndWriteAttribute();
            BeginContext(3307, 34, true);
            WriteLiteral(" class=\"fas fa-times-circle fa-2x\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3341, "\"", 3393, 5);
            WriteAttributeValue("", 3349, "color:", 3349, 6, true);
#line 64 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 3355, item.IsReplaceColor, 3355, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 3375, ";", 3375, 1, true);
            WriteAttributeValue(" ", 3376, "cursor:", 3377, 8, true);
            WriteAttributeValue(" ", 3384, "pointer;", 3385, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3394, "\"", 3417, 2);
            WriteAttributeValue("", 3399, "IsReplace_", 3399, 10, true);
#line 64 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
WriteAttributeValue("", 3409, item.Id, 3409, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3418, 71, true);
            WriteLiteral("></i>\n                            </div>\n                        </td>\n");
            EndContext();
#line 67 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                    }

#line default
#line hidden
            BeginContext(3511, 22, true);
            WriteLiteral("                </tr>\n");
            EndContext();
#line 69 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(3573, 49, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n");
            EndContext();
#line 74 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_PointsPNR.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KursActWeb.ViewModels.RegPointRowViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
