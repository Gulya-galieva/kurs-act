#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df08d46438de1c95294a3127485fae46be9aa05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Comments), @"mvc.1.0.view", @"/Views/Shared/_Comments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Comments.cshtml", typeof(AspNetCore.Views_Shared__Comments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df08d46438de1c95294a3127485fae46be9aa05", @"/Views/Shared/_Comments.cshtml")]
    public class Views_Shared__Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KursActWeb.ViewModels.CommentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(86, 28, true);
            WriteLiteral("    <div class=\"pl-5 pr-5\">\n");
            EndContext();
#line 6 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
         foreach (var item in Model.Reverse())
        {

#line default
#line hidden
            BeginContext(171, 138, true);
            WriteLiteral("            <div class=\"comment--item comment--left\">\n                <div class=\"comment--avatar avatar-circle\">\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 309, "\"", 443, 3);
            WriteAttributeValue("", 315, "http://aiiscue.kursufa.ru/account/GetAvatar?hash=", 315, 49, true);
#line 10 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
WriteAttributeValue("", 364, item.Author.GetHashCode(), 364, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 390, "&size=80&key=2ec8466f0e50235fbb97306dbec850302dfaa6ae", 390, 53, true);
            EndWriteAttribute();
            BeginContext(444, 289, true);
            WriteLiteral(@" alt="""" class=""rounded-circle border border-danger"">
                </div>

                <div class=""comment--content shadow"">
                    <div class=""comment--info d-flex flex-row"">
                        <h6 class=""comment--user h6"">
                            <a href=""#"">");
            EndContext();
            BeginContext(734, 11, false);
#line 16 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
                                   Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(745, 92, true);
            WriteLiteral("</a>\n                        </h6>\n                        <span class=\"ml-4 text-black-50\">");
            EndContext();
            BeginContext(838, 29, false);
#line 18 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
                                                    Write(item.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(867, 124, true);
            WriteLiteral("</span>\n                        <i class=\"fas fa-trash comment-delete align-self-center ml-auto\" title=\"Удалить комментарий\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 991, "\"", 1024, 3);
            WriteAttributeValue("", 1001, "DeleteComment(", 1001, 14, true);
#line 19 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
WriteAttributeValue("", 1015, item.Id, 1015, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1023, ")", 1023, 1, true);
            EndWriteAttribute();
            BeginContext(1025, 122, true);
            WriteLiteral("></i>\n                    </div>\n                    <div class=\"comment--text text-black-50\">\n                        <p>");
            EndContext();
            BeginContext(1148, 9, false);
#line 22 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
                      Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 74, true);
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 26 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
        }

#line default
#line hidden
            BeginContext(1241, 11, true);
            WriteLiteral("    </div>\n");
            EndContext();
#line 28 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1261, 259, true);
            WriteLiteral(@"    <div class=""d-flex justify-content-center"">
        <div class=""d-flex flex-column"">
            <i class=""far fa-comment-dots align-self-center fa-3x""></i>
            <p class=""mt-2 mb-2 align-self-center"">Нет комментариев</p>
        </div>
    </div>
");
            EndContext();
#line 37 "D:\Repos\kurs-act-master\KursActWeb\Views\Shared\_Comments.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KursActWeb.ViewModels.CommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591