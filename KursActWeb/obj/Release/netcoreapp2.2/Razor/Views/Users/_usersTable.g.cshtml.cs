#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26412f36c437f1c3eb481770e20903c299e44964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__usersTable), @"mvc.1.0.view", @"/Views/Users/_usersTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/_usersTable.cshtml", typeof(AspNetCore.Views_Users__usersTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26412f36c437f1c3eb481770e20903c299e44964", @"/Views/Users/_usersTable.cshtml")]
    public class Views_Users__usersTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DbManager.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(56, 442, true);
            WriteLiteral(@"    <div class=""panel"">
        <div class=""new-table"">
            <div class=""new-thead"">
                <div class=""row"">
                    <div class=""col"">№</div>
                    <div class=""col"">Имя</div>
                    <div class=""col"">Роль</div>
                    <div class=""col"">Логин</div>
                    <div class=""col"">Email</div>
                </div>
            </div>
            <div class=""new-tbody"">
");
            EndContext();
#line 17 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
                  
                    int n = 0;
                    foreach (var item in Model)
                    {
                        n++;

#line default
#line hidden
            BeginContext(647, 47, true);
            WriteLiteral("                        <a href=\"#\" class=\"row\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 694, "\"", 726, 3);
            WriteAttributeValue("", 704, "ShowEditMenu(", 704, 13, true);
#line 22 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
WriteAttributeValue("", 717, item.Id, 717, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 725, ")", 725, 1, true);
            EndWriteAttribute();
            BeginContext(727, 47, true);
            WriteLiteral(">\n                            <div class=\"col\">");
            EndContext();
            BeginContext(775, 1, false);
#line 23 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
                                        Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(776, 52, true);
            WriteLiteral("</div>\n                            <div class=\"col\">");
            EndContext();
            BeginContext(829, 9, false);
#line 24 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
                                        Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(838, 52, true);
            WriteLiteral("</div>\n                            <div class=\"col\">");
            EndContext();
            BeginContext(891, 14, false);
#line 25 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
                                        Write(item.Role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(905, 52, true);
            WriteLiteral("</div>\n                            <div class=\"col\">");
            EndContext();
            BeginContext(958, 10, false);
#line 26 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
                                        Write(item.Login);

#line default
#line hidden
            EndContext();
            BeginContext(968, 52, true);
            WriteLiteral("</div>\n                            <div class=\"col\">");
            EndContext();
            BeginContext(1021, 10, false);
#line 27 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
                                        Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 36, true);
            WriteLiteral("</div>\n                        </a>\n");
            EndContext();
#line 29 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1107, 45, true);
            WriteLiteral("            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 34 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1161, 38, true);
            WriteLiteral("    <h4>Отсутствуют пользователи</h4>\n");
            EndContext();
#line 38 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\_usersTable.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DbManager.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
