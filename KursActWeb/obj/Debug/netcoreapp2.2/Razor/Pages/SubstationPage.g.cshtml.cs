#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea99a68d4aed4df4bb8bd82023fe79bda70b13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_SubstationPage), @"mvc.1.0.razor-page", @"/Pages/SubstationPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SubstationPage.cshtml", typeof(AspNetCore.Pages_SubstationPage), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea99a68d4aed4df4bb8bd82023fe79bda70b13d", @"/Pages/SubstationPage.cshtml")]
    public class Pages_SubstationPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ui-1.12.1/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ui-1.12.1/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
  
    ViewData["Title"] = Model.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";
    bool u(string role)
    {
        return User.IsInRole(role);
    }

#line default
#line hidden
            BeginContext(212, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(258, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dea99a68d4aed4df4bb8bd82023fe79bda70b13d4240", async() => {
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
            BeginContext(329, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(330, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dea99a68d4aed4df4bb8bd82023fe79bda70b13d5491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(393, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(406, 281, true);
            WriteLiteral(@"<script src=""https://cdn.jsdelivr.net/npm/vue@2.6.10/dist/vue.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/lodash@4.17.11/lodash.min.js"" integrity=""sha256-7/yoZS3548fXSRXqc/xYzjsmuW3sFKzuvOCHd06Pmps="" crossorigin=""anonymous""></script>

<h1 class=""d-none d-print-inline"">");
            EndContext();
            BeginContext(688, 10, false);
#line 19 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(698, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
            BeginContext(743, 31, true);
            WriteLiteral("<div class=\"d-print-none\">\n    ");
            EndContext();
            BeginContext(775, 53, false);
#line 23 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
Write(await Html.PartialAsync("Substation/_substationHead"));

#line default
#line hidden
            EndContext();
            BeginContext(828, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
#line 27 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
 if (u("consumerDataProvider"))
{

#line default
#line hidden
            BeginContext(928, 64, true);
            WriteLiteral("    <div id=\"rpTableConsumerData\" class=\"d-print-none\">\n        ");
            EndContext();
            BeginContext(993, 62, false);
#line 30 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
   Write(await Html.PartialAsync("_PointsConsumerNameImport", Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 32 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1076, 31, true);
            WriteLiteral("    <div id=\"rpTable\">\n        ");
            EndContext();
            BeginContext(1108, 54, false);
#line 36 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
   Write(await Html.PartialAsync("_PointsSortFilter", Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 38 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
}

#line default
#line hidden
            BeginContext(1176, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1201, 317, true);
            WriteLiteral(@"<script>
    //Запрос таблицы точек учета и подстановка ее в контейнер
    function UpdateTableRegPoints() {
        window.location.reload();
    }

    //Запрос таблицы точек учета с письмами и подстановка ее в контейнер
    function UpdateTableRegPointsLetters() {
        fetch('/RegPoint/HTML_PointsLettersTable/");
            EndContext();
            BeginContext(1519, 8, false);
#line 49 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1527, 96, true);
            WriteLiteral("\').then((r) => r.text())\n            .then((html) => $(\'#rpTable\').html(html));\n    }\n</script>\n");
            EndContext();
            BeginContext(1648, 4917, true);
            WriteLiteral(@"<script>
    var lastLetterInviteDate = '';
    async function CreateLetter(idRegPoint) {
        const { value: formValues } = await Swal.fire({
            title: 'Выбери дату приглашения',
            html:
                '<input type=""text"" autocomplete=""off"" id=""datepicker"">',
            onOpen: () => {
                $(""#datepicker"").datepicker();
                $(""#datepicker"").datepicker(""option"", ""dateFormat"", ""dd-mm-yy"");
                $(""#datepicker"").val(lastLetterInviteDate);
                $(""#datepicker"").blur();
                Swal.getConfirmButton().focus();
            },
            focusConfirm: false,
            preConfirm: () => {
                return {
                    inviteDate: document.getElementById('datepicker').value
                }
            }
        })

        if (formValues && formValues.inviteDate) {
            //Запрос на создание письма
            fetch('/Letter/Add/' + idRegPoint, {
                method: 'POST',
                headers: { 'Content-T");
            WriteLiteral(@"ype': 'application/x-www-form-urlencoded' },
                body: ""id="" + encodeURIComponent(idRegPoint) + ""&inviteDate="" + encodeURIComponent(formValues.inviteDate)
            }).then((response) => {
                if (response.ok) {
                    ok('Письмо создано на ' + formValues.inviteDate);
                    lastLetterInviteDate = formValues.inviteDate;
                } else { err('Ошибка сервера' + response.statusText); }
            })//Обновление таблицы
                .then(() => { UpdateTableRegPointsLetters(); });
        }
    }
    //Меню с действиями над письмом (Удалить/Скачать)
    function LetterInfo(letterId, inviteDate) {
        Swal.fire({
            showConfirmButton: false,
            title: 'Письмо №' + letterId + ' на ' + inviteDate,
            html:
                '<a class=""btn btn-info"" style=""width:300px; margin: 3px;"" href=""/GetFile/GetExcel_Letter?id=' + letterId + '"">Скачать письмо</a>' +
                '<button id=""deleteLetter"" class=""btn btn-danger"" style");
            WriteLiteral(@"=""width:300px; margin: 3px;"">Удалить</button>',
            onBeforeOpen: () => {
                const content = Swal.getContent()
                const $ = content.querySelector.bind(content)
                const deleteLetter = $('#deleteLetter');
                deleteLetter.addEventListener('click', () => {
                    DeleteLetter(letterId); //Удалить письмо
                });
            }
        })
    }
    //Удалить письмо
    function DeleteLetter(letterId) {
        Swal.fire({
            title: 'Удалить письмо №' + letterId + '?',
            text: ""Это необратимое действие!"",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Да, удалить его!',
            cancelButtonText: 'Отмена'
        }).then((result) => {
            if (result.value) {
                fetch('/Letter/Delete', {
                    method: 'POST',
                    headers: { 'Content");
            WriteLiteral(@"-Type': 'application/x-www-form-urlencoded' },
                    body: ""letterId="" + encodeURIComponent(letterId)
                }).then((response) => {
                    if (response.ok) {
                        UpdateTableRegPointsLetters();
                        ok('Письмо удалено');
                    } else { err('Ошибка сервера' + response.statusText); }
                });
            }
        })
    }
    //Нажатие на иконку Распечатано
    function Switch_LetterPrinted(letterId) {
        SwithRequestLetter('LetterPrinted', letterId, 'Письмо распечатано', 'green');
    }

    //Переключить цвет Серый/Зеленый
    function switchColor(icon, colorNameIfTrue) {
        if (GetFlagStatus(icon)) {
            //Выключаем
            icon.css('color', 'gray');
        } else {
            //Включаем
            icon.css('color', colorNameIfTrue);
        }
    }
    //Получить текущий статус флага (от цвета иконки)
    function GetFlagStatus(icon) {
        return !(icon.css('color').localeCompare");
            WriteLiteral(@"('rgb(128, 128, 128)') === 0);
    }
    //Запрос на сервер для изменения флага
    function SwithRequestLetter(flagName, letterId, alertFlagName, colorName) {
        let icon = $('#' + flagName + '_' + letterId);
        //Статус флага
        let newStatus = !GetFlagStatus(icon);
        //Запрос
        fetch('/Letter/Update_' + flagName, {
            method: 'POST',
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            body: ""id="" + encodeURIComponent(letterId) + ""&newstatus="" + encodeURIComponent(newStatus)
        }).then((response) => {
            if (response.ok) {
                ok('Флаг ""' + alertFlagName + '"" изменен');
                switchColor(icon, colorName);
            } else { err('Ошибка сервера' + response.statusText); }
        });
    }
</script>
");
            EndContext();
            BeginContext(6596, 163, true);
            WriteLiteral("<script>\n    //Удалить подстанцию\n    function Delete() {\n        let sName = prompt(\'Для удаления введите название подстанции\');\n        if (sName.localeCompare(\'");
            EndContext();
            BeginContext(6760, 20, false);
#line 177 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                            Write(Html.Raw(Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(6780, 216, true);
            WriteLiteral("\') == 0) {\n            fetch(\'/Substation/Delete\', {\n                method: \'POST\',\n                headers: { \'Content-Type\': \'application/x-www-form-urlencoded\' },\n                body: \"id=\" + encodeURIComponent(");
            EndContext();
            BeginContext(6997, 8, false);
#line 181 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7005, 384, true);
            WriteLiteral(@")
            })
            .then(resp => resp.text())
            .then(txt => alert(txt));
        }
        else
            alert('Неверное имя подстанции. Отмена удаления.');
    }

     //Добавить комментарий
    function AddComment() {
        var xhr = new XMLHttpRequest();
        var text = $('#commentText').val();
        var body = ""substationId="" + encodeURIComponent(");
            EndContext();
            BeginContext(7390, 8, false);
#line 194 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7398, 647, true);
            WriteLiteral(@") + ""&text="" + encodeURIComponent(text);
        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200) {
                $('#comments').html(xhr.response);
                $('#commentText').val('');
            }
        }
        xhr.open(""POST"", '/Comments/AddSubstationComment', true);
        xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
        xhr.send(body);
    }

    //Удалить комментарий
    function DeleteComment(id) {
        var xhr = new XMLHttpRequest();
        var text = $('#commentText').val();
        var body = ""substationId="" + encodeURIComponent(");
            EndContext();
            BeginContext(8046, 8, false);
#line 210 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(8054, 548, true);
            WriteLiteral(@") + ""&commentId="" + encodeURIComponent(id);
        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200) {
                $('#comments').html(xhr.response);
                $('#commentText').val('');
            }
        }
        xhr.open(""POST"", '/Comments/DeleteSubstationComment', true);
        xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
        xhr.send(body);
    }

    //Переименовать подстанцию
    async function RenemaeSubstation() {
        var sbType = '");
            EndContext();
            BeginContext(8603, 35, false);
#line 224 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                 Write(Html.Raw(Model.Name.Substring(0,2)));

#line default
#line hidden
            EndContext();
            BeginContext(8638, 27, true);
            WriteLiteral("\';\n        var sbNumber = \'");
            EndContext();
            BeginContext(8666, 56, false);
#line 225 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                   Write(Html.Raw(Model.Name.Substring(3, Model.Name.Length - 3)));

#line default
#line hidden
            EndContext();
            BeginContext(8722, 1465, true);
            WriteLiteral(@"';

        const { value: newSbName } = await Swal.fire({
            title: 'Новый номер',
            html:
               // '<div class=""row""><select id=""sbType"" style=""width:15%;"" class=""form-control""><option value=""ТП"">ТП</option> <option value=""РП"">РП</option></select> <input type=""text"" style=""width:75%;"" class=""form-control"" id=""sbNumber"" /></div>' ,

                ""<div class='input-group mb-3'><select class='form-control'style='width:15 %;' id='sbType'>""
                 + ""<option id='tp' value='ТП'>ТП</option><option id='rp' value='РП'>РП</option></select>""
                 + ""<div class='input-group-prepend' id='substationSeparator'>""
                 + ""<div class=input-group-prepend'><input type='text' class='form-control'  id='sbNumber' name='SubstationNumber'/></div></div>"",

            onOpen: () => {
                $('#sbType').val(sbType);
                $('#sbNumber').val(sbNumber);
                Swal.getConfirmButton().focus();
            },
            focusConfirm: false,
   ");
            WriteLiteral(@"         preConfirm: () => {
                return $('#sbType').val() + ' ' + $('#sbNumber').val()
            }
        })

        if (newSbName) {
            //Запрос на переименование
            fetch('/Substation/Rename', {
                method: 'POST',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                body: ""newName="" + encodeURIComponent(newSbName) + ""&id="" + encodeURIComponent(");
            EndContext();
            BeginContext(10188, 8, false);
#line 253 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                                                                                          Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10196, 40, true);
            WriteLiteral(") + \"&contractId=\" + encodeURIComponent(");
            EndContext();
            BeginContext(10237, 16, false);
#line 253 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                                                                                                                                           Write(Model.ContractId);

#line default
#line hidden
            EndContext();
            BeginContext(10253, 793, true);
            WriteLiteral(@")
            }).then(r => {
                if (r.ok)
                    return r.text()
                else err(""Ошибка сервера"")
            }).then((responseText) => {

                if (responseText.startsWith('Ошибка'))
                    err(responseText);
                else {
                    $('#sbName1').html(newSbName);
                    $('#sbName2').html(newSbName);
                    ok(responseText);
                }
            })
        }
    }

    async function AddPhoneNumber() {
         const { value: newPhoneNumber } = await Swal.fire({
            title: 'Новый номер',
            html:

                ""<input type='text' class='form-control'  id='Number' name='Number'/></div>"",

             onOpen: () => {
                 $('#Number').val('");
            EndContext();
            BeginContext(11047, 27, false);
#line 279 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                              Write(Html.Raw(Model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(11074, 533, true);
            WriteLiteral(@"');
                Swal.getConfirmButton().focus();
            },
            focusConfirm: false,
            preConfirm: () => {
                return $('#Number').val()
            }
        })

        if (newPhoneNumber) {
            //Запрос на переименование
            fetch('/Substation/AddPhoneNumber', {
                method: 'POST',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                body: ""number="" + encodeURIComponent(newPhoneNumber) + ""&id="" + encodeURIComponent(");
            EndContext();
            BeginContext(11608, 8, false);
#line 293 "D:\Repos\kurs-act-master\KursActWeb\Pages\SubstationPage.cshtml"
                                                                                              Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(11616, 391, true);
            WriteLiteral(@")
            }).then(r => {
                if (r.ok)
                    return r.text()
                else err(""Ошибка сервера"")
            }).then((responseText) => {

                if (responseText.startsWith('Ошибка'))
                    err(responseText);
                else {
                      ok(responseText);
                }
            })
        }
    }
</script>
");
            EndContext();
            BeginContext(12022, 122, true);
            WriteLiteral("<script>\n    //Всплывающие подсказки\n    $(function () {\n        $(\'[data-toggle=\"tooltip\"]\').tooltip()\n    })\n</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KursActWeb.Pages.SubstationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.SubstationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.SubstationModel>)PageContext?.ViewData;
        public KursActWeb.Pages.SubstationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591