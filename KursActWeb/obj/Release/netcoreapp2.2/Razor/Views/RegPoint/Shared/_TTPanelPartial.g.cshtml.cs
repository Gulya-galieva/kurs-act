#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24cc1358461fc12ce043f35dbf586c8db89b0e4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegPoint_Shared__TTPanelPartial), @"mvc.1.0.view", @"/Views/RegPoint/Shared/_TTPanelPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegPoint/Shared/_TTPanelPartial.cshtml", typeof(AspNetCore.Views_RegPoint_Shared__TTPanelPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24cc1358461fc12ce043f35dbf586c8db89b0e4a", @"/Views/RegPoint/Shared/_TTPanelPartial.cshtml")]
    public class Views_RegPoint_Shared__TTPanelPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1199, true);
            WriteLiteral(@"<div class=""col-lg-6 d-flex"">
    <div class=""panel align-self-stretch"">
        <div class=""panel-heading d-flex"">
            <h3 class=""panel-title"">Трансформаторы тока</h3>
            <div class=""spinner-border spinner-border-sm ml-auto text-orange align-self-center panel-spinner"" role=""status"">
                <span class=""sr-only"">Сохранение...</span>
            </div>
        </div>

        <div class=""panel-content panel-no-gutter-top"">
            <div class=""row d-flex no-gutter"">
                <div class=""col-md-3 ml-5"">
                    <span class=""float-label--no-parent"">Сер. номер</span>
                </div>
                <div class=""col-md-3 ml-2"">
                    <span class=""float-label--no-parent"">№ пломбы</span>
                </div>
                <div class=""col-md-3 ml-2"">
                    <span class=""float-label--no-parent""> КТТ</span>
                </div>
            </div>

            <div class=""input-group"">
                <div class=""input-group-prepend"">");
            WriteLiteral("\n                    <span class=\"input-group-text\">A</span>\n                </div>\n                <input type=\"text\" class=\"form-control\" id=\"TT_A_Serial\" name=\"TT_A_Serial\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1199, "\"", 1236, 1);
#line 27 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 1207, Model.InstallAct.TT_A_Serial, 1207, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1237, 146, true);
            WriteLiteral(" form=\"installActForm\" onchange=\"Update_InstallAct(this)\">\n                <input type=\"text\" class=\"form-control\" id=\"Seal_TT_A\" name=\"Seal_TT_A\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1383, "\"", 1418, 1);
#line 28 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 1391, Model.InstallAct.Seal_TT_A, 1391, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1419, 165, true);
            WriteLiteral(" form=\"installActForm\" onchange=\"Update_InstallAct(this)\">\n                <select id=\"TT_Koefficient\" class=\"form-control\" name=\"TT_Koefficient\" id=\"TT_Koefficient\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1584, "\"", 1624, 1);
#line 29 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 1592, Model.InstallAct.TT_Koefficient, 1592, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1625, 1212, true);
            WriteLiteral(@" form=""installActForm"" onchange=""Update_InstallAct(this);Set_KoefficientInputs()"">
                    <option>50/5</option>
                    <option>75/5</option>
                    <option>100/5</option>
                    <option>150/5</option>
                    <option>200/5</option>
                    <option>250/5</option>
                    <option>300/5</option>
                    <option>400/5</option>
                    <option>500/5</option>
                    <option>600/5</option>
                    <option>750/5</option>
                    <option>800/5</option>
                    <option>1000/5</option>
                    <option>1200/5</option>
                    <option>1500/5</option>
                    <option>2000/5</option>
                    <option>2500/5</option>
                    <option>3000/5</option>
                    <option>4000/5</option>
                </select>
            </div>
            <div class=""input-group"">
                <div class=""input-gr");
            WriteLiteral("oup-prepend\">\n                    <span class=\"input-group-text\">B</span>\n                </div>\n                <input type=\"text\" class=\"form-control\" id=\"TT_B_Serial\" name=\"TT_B_Serial\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2837, "\"", 2874, 1);
#line 55 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 2845, Model.InstallAct.TT_B_Serial, 2845, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2875, 146, true);
            WriteLiteral(" form=\"installActForm\" onchange=\"Update_InstallAct(this)\">\n                <input type=\"text\" class=\"form-control\" id=\"Seal_TT_B\" name=\"Seal_TT_B\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3021, "\"", 3056, 1);
#line 56 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 3029, Model.InstallAct.Seal_TT_B, 3029, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3057, 131, true);
            WriteLiteral(" form=\"installActForm\" onchange=\"Update_InstallAct(this)\">\n                <input type=\"text\" class=\"form-control KoefficientInput\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3188, "\"", 3228, 1);
#line 57 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 3196, Model.InstallAct.TT_Koefficient, 3196, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3229, 294, true);
            WriteLiteral(@" readonly />
            </div>
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">C</span>
                </div>
                <input type=""text"" class=""form-control"" id=""TT_C_Serial"" name=""TT_C_Serial""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3523, "\"", 3560, 1);
#line 63 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 3531, Model.InstallAct.TT_C_Serial, 3531, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3561, 146, true);
            WriteLiteral(" form=\"installActForm\" onchange=\"Update_InstallAct(this)\">\n                <input type=\"text\" class=\"form-control\" id=\"Seal_TT_C\" name=\"Seal_TT_C\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3707, "\"", 3742, 1);
#line 64 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 3715, Model.InstallAct.Seal_TT_C, 3715, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3743, 131, true);
            WriteLiteral(" form=\"installActForm\" onchange=\"Update_InstallAct(this)\">\n                <input type=\"text\" class=\"form-control KoefficientInput\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3874, "\"", 3914, 1);
#line 65 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_TTPanelPartial.cshtml"
WriteAttributeValue("", 3882, Model.InstallAct.TT_Koefficient, 3882, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3915, 62, true);
            WriteLiteral(" readonly>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591