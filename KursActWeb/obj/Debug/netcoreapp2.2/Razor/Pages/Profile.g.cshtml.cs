#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ddc760e732de6fd32a5f584a599dabea15babc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Profile.cshtml", typeof(AspNetCore.Pages_Profile), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddc760e732de6fd32a5f584a599dabea15babc6", @"/Pages/Profile.cshtml")]
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Users/UsersList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/EmailPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/PaymentReports"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Letters"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/EnergyDataImport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/ConsumerDataImport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/ReplaceDataImport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/ImportAscueSerials"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
  
    ViewData["Title"] = "Личный кабинет";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 203, true);
            WriteLiteral("<div class=\"shadow p-3 mb-1 rounded\" style=\"background-color:#1c2324\"><h1 style=\"color:white; margin:0\"><i class=\"fas fa-user\"></i> Личный кабинет</h1></div>\r\n<div class=\"shadow-sm p-3 bg-white rounded\">");
            EndContext();
            BeginContext(346, 10, false);
#line 8 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(356, 47, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"d-flex flex-wrap pt-3\">\r\n");
            EndContext();
#line 12 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
     if (User.IsInRole("administrator"))
    {

#line default
#line hidden
            BeginContext(475, 139, true);
            WriteLiteral("        <!-- Пользователи -->\r\n        <div id=\"usersCard\" class=\"card shadow m-4\" style=\"width: 18rem; border-radius: 7px;\">\r\n            ");
            EndContext();
            BeginContext(614, 278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc67084", async() => {
                BeginContext(651, 237, true);
                WriteLiteral("\r\n                <div class=\"p-5 text-center shadow zoom\" style=\"background-color: #288dd4; border-radius: 7px;\">\r\n                    <i class=\"fas fa-users-cog fa-5x\" style=\"color:whitesmoke\"></i>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(892, 389, true);
            WriteLiteral(@"

            <div class=""card-body"">
                <h5 class=""card-title text-center"">Пользователи</h5>
                <p class=""card-text"">Добавление, редактирование и удаление пользователей</p>
            </div>
        </div>
        <!-- Управление рассылками -->
        <div id=""emailCard"" class=""card shadow m-4"" style=""width: 18rem; border-radius: 7px;"">
            ");
            EndContext();
            BeginContext(1281, 272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc69107", async() => {
                BeginContext(1312, 237, true);
                WriteLiteral("\r\n                <div class=\"p-5 text-center shadow zoom\" style=\"background-color: #e4a600; border-radius: 7px;\">\r\n                    <i class=\"fas fa-mail-bulk fa-5x\" style=\"color:whitesmoke\"></i>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1553, 229, true);
            WriteLiteral("\r\n\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-center\">Email рассылки</h5>\r\n                <p class=\"card-text\">Управление автоматическими рассылками</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 40 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
    }
    

#line default
#line hidden
            BeginContext(1816, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 42 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
     if (User.IsInRole("engineer") || User.IsInRole("curator") || User.IsInRole("administrator"))
    {

#line default
#line hidden
            BeginContext(1922, 137, true);
            WriteLiteral("        <!-- Отчетность -->\r\n        <div id=\"emailCard\" class=\"card shadow m-4\" style=\"width: 18rem; border-radius: 7px;\">\r\n            ");
            EndContext();
            BeginContext(2059, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc611651", async() => {
                BeginContext(2095, 241, true);
                WriteLiteral("\r\n                <div class=\"p-5 text-center shadow zoom\" style=\"background-color: #28a745; border-radius: 7px;\">\r\n                    <i class=\"fas fa-file-contract fa-5x\" style=\"color:whitesmoke\"></i>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2340, 240, true);
            WriteLiteral("\r\n\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-center\">Отчетность</h5>\r\n                <p class=\"card-text\">Управление отчетностью, документы на закрытие и т.д.</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 57 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
    }

    

#line default
#line hidden
            BeginContext(2615, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 60 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
     if (User.IsInRole("operator") || User.IsInRole("administrator"))
    {

#line default
#line hidden
            BeginContext(2693, 140, true);
            WriteLiteral("        <!-- Реестры писем -->\r\n        <div id=\"emailCard\" class=\"card shadow m-4\" style=\"width: 18rem; border-radius: 7px;\">\r\n            ");
            EndContext();
            BeginContext(2833, 269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc614188", async() => {
                BeginContext(2862, 236, true);
                WriteLiteral("\r\n                <div class=\"p-5 text-center shadow zoom\" style=\"background-color: #e16123; border-radius: 7px;\">\r\n                    <i class=\"far fa-envelope fa-5x\" style=\"color:whitesmoke\"></i>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3102, 262, true);
            WriteLiteral(@"

            <div class=""card-body"">
                <h5 class=""card-title text-center"">Реестры писем</h5>
                <p class=""card-text"">Список реестров писем, просмотр, печать, взаимодействие с Почтой России</p>
            </div>
        </div>
");
            EndContext();
            BeginContext(3366, 154, true);
            WriteLiteral("        <!-- Импорт показаний -->\r\n        <div id=\"energyDataImportCard\" class=\"card shadow m-4\" style=\"width: 18rem; border-radius: 7px;\">\r\n            ");
            EndContext();
            BeginContext(3520, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc616346", async() => {
                BeginContext(3558, 244, true);
                WriteLiteral("\r\n                <div class=\"p-5 text-center shadow zoom\" style=\"background-color: #393939; border-radius: 7px;\">\r\n                    <i class=\"fas fa-cloud-upload-alt fa-5x\" style=\"color:whitesmoke\"></i>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3806, 252, true);
            WriteLiteral("\r\n\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-center\">Импорт показаний</h5>\r\n                <p class=\"card-text\">Загрузка Excel файлов для импорта показаний в Акты допуска</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(4060, 159, true);
            WriteLiteral("        <!-- Импорт потребителей -->\r\n        <div id=\"consumerDataImportCard\" class=\"card shadow m-4\" style=\"width: 18rem; border-radius: 7px;\">\r\n            ");
            EndContext();
            BeginContext(4219, 288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc618520", async() => {
                BeginContext(4259, 244, true);
                WriteLiteral("\r\n                <div class=\"p-5 text-center shadow zoom\" style=\"background-color: #17a2b8; border-radius: 7px;\">\r\n                    <i class=\"fas fa-cloud-upload-alt fa-5x\" style=\"color:whitesmoke\"></i>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4507, 241, true);
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-center\">Импорт потребителей</h5>\r\n                <p class=\"card-text\">Загрузка Excel файлов для импорта потребителей</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(4750, 165, true);
            WriteLiteral("        <!-- Импорт данных по замене ПУ -->\r\n        <div id=\"replaceDataImportCard\" class=\"card shadow m-4\" style=\"width: 18rem; border-radius: 7px;\">\r\n            ");
            EndContext();
            BeginContext(4915, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc620687", async() => {
                BeginContext(4954, 244, true);
                WriteLiteral("\r\n                <div class=\"p-5 text-center shadow zoom\" style=\"background-color: #288dd4; border-radius: 7px;\">\r\n                    <i class=\"fas fa-cloud-upload-alt fa-5x\" style=\"color:whitesmoke\"></i>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5202, 255, true);
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-center\">Импорт данных по замене ПУ</h5>\r\n                <p class=\"card-text\">Загрузка Excel файлов для импорта данных по замене ПУ</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(5459, 47, true);
            WriteLiteral("        <!-- Экспорт данных по допуску ТУ -->\r\n");
            EndContext();
#line 117 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
        /*<div id="admissionDataExportCard" class="card shadow m-4" style="width: 18rem; border-radius: 7px;">
            <a class="" href="~/AdmissionDataExport">
                <div class="p-5 text-center shadow zoom" style="background-color: #ff5b5b; border-radius: 7px;">
                    <i class="fas fa-cloud-upload-alt fa-5x" style="color:whitesmoke"></i>
                </div>
            </a>
            <div class="card-body">
                <h5 class="card-title text-center">Экспорт данных по допуску ТУ</h5>
                <p class="card-text">Выгрузка Excel файла для экспорта данных по допуску ТУ</p>
            </div>
        </div>*/

    }
    

#line default
#line hidden
            BeginContext(6210, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 131 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
     if (User.IsInRole("administrator"))
    {

#line default
#line hidden
            BeginContext(6259, 154, true);
            WriteLiteral("        <!-- Импорт показаний -->\r\n        <div id=\"energyDataImportCard\" class=\"card shadow m-4\" style=\"width: 18rem; border-radius: 7px;\">\r\n            ");
            EndContext();
            BeginContext(6413, 315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddc760e732de6fd32a5f584a599dabea15babc624050", async() => {
                BeginContext(6453, 271, true);
                WriteLiteral(@"
                <div class=""p-5 text-center shadow zoom"" style=""background-color: #17a2b8; border-radius: 7px; transform: rotate(180deg);"">
                    <i class=""fas fa-cloud-upload-alt fa-5x"" style=""color:whitesmoke""></i>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6728, 256, true);
            WriteLiteral(@"

            <div class=""card-body"">
                <h5 class=""card-title text-center"">Импорт из ПО АИИС КУЭ</h5>
                <p class=""card-text"">Загрузка txt файлов для импорта флагов ""Работает в АСКУЭ""</p>
            </div>
        </div>
");
            EndContext();
#line 146 "D:\Repos\kurs-act-master\KursActWeb\Pages\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(6991, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KursActWeb.Pages.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.ProfileModel>)PageContext?.ViewData;
        public KursActWeb.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
