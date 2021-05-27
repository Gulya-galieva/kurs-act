#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0531b59dbe4cb744237962511bffecf2b69c1a44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegPoint_Shared__UAddressPanelPartial), @"mvc.1.0.view", @"/Views/RegPoint/Shared/_UAddressPanelPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegPoint/Shared/_UAddressPanelPartial.cshtml", typeof(AspNetCore.Views_RegPoint_Shared__UAddressPanelPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0531b59dbe4cb744237962511bffecf2b69c1a44", @"/Views/RegPoint/Shared/_UAddressPanelPartial.cshtml")]
    public class Views_RegPoint_Shared__UAddressPanelPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 951, true);
            WriteLiteral(@"<div class=""col-lg-6 d-flex"">
    <div class=""panel align-self-stretch"">
        <div class=""panel-heading d-flex"">
            <h3 class=""panel-title"">Потребитель</h3>
            <div class=""ml-auto"">
                <span class=""text-green"" id=""SendToBasheskIndicator""><i class=""far fa-check-circle""></i> Запрос отправлен</span>
                <a href=""javascript:void(0)"" title=""Запросить данные потребителя в ЭСКБ"" onclick=""SendToBashEskConfirmation()"" class=""panel-title-link align-self-stretch d-inline-block"" id=""BtnSendToBashesk"">Запросить данные</a>
            </div>
        </div>

        <div class=""panel-content no-gutter-top"">
            <div class=""row no-gutters"">
                <div class=""col-9 pr-2"">
                    <div class=""form-group float-label"">
                        <label for=""Name"" class=""float-label--label"">ФИО</label>
                        <input type=""text"" class=""form-control"" id=""Name"" name=""Name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 951, "\"", 979, 1);
#line 16 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 959, Model.Consumer.Name, 959, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(980, 443, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""form-group float-label"">
                        <label for=""ContractNumber"" class=""float-label--label"">Номер договора</label>
                        <input type=""text"" class=""form-control"" id=""ContractNumber"" name=""ContractNumber""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1423, "\"", 1461, 1);
#line 23 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 1431, Model.Consumer.ContractNumber, 1431, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1462, 475, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>
                </div>
            </div>

            <div class=""row no-gutters"">
                <div class=""col-2"">
                    <div class=""form-group float-label"">
                        <label for=""U_Index"" class=""float-label--label"">Индекс</label>
                        <input type=""text"" class=""form-control"" id=""U_Index"" name=""U_Index""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1937, "\"", 1968, 1);
#line 33 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 1945, Model.Consumer.U_Index, 1945, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1969, 429, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>
                </div>
                <div class=""col-5 pl-2"">
                    <div class=""form-group float-label"">
                        <label for=""U_Local"" class=""float-label--label"">Населенный пункт</label>
                        <input type=""text"" class=""form-control"" id=""U_Local"" name=""U_Local""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2398, "\"", 2429, 1);
#line 40 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 2406, Model.Consumer.U_Local, 2406, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2430, 446, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>
                </div>
                <div class=""col-5 pl-2"">
                    <div class=""form-group float-label"">
                        <label for=""U_Local_Secondary"" class=""float-label--label"">СНТ</label>
                        <input type=""text"" class=""form-control"" id=""U_Local_Secondary"" name=""U_Local_Secondary""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2876, "\"", 2917, 1);
#line 47 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 2884, Model.Consumer.U_Local_Secondary, 2884, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2918, 478, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>

                </div>
            </div>

            <div class=""row no-gutters"">
                <div class=""col-4"">
                    <div class=""form-group float-label"">
                        <label for=""U_Street"" class=""float-label--label"">Улица</label>
                        <input type=""text"" class=""form-control"" id=""U_Street"" name=""U_Street""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3396, "\"", 3428, 1);
#line 58 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 3404, Model.Consumer.U_Street, 3404, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3429, 416, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>
                </div>
                <div class=""col-4 pl-2"">
                    <div class=""form-group float-label"">
                        <label for=""U_House"" class=""float-label--label"">Дом</label>
                        <input type=""text"" class=""form-control"" id=""U_House"" name=""U_House""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3845, "\"", 3876, 1);
#line 65 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 3853, Model.Consumer.U_House, 3853, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3877, 419, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>
                </div>
                <div class=""col-2 pl-2"">
                    <div class=""form-group float-label"">
                        <label for=""U_Build"" class=""float-label--label"">Корпус</label>
                        <input type=""text"" class=""form-control"" id=""U_Build"" name=""U_Build""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4296, "\"", 4327, 1);
#line 72 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 4304, Model.Consumer.U_Build, 4304, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4328, 418, true);
            WriteLiteral(@" form=""consumerForm"" onchange=""Update_Consumer(this)"">
                        <span></span>
                    </div>
                </div>
                <div class=""col-2 pl-2"">
                    <div class=""form-group float-label"">
                        <label for=""U_Flat"" class=""float-label--label"">Квартира</label>
                        <input type=""text"" class=""form-control"" id=""U_Flat"" name=""U_Flat""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4746, "\"", 4776, 1);
#line 79 "D:\Repos\kurs-act-master\KursActWeb\Views\RegPoint\Shared\_UAddressPanelPartial.cshtml"
WriteAttributeValue("", 4754, Model.Consumer.U_Flat, 4754, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4777, 194, true);
            WriteLiteral(" form=\"consumerForm\" onchange=\"Update_Consumer(this)\">\n                        <span></span>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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