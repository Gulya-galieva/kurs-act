#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\ReportImport\Reports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca9ce00a17273c4db7edbaddb00b6d76d5ee046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReportImport_Reports), @"mvc.1.0.view", @"/Views/ReportImport/Reports.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReportImport/Reports.cshtml", typeof(AspNetCore.Views_ReportImport_Reports))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca9ce00a17273c4db7edbaddb00b6d76d5ee046", @"/Views/ReportImport/Reports.cshtml")]
    public class Views_ReportImport_Reports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KursActWeb.ViewModels.RegPointRowViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Repos\kurs-act-master\KursActWeb\Views\ReportImport\Reports.cshtml"
  
    ViewData["Title"] = ViewBag.SubstationName;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(162, 357, true);
            WriteLiteral(@"    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.min.js""
            integrity=""sha256-VazP97ZCwtekAsvgPBSUwPFKdrwD3unUfSGVYrahUqU=""
            crossorigin=""anonymous"">
    </script>
    <link href=""https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"" rel=""stylesheet"">
    

<h1>Импорт отчетов по подрядчикам</h1>

<div id=""workers"">
 ");
            EndContext();
            BeginContext(520, 96, false);
#line 16 "D:\Repos\kurs-act-master\KursActWeb\Views\ReportImport\Reports.cshtml"
Write(await  Html.PartialAsync("~/Views/ReportImport/_workers.cshtml", ViewBag.Mounters as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(616, 53, true);
            WriteLiteral("\n</div>\n\n    <div class=\"mt-2\" id=\"reports\">\n        ");
            EndContext();
            BeginContext(670, 63, false);
#line 20 "D:\Repos\kurs-act-master\KursActWeb\Views\ReportImport\Reports.cshtml"
   Write(await Html.PartialAsync("~/Views/ReportImport/_reports.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(733, 13104, true);
            WriteLiteral(@"
    </div>
    <!-- Модальное оно просмотра отчета перед импортом -->
    <div class=""modal fade"" id=""reportViewModal"" role=""dialog"">
        <div class=""modal-dialog modal-xl modal-dialog-scrollable"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalScrollableTitle"">Просмотр отчета</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" id=""reportViewModalBody"">
                    ...
                </div>
                <div class=""modal-footer"">
                    <input type=""hidden"" id=""reportId"" />
                    <input type=""hidden"" id=""reportType"" />
                    <button type=""button"" class=""btn btn-primary"" onclick=""Import()"">Импорт</button>
                    <button type=""b");
            WriteLiteral(@"utton"" class=""btn btn-secondary"" data-dismiss=""modal"">Отмена</button>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""addRemark"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Замечания по отчету</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""comment"">Замечания:</label>
                        <textarea class=""form-control"" rows=""3"" id=""text""></textarea>
                    </div>
             ");
            WriteLiteral(@"       <div id=""Remarks"">

                    </div>
                </div>
                <div class=""modal-footer"">
                    <input type=""hidden"" id=""reportType"" />
                    <input type=""hidden"" id=""reportId"" />
                    <button type=""submit"" class=""btn btn-primary"" id=""remarkAddBtn"" onclick=""AddRemark()"">Отправить</button>
                </div>

            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""addComment"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Комментарии к отчету</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
    ");
            WriteLiteral(@"            </div>

                <div class=""modal-body"">
                    <h3>Комментарии</h3>
                    <div>
                        <div class=""form-row mb-3"">
                            <textarea class=""form-control mb-2"" rows=""2"" id=""commentText""></textarea>
                            <button class=""btn btn-primary ml-auto"" onclick=""AddComment()"">Отправить</button>
                        </div>
                        <div id=""commentsTable"">
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        //function USPD() { //Обновление ТУ УСПД
        //    var xhr = new XMLHttpRequest();
        //    xhr.onreadystatechange = function () {
        //        if (xhr.readyState === 4 && xhr.status === 200) {
        //            alert(xhr.responseText);
        //        }
        //    }
        //    xhr.open(""POST"", '/ReportImport/USPD', true);
        //    xhr.setReq");
            WriteLiteral(@"uestHeader('Content-Type', 'application/x-www-form-urlencoded');
        //    xhr.send();
        //}

        //Запрос отчетов по id подрядчика
        function GetWorkerReports() {
            var xhr = new XMLHttpRequest();
            var body = ""workerId="" + encodeURIComponent($('#WorkerId').val());
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    $('#reports').html(xhr.response);
                }
            }
            xhr.open(""POST"", '/ReportImport/GetMounterReports', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.send(body);
        }

        //Запрос точек учета по отчету
        function GetReportRegPoints(reportId, reportType) {
            var xhr = new XMLHttpRequest();
            var body = ""reportId="" + encodeURIComponent(reportId) + ""&reportType="" + encodeURIComponent(reportType);
            xhr.onreadystatechange = function () {
      ");
            WriteLiteral(@"          if (xhr.readyState === 4 && xhr.status === 200) {
                    $('#reportId').val(reportId);
                    $('#reportType').val(reportType);
                    $('#reportViewModal').modal('toggle');
                    $('#reportViewModalBody').html(xhr.response);
                }
            }
            xhr.open(""POST"", '/ReportImport/GetReportRegPoints', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.send(body);
        }

        function Remark(reportId, reportType) {
            $('#reportId').val(reportId);
            $('#reportType').val(reportType);
            GetReportRemarks(reportId, reportType); //Получить замечания к отчету
            $('#addRemark').modal('toggle');
        }
        //Добавить замечания к отчету
        function AddRemark() {
           var eType = """";
            if ($('#reportType').val() === ""ВЛ"") {
                eType = ""Al"";
            }
            if ($('#reportType').val() ==");
            WriteLiteral(@"= ""ТП/РП"") {
                eType = ""SB"";
            }
            if ($('#reportType').val() === ""УСПД"") {
                eType = ""USPD"";
            }

            var reportAlert = $('#' + eType + $('#reportId').val());

           if ($('#text').val() === """") {
                alert(""Текст замечания не может быть пустым!"");
            }
            else {
                $('#addRemark').modal('toggle');
                var xhr = new XMLHttpRequest();
                var body = ""reportId="" + encodeURIComponent($('#reportId').val()) + ""&reportType="" + encodeURIComponent( $('#reportType').val()) + ""&text="" + encodeURIComponent($('#text').val());
                xhr.onreadystatechange = function () {
                    if (xhr.readyState === 4 && xhr.status === 200) {
                        alert(xhr.responseText);
                        reportAlert.fadeOut();
                        var selectedWorker = $(""#WorkerId :selected"").val(); //Сохранить id выбранного работника
                        GetRepo");
            WriteLiteral(@"rtsCount();
                        GetMounters(selectedWorker); //Обновить список работников
                    }
                }
                xhr.open(""POST"", '/ReportImport/AddRemarkToReport', true);
                xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
                xhr.send(body);
            }
    }
        //Получить все замечания к отчету
        function GetReportRemarks(reportId, reportType) {
            var xhr = new XMLHttpRequest();
            var body = ""reportId="" + encodeURIComponent(reportId) + ""&reportType="" + encodeURIComponent(reportType);
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    $('#Remarks').html(xhr.response);
                }
            }
            xhr.open(""POST"", '/ReportImport/GetReportRemarks', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.send(body);
        }

        //Ко");
            WriteLiteral(@"мментарии
        function Comment(reportId, reportType) {
            $('#reportId').val(reportId);
            $('#reportType').val(reportType);
            GetReportComments(reportId, reportType); //Получить замечания к отчету
            $('#addComment').modal('toggle');

    }

    function AddComment() {
        if ($('#commentText').val() === """") {
            alert(""Текст комментрия не может быть пустым!"");
        }
        else {
            //$('#addComment').modal('toggle');
            var xhr = new XMLHttpRequest();
            var body = ""reportId="" + encodeURIComponent($('#reportId').val()) + ""&reportType="" + encodeURIComponent($('#reportType').val()) + ""&text="" + encodeURIComponent($('#commentText').val());
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    $('#commentsTable').html(xhr.response);
                    $('#commentText').val('');
                }
            }
            xhr.open(""POST"", '/Rep");
            WriteLiteral(@"ortImport/AddCommentToReport', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.send(body);
        }
    }

    function GetReportComments(reportId, reportType) {
        var xhr = new XMLHttpRequest();
            var body = ""reportId="" + encodeURIComponent(reportId) + ""&reportType="" + encodeURIComponent(reportType);
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    $('#commentsTable').html(xhr.response);
                }
            }
            xhr.open(""POST"", '/ReportImport/GetReportComments', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.send(body);
    }
            
       

        //Импорт отчета
        function Import() {
            var xhr = new XMLHttpRequest();
            var type = $('#reportType').val();
            var id = $('#reportId').val();

            var eType = """";
    ");
            WriteLiteral(@"        if (type === ""ВЛ"") {
                eType = ""Al"";
            }
            if (type === ""ТП/РП"") {
                eType = ""SB"";
            }
            if (type === ""УСПД"") {
                eType = ""USPD"";
            }

            var reportAlert = $('#' + eType + id);
            var body = ""reportId="" + encodeURIComponent(id) + ""&reportType="" + encodeURIComponent(type);
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    $('#reportViewModal').modal('toggle');
                    reportAlert.fadeOut();
                    if (xhr.responseText.startsWith(""Отчет"")) {
                        swal.fire({
                            type: 'success',
                            title: ""Good job!"",
                            text: xhr.responseText + ""!"",
                            showConfirmButton: false,
                            timer: 1500
                        });
                        var selectedWorke");
            WriteLiteral(@"r = $(""#WorkerId :selected"").val(); //Сохранить id выбранного работника
                        GetReportsCount();
                        GetMounters(selectedWorker); //Обновить список работников
                    }
                    else
                        swal.fire({
                            title: ""Что-то пошло не так!"",
                            text: xhr.responseText + ""!"",
                            type: ""warning"",
                            button: ""Aww noooo!"",
                        });
                }
            }
            xhr.open(""POST"", '/ReportImport/ReportImport', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.send(body);
        }

        //Ко-во отчетов в боковом меню
        function GetReportsCount() {
            var xmlHttp = new XMLHttpRequest();
            xmlHttp.onreadystatechange = function () {
                if (xmlHttp.readyState == 4 && xmlHttp.status == 200)
                    $('#reportF");
            WriteLiteral(@"orImportCount').html(xmlHttp.responseText);
            }
            xmlHttp.open(""GET"", ""/ReportImport/GetReportCount"", true);
            xmlHttp.send(null);
        }

        //Обнновление списка работников
        function GetMounters(workerId) {
            var xmlHttp = new XMLHttpRequest();
            xmlHttp.onreadystatechange = function () {
                if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
                    $('#workers').html(xmlHttp.responseText);
                    $(""#WorkerId [value='"" + workerId + ""']"").attr(""selected"", ""selected""); //Сделать активным id сохраненого работника
                }
                    
            }
            xmlHttp.open(""GET"", ""/ReportImport/GetWorkers"", true);
            xmlHttp.send(null);
            }

        
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KursActWeb.ViewModels.RegPointRowViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
