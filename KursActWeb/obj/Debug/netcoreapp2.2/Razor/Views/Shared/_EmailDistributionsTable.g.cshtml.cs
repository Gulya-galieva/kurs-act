#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a43367ef90bd80ff22efcdbc1d214b83ff67bc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmailDistributionsTable), @"mvc.1.0.view", @"/Views/Shared/_EmailDistributionsTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_EmailDistributionsTable.cshtml", typeof(AspNetCore.Views_Shared__EmailDistributionsTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a43367ef90bd80ff22efcdbc1d214b83ff67bc0", @"/Views/Shared/_EmailDistributionsTable.cshtml")]
    public class Views_Shared__EmailDistributionsTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KursActWeb.EmailServices.Distribution>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 328, true);
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead>
        <tr class=""thead-dark"">
            <th>Имя рассылки</th>
            <th>Последняя отправка</th>
            <th>Содержание</th>
            <th>Режим отправки</th>
            <th>Кому (Список адресов)</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
         foreach (var dist in Model)
        {

#line default
#line hidden
            BeginContext(433, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(492, 9, false);
#line 19 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
               Write(dist.Name);

#line default
#line hidden
            EndContext();
            BeginContext(501, 169, true);
            WriteLiteral(" <br/>\n                    <i class=\"fas fa-trash-alt fa-2x text-danger m-2\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Удалить рассылку\" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 670, "\"", 717, 3);
            WriteAttributeValue("", 680, "DeleteEmailDistribution(\'", 680, 25, true);
#line 20 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 705, dist.Name, 705, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 715, "\')", 715, 2, true);
            EndWriteAttribute();
            BeginContext(718, 172, true);
            WriteLiteral("></i>\n                    <i class=\"fas fa-sign-out-alt fa-2x text-primary m-2\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Отправить письма\" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 890, "\"", 923, 3);
            WriteAttributeValue("", 900, "SendEmail(\'", 900, 11, true);
#line 21 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 911, dist.Name, 911, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 921, "\')", 921, 2, true);
            EndWriteAttribute();
            BeginContext(924, 48, true);
            WriteLiteral("></i>\n                </td>\n                <td>");
            EndContext();
            BeginContext(973, 17, false);
#line 23 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
               Write(dist.LastSendDate);

#line default
#line hidden
            EndContext();
            BeginContext(990, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1017, 20, false);
#line 24 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
               Write(dist.ContentTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 74, true);
            WriteLiteral(" <br/> <i class=\"fas fa-edit fa-2x text-info m-2\" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1111, "\"", 1152, 3);
            WriteAttributeValue("", 1121, "ChangeContentType(\'", 1121, 19, true);
#line 24 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 1140, dist.Name, 1140, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1150, "\')", 1150, 2, true);
            EndWriteAttribute();
            BeginContext(1153, 32, true);
            WriteLiteral("></i> </td>\n                <td>");
            EndContext();
            BeginContext(1186, 21, false);
#line 25 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
               Write(dist.SendTimeModeName);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 74, true);
            WriteLiteral(" <br/> <i class=\"fas fa-edit fa-2x text-info m-2\" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1281, "\"", 1323, 3);
            WriteAttributeValue("", 1291, "ChangeSendTimeMode(\'", 1291, 20, true);
#line 25 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 1311, dist.Name, 1311, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1321, "\')", 1321, 2, true);
            EndWriteAttribute();
            BeginContext(1324, 33, true);
            WriteLiteral("></i> </td>\n                <td>\n");
            EndContext();
#line 27 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
                     foreach (var email in dist.EMailList)
                    {

#line default
#line hidden
            BeginContext(1438, 111, true);
            WriteLiteral("                        <i class=\"fas fa-trash-alt text-danger mr-2\" data-toggle=\"tooltip\" data-placement=\"top\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1549, "\"", 1585, 6);
            WriteAttributeValue("", 1557, "Удалить", 1557, 7, true);
            WriteAttributeValue(" ", 1564, "\'", 1565, 2, true);
#line 29 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 1566, email, 1566, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1572, "\'", 1572, 1, true);
            WriteAttributeValue(" ", 1573, "из", 1574, 3, true);
            WriteAttributeValue(" ", 1576, "рассылки", 1577, 9, true);
            EndWriteAttribute();
            BeginContext(1586, 25, true);
            WriteLiteral(" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1611, "\"", 1656, 6);
            WriteAttributeValue("", 1621, "DeleteEmail(\'", 1621, 13, true);
#line 29 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 1634, dist.Name, 1634, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1644, "\',", 1644, 2, true);
            WriteAttributeValue(" ", 1646, "\'", 1647, 2, true);
#line 29 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 1648, email, 1648, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1654, "\')", 1654, 2, true);
            EndWriteAttribute();
            BeginContext(1657, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(1664, 5, false);
#line 29 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
                                                                                                                                                                                                                            Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1669, 8, true);
            WriteLiteral(" <br />\n");
            EndContext();
#line 30 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
                    }

#line default
#line hidden
            BeginContext(1699, 151, true);
            WriteLiteral("                    <i class=\"fas fa-address-card fa-2x text-success mr-2\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Добавить Email к рассылке\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1850, "\"", 1882, 3);
            WriteAttributeValue("", 1860, "AddEmail(\'", 1860, 10, true);
#line 31 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
WriteAttributeValue("", 1870, dist.Name, 1870, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1880, "\')", 1880, 2, true);
            EndWriteAttribute();
            BeginContext(1883, 71, true);
            WriteLiteral(" style=\"cursor: pointer;\"></i>\n                </td>\n            </tr>\n");
            EndContext();
#line 34 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_EmailDistributionsTable.cshtml"
        }

#line default
#line hidden
            BeginContext(1964, 343, true);
            WriteLiteral(@"        <tr>
            <td><i class=""fas fa-calendar-plus fa-2x text-success m-2"" style=""cursor: pointer;"" data-toggle=""tooltip"" data-placement=""top"" title=""Создать новую рассылку"" onclick=""AddEmailDistribution()""></i></td>
        </tr>
    </tbody>
</table>

<script>
    $(function () { $('[data-toggle=""tooltip""]').tooltip() })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KursActWeb.EmailServices.Distribution>> Html { get; private set; }
    }
}
#pragma warning restore 1591
