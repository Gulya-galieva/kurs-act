#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f4028e7c5b661edef9f9cfb4b60c26ff0b4a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_PaymentReportPage), @"mvc.1.0.razor-page", @"/Pages/PaymentReportPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/PaymentReportPage.cshtml", typeof(AspNetCore.Pages_PaymentReportPage), @"{id}")]
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
#line 2 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f4028e7c5b661edef9f9cfb4b60c26ff0b4a33", @"/Pages/PaymentReportPage.cshtml")]
    public class Pages_PaymentReportPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
  
    ViewData["Title"] = "PaymentReport";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(169, 226, true);
            WriteLiteral("<script src=\"https://cdn.jsdelivr.net/npm/vue@2.6.10/dist/vue.js\"></script>\n\n<div class=\"shadow p-3 mb-1 rounded\" style=\"background-color:#1c2324\"><h1 style=\"color:white; margin:0\"> <i class=\"fas fa-file-contract\"></i> Отчет №");
            EndContext();
            BeginContext(396, 22, false);
#line 10 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                                                                                                Write(Model.PaymentReport.Id);

#line default
#line hidden
            EndContext();
            BeginContext(418, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(422, 16, false);
#line 10 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                                                                                                                          Write(Model.WorkerName);

#line default
#line hidden
            EndContext();
            BeginContext(438, 122, true);
            WriteLiteral(" </h1></div>\n\n<style>\n    .check-box-border-black::before {\n        border-color: #6d6d6d;\n    }\n</style>\n\n<div id=\"app\">\n");
            EndContext();
            BeginContext(605, 643, true);
            WriteLiteral(@"    <div v-if=""!IsClosed"" class=""d-flex justify-content-end"">
        <div class=""panel p-2 pl-3 mb-1 ml-auto"" style=""color:black; width:25%; background:#ffc107;"">
            <input type=""checkbox"" id=""checkbox"" class=""form-check-input"" v-model=""OnlyLinkOk"" />
            <label class=""form-check-label check-box-border-black"" for=""checkbox""> Только проверенные</label>
        </div>
    </div>
    <div v-if=""!IsClosed"" class=""panel p-2 pl-3 mb-1 shadow"">
        <h4 data-toggle=""collapse"" data-target=""#collapseCurrent"" style=""cursor:pointer; color:black; margin-bottom:0px;""><i class=""fas fa-wallet""></i> Точки учета за текущий период [");
            EndContext();
            BeginContext(1249, 12, false);
#line 27 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                                                                                                                                  Write(Model.Period);

#line default
#line hidden
            EndContext();
            BeginContext(1261, 1856, true);
            WriteLiteral(@"] - Всего {{ AvailablePointsCount }}</h4>
        <div class=""collapse"" id=""collapseCurrent"">
            <table class=""table table-hover border mt-2"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Тип</th>
                        <th>Количество</th>
                        <th>Стоимость (руб.)</th>
                        <th>Работа</th>
                        <th>Включить в отчёт</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for=""pgr in DataCurrent"" class=""p-4"">
                        <td>{{ pgr.TypeDevice }}</td>
                        <th>{{ pgr.Count }}</th>
                        <td><input class=""form-control"" v-model=""pgr.CostRUB"" type=""number"" /></td>
                        <td>
                            <select v-model=""pgr.WorkType"" class=""form-control"">
                                <option disabled value=""0"">Выберите тип работы</option>
         ");
            WriteLiteral(@"                       <option v-for=""workType in WorkTypes"" v-bind:value=""workType.value"">{{workType.name}}</option>
                            </select>
                        </td>
                        <td><input class=""form-control"" v-model=""pgr.ToAddCount"" v-on:change=""toAddCountChange(pgr)"" placeholder=""Количество...""></td>
                        <td><i class=""far fa-plus-square fa-2x"" style=""color:cornflowerblue; cursor:pointer;"" v-on:click=""attachPoints(pgr)""></i></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div v-if=""!IsClosed"" class=""panel p-2 pl-3 mb-4 shadow"">
        <h4 data-toggle=""collapse"" data-target=""#collapseOld"" style=""cursor:pointer; color:black; margin-bottom:0px;""><i class=""fas fa-history""></i> Точки учета за прошлые периоды [до ");
            EndContext();
            BeginContext(3118, 60, false);
#line 59 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                                                                                                                                   Write(Model.PaymentReport.DatePeriodStart.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3178, 1783, true);
            WriteLiteral(@"] - Всего {{ AvailablePointGroupsOldCount }}</h4>
        <div class=""collapse"" id=""collapseOld"">
            <table class=""table table-hover border mt-2"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Тип</th>
                        <th>Количество</th>
                        <th>Стоимость (руб.)</th>
                        <th>Работа</th>
                        <th>Включить в отчёт</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for=""pgr in DataOld"" class=""p-4"">
                        <td>{{ pgr.TypeDevice }}</td>
                        <th>{{ pgr.Count }}</th>
                        <td><input class=""form-control"" v-model=""pgr.CostRUB"" type=""number"" /></td>
                        <td>
                            <select v-model=""pgr.WorkType"" class=""form-control"">
                                <option disabled value=""0"">Выберите тип работы</option>
         ");
            WriteLiteral(@"                       <option v-for=""workType in WorkTypes"" v-bind:value=""workType.value"">{{workType.name}}</option>
                            </select>
                        </td>
                        <td><input class=""form-control"" v-model=""pgr.ToAddCount"" v-on:change=""toAddCountChange(pgr)"" placeholder=""Количество...""></td>
                        <td><i class=""far fa-plus-square fa-2x"" style=""color:cornflowerblue; cursor:pointer;"" v-on:click=""attachPoints(pgr)""></i></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class=""panel p-2 pl-3 shadow"">
        <div class=""d-flex justify-content-between pr-3"">
            <h4 style=""color:black""><i class=""far fa-file-alt""></i> Отчет №");
            EndContext();
            BeginContext(4962, 22, false);
#line 92 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                      Write(Model.PaymentReport.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4984, 2, true);
            WriteLiteral(" [");
            EndContext();
            BeginContext(4987, 12, false);
#line 92 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                                               Write(Model.Period);

#line default
#line hidden
            EndContext();
            BeginContext(4999, 99, true);
            WriteLiteral("] - Всего {{AddedPointsCount}}</h4>\n            <div class=\"d-flex flex-column\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5098, "\"", 5160, 2);
            WriteAttributeValue("", 5105, "/GetFile/GetExcel_PaymentReport/", 5105, 32, true);
#line 94 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
WriteAttributeValue("", 5137, Model.PaymentReport.Id, 5137, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5161, 1584, true);
            WriteLiteral(@" data-toggle=""tooltip"" data-placement=""top"" title=""Скачать отчет Excel"" class="" text-center""><i class=""fas fa-file-excel fa-2x text-success""></i></a>
                <p class="" text-center"">Скачать</p>
            </div>
        </div>
        <div v-for=""pgr in AddedPointsGroups"">
            <h4><strong>{{ pgr.TypeDevice }}: </strong> <span> {{ pgr.Count }}</span></h4>
            <table class=""table"">
                <tr v-for=""p in pgr.Points"">
                    <td>{{ p.RegionName }}</td>
                    <td>{{ p.SubstationName }}</td>
                    <td>{{ WorkTypesNames[p.WorkType].name }}</td>
                    <td>{{ p.OAddress }}</td>
                    <td>{{ p.Serial }}</td>
                    <td v-if=""p.IsLinkOk"">
                        <i class=""fas fa-check-circle text-success""></i>
                    </td>
                    <td v-else></td>
                    <td>{{ p.CostRUB }} руб.</td>
                    <td><i v-if=""!IsClosed"" class=""far fa-trash-alt text-danger"" styl");
            WriteLiteral(@"e=""cursor:pointer;"" v-on:click=""removePoint(p.RegPointId)""></i></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <th>Кол-во: {{ pgr.Count }}</th>
                    <th>Сумма: {{ costRUBSumm(pgr.Points) }} руб.</th>
                </tr>
            </table>
        </div>
    </div>
    <div class=""d-flex justify-content-between"">
        <a v-if=""!IsClosed"" href=""#"" class=""text-danger""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6745, "\"", 6786, 3);
            WriteAttributeValue("", 6755, "Delete(", 6755, 7, true);
#line 127 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
WriteAttributeValue("", 6762, Model.PaymentReport.Id, 6762, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 6785, ")", 6785, 1, true);
            EndWriteAttribute();
            BeginContext(6787, 64, true);
            WriteLiteral("><i class=\"far fa-trash-alt text-danger\"></i> Удалить отчет</a>\n");
            EndContext();
#line 128 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
         if (User.IsInRole("administrator"))
        {   

#line default
#line hidden
            BeginContext(6909, 212, true);
            WriteLiteral("            <a v-if=\"!IsClosed\" href=\"#\" class=\"btn btn-info\" v-on:click=\"closeReport()\">Закрыть отчет</a>\n            <a v-if=\"IsClosed\" href=\"#\" class=\"btn btn-info\" v-on:click=\"openReport()\">Открыть отчет</a>\n");
            EndContext();
#line 132 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
        }

#line default
#line hidden
            BeginContext(7131, 601, true);
            WriteLiteral(@"    </div>
</div>


<script>
    $(function () {
        $('[data-toggle=""tooltip""]').tooltip();
        $('.tooltip-here').tooltip();
    });
</script>

<script>
    //Init app
    var app = new Vue({
        el: '#app',
        data: {
            WorkTypes: [/*{ value: 0, name: '-' },*/ { value: 1, name: 'Монтаж' }, /*{ value: 2, name: 'Демонтаж' },*/ { value: 3, name: 'ПНР' }],
            WorkTypesNames: [{ value: 0, name: '-' }, { value: 1, name: 'Монтаж' }, { value: 2, name: 'Демонтаж' }, { value: 3, name: 'ПНР' }],
            LinkStatusNames: ['не отв.', 'отв.'],
            IsClosed: ");
            EndContext();
            BeginContext(7733, 49, false);
#line 152 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                 Write(Model.PaymentReport.IsClosed.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(7782, 1514, true);
            WriteLiteral(@",
            OnlyLinkOk: true,
            DataCurrent: [],
            DataOld: [],
            AvailablePointGroups: [],
            AvailablePointGroupsOldPeriods: [],
            AddedPointsGroups: [],
        },
        computed: {
            AvailablePointsCount: function () {
                if (!this.DataCurrent) return 0;
                let count = 0;
                this.DataCurrent.forEach(gr => {
                    count += gr.Points.length;
                });
                return count;
            },
            AvailablePointGroupsOldCount: function () {
                if (!this.DataOld) return 0;
                let count = 0;
                this.DataOld.forEach(gr => {
                    count += gr.Points.length;
                });
                return count;
            },
            AddedPointsCount: function () {
                if (!this.AddedPointsGroups) return 0;
                let count = 0;
                this.AddedPointsGroups.forEach(gr => {
                    cou");
            WriteLiteral(@"nt += gr.Points.length;
                });
                return count;
            }
        },
        methods: {
            toAddCountChange: function (gr) {
                if (gr.ToAddCount > gr.Count) gr.ToAddCount = gr.Count;
                if (gr.ToAddCount < 0) gr.ToAddCount = 0;
                gr.ToAddCount = Math.round(gr.ToAddCount);
            },
            attachPoints: (pointsGroup) => AddToReport(pointsGroup),
            removePoint: (regPointId) => RemovePoint(");
            EndContext();
            BeginContext(9297, 22, false);
#line 193 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                Write(Model.PaymentReport.Id);

#line default
#line hidden
            EndContext();
            BeginContext(9319, 745, true);
            WriteLiteral(@", regPointId),
            costRUBSumm: (points) => {
                let summ = 0;
                points.forEach((item) => summ += item.CostRUB)
                return summ;
            },
            closeReport: () => {
                Swal.fire({
                    title: 'Вы уверены?',
                    text: ""После закрытия отчет невозможно будет редактировать!"",
                    type: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#d33',
                    cancelButtonColor: '#3085d6',
                    confirmButtonText: 'Да, закрыть отчет!'
                }).then((result) => {
                    if (result.value) {
                        fetch('/PaymentReport/Close/");
            EndContext();
            BeginContext(10065, 22, false);
#line 210 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                               Write(Model.PaymentReport.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10087, 735, true);
            WriteLiteral(@"', { method: 'POST' })
                            .then(r => {
                                if (r.ok) {
                                    app.IsClosed = true;
                                    ok('Отчет успешно закрыт');
                                }
                            });
                    }
                });
            },
            openReport: () => {
                Swal.fire({
                    title: 'Открыть отчет для редактирования?',
                    type: 'warning',
                    showCancelButton: true,
                    confirmButtonText: 'Открыть'
                }).then((result) => {
                    if (result.value) {
                        fetch('/PaymentReport/Open/");
            EndContext();
            BeginContext(10823, 22, false);
#line 228 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                              Write(Model.PaymentReport.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10845, 2126, true);
            WriteLiteral(@"', { method: 'POST' })
                            .then(r => {
                                if (r.ok) {
                                    app.IsClosed = false;
                                    ok('Отчет успешно открыт');
                                }
                            });
                    }
                });
            }
        },
        watch: {
            OnlyLinkOk: function (val) {
                if (val) {
                    this.DataCurrent = [];
                    this.AvailablePointGroups.forEach((item, i, arr) => {
                        this.DataCurrent.push(Object.assign({}, item));
                    });
                    this.DataCurrent.forEach((item, i, arr) => {
                        item.Points = item.Points.filter((_point, i, arr) => _point.IsLinkOk);
                        item.Count = item.Points.length;
                        item.ToAddCount = item.Points.length;
                        item.TypeDevice = item.TypeDevice + '✔';
                   ");
            WriteLiteral(@" });
                }
                else {
                    this.DataCurrent = this.AvailablePointGroups;
                }
                if (val) {
                    this.DataOld = [];
                    this.AvailablePointGroupsOldPeriods.forEach((item, i, arr) => {
                        this.DataOld.push(Object.assign({}, item));
                    });
                    this.DataOld.forEach((item, i, arr) => {
                        item.Points = item.Points.filter((_point, i, arr) => _point.IsLinkOk);
                        item.Count = item.Points.length;
                        item.ToAddCount = item.Points.length;
                        item.TypeDevice = item.TypeDevice + '✔';
                    });       
                }
                else {
                    this.DataOld = this.AvailablePointGroupsOldPeriods;
                }
                if (val) { ok('Отображаются только проверенные точки'); } else { ok('Отображаются все точки'); }
            }
        }
    });

    ");
            WriteLiteral("//LoadData\n    update();\n\n    function update() {\n        UpdateAviablePoints(");
            EndContext();
            BeginContext(12972, 28, false);
#line 280 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                       Write(Model.PaymentReport.WorkerId);

#line default
#line hidden
            EndContext();
            BeginContext(13000, 29, true);
            WriteLiteral(");\n        UpdateAddedPoints(");
            EndContext();
            BeginContext(13030, 22, false);
#line 281 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                     Write(Model.PaymentReport.Id);

#line default
#line hidden
            EndContext();
            BeginContext(13052, 394, true);
            WriteLiteral(@");
    }

    function UpdateAviablePoints(workerId) {
        fetch('/PaymentReport/GetWorkerAvailablePoints_Json/' + workerId)
        .then(r => r.json())
            .then(data => {
                let _availablePointGroups = [];
                let _availablePointGroupsOldPeriods = [];
                data.forEach((item, i, arr) => {
                    let currentReportDate = new Date(");
            EndContext();
            BeginContext(13447, 40, false);
#line 291 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                Write(Model.PaymentReport.DatePeriodStart.Year);

#line default
#line hidden
            EndContext();
            BeginContext(13487, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(13490, 41, false);
#line 291 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                                           Write(Model.PaymentReport.DatePeriodStart.Month);

#line default
#line hidden
            EndContext();
            BeginContext(13531, 4, true);
            WriteLiteral("-1, ");
            EndContext();
            BeginContext(13536, 39, false);
#line 291 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                                                                                                                                         Write(Model.PaymentReport.DatePeriodStart.Day);

#line default
#line hidden
            EndContext();
            BeginContext(13575, 1920, true);
            WriteLiteral(@");
                    //Из текущего периода
                    let currentPeriodPoints = item.Points.filter((_point, i, arr) => {
                        let _date = new Date(_point.PeriodYear, _point.PeriodMonth-1, _point.PeriodDay);
                        return (_date.getDay() === currentReportDate.getDay() &&
                            _date.getMonth() === currentReportDate.getMonth() &&
                            _date.getFullYear() === currentReportDate.getFullYear());
                    });
                    //Из старого
                    let oldPeriodPoints = item.Points.filter((_point, i, arr) => {
                        let _date = new Date(_point.PeriodYear, _point.PeriodMonth-1, _point.PeriodDay);
                        return _date < currentReportDate;
                    });

                    _availablePointGroups
                        .push({ TypeDevice: item.TypeDevice, Points: currentPeriodPoints, Count: currentPeriodPoints.length, ToAddCount: currentPeriodPoints.length, Work");
            WriteLiteral(@"Type: 0, CostRUB: 0 });
                    _availablePointGroupsOldPeriods
                        .push({ TypeDevice: item.TypeDevice, Points: oldPeriodPoints, Count: oldPeriodPoints.length, ToAddCount: 0, WorkType: 0, CostRUB: 0  });
                });
                app.AvailablePointGroups = _availablePointGroups;
                app.AvailablePointGroupsOldPeriods = _availablePointGroupsOldPeriods;
                app.OnlyLinkOk = false;
            });
    }
    function UpdateAddedPoints(reportId) {
        fetch('/PaymentReport/GetPointsGroups_Json/' + reportId)
            .then(r => r.json())
            .then(data => app.AddedPointsGroups = data);
    }
</script>

<script>
    function AddToReport(pointsGroup) {
        if (!pointsGroup.WorkType || pointsGroup.WorkType === 0) {
            err('Выберите тип работ');
            return;
        }
        pointsGroup.Id = ");
            EndContext();
            BeginContext(15496, 22, false);
#line 328 "D:\Repos\kurs-act-master\KursActWeb\Pages\PaymentReportPage.cshtml"
                    Write(Model.PaymentReport.Id);

#line default
#line hidden
            EndContext();
            BeginContext(15518, 1577, true);
            WriteLiteral(@";
        pointsGroup.Points = pointsGroup.Points.slice(-pointsGroup.ToAddCount);
        console.log(pointsGroup);

        fetch('/PaymentReport/AttachPoints', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(pointsGroup)
        })
            .then(r => {
                if (r.ok) {
                    ok('Точки усешно добавлены в отчёт');
                    update();
                }
            });
    }
    function RemovePoint(reportId, rpId) {
        fetch('/PaymentReport/RemovePoint?reportId=' + reportId + '&regPointId=' + rpId, { method: 'POST' })
            .then(r => {
                if (r.ok) {
                    update();
                    ok('Точка учета убрана из отчета');
                } else { err('Ошибка сервера'); }
            });
    }

    //Удалить отчет
    function Delete(id) {
        Swal.fire({
            title: 'Удалить отчёт №' + id + '?',
            type: 'question',
            showCancelBu");
            WriteLiteral(@"tton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Удалить'
        }).then((result) => {
            if (result.value) {
                fetch('/PaymentReport/Delete/' + id, { method: 'POST' })
                    .then(r => {
                        if (r.ok) {
                            ok('Отчет удален успешно');
                            document.location = '/PaymentReports';
                        }
                    });
            }
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KursActWeb.Pages.PaymentReportPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.PaymentReportPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KursActWeb.Pages.PaymentReportPageModel>)PageContext?.ViewData;
        public KursActWeb.Pages.PaymentReportPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
