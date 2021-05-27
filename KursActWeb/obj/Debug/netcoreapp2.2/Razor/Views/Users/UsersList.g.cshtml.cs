#pragma checksum "D:\Repos\kurs-act-master\KursActWeb\Views\Users\UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250cdba2b526db9c95bbd8ea698337f635839dc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UsersList), @"mvc.1.0.view", @"/Views/Users/UsersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/UsersList.cshtml", typeof(AspNetCore.Views_Users_UsersList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"250cdba2b526db9c95bbd8ea698337f635839dc1", @"/Views/Users/UsersList.cshtml")]
    public class Views_Users_UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Repos\kurs-act-master\KursActWeb\Views\Users\UsersList.cshtml"
  
    ViewData["Title"] = "Пользователи";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 10533, true);
            WriteLiteral(@"<div class=""d-flex justify-content-between shadow p-3 mb-4 rounded"" style=""background-color:#1c2324"">
    <h1 style=""color:white; margin:0""><i class=""fas fa-users-cog""></i> Пользователи</h1>
    <button class=""btn btn-outline-light"" onclick=""AddUser()""><i class=""fas fa-plus""></i></button>
</div>

<select class=""form-control mb-1 border-dark"" id=""selectRoles"" name=""selectRoles""></select>
<div id=""usersTable""></div>

<script>
    //Выбранная роль из списка
    var selectedRoleId = null;
    $(document).ready(function () {
        UpdateRolesList();
    });
    function UpdateRolesList() {
        fetch('/Users/GetRoles').then(r => r.json()).then(data => {
            let html = """";
            for (var key in data) {
                if (selectedRoleId == null) {
                    selectedRoleId = key;
                }
                html += ""<option value="" + key + "">"" + data[key] + ""</option>""
            }
            $('#selectRoles').html(html);
            $('#selectRoles').val(selectedRoleId);
       ");
            WriteLiteral(@"     GetUsersTable(selectedRoleId);
        });
    }
    //Событие выбора роли
    $('#selectRoles').on('change', function () {
        selectedRoleId = this.value;
        GetUsersTable(selectedRoleId);
    });

    //Запрос на получение списка пользователей по Id роли
    function GetUsersTable(roleId) {
        fetch('/Users/GetRoleUsersTable/' + roleId).then(r => r.text())
            .then(data => {
                $('#usersTable').html(data);
            });
    }

    //Меню с кнопками для работы с данными пользователя
    function ShowEditMenu(userId) {
        fetch('/Users/UserInfo/' + userId).then(response => response.json())
            .then(data => {
                Swal.fire({
                    showConfirmButton: false,
                    title: data.Name,
                    html:
                        '<button id=""editMain"" class=""btn btn-info"" style=""width:300px; margin: 3px;""><div style=""text-align: left; padding-left: 20%""><i class=""fas fa-pencil-alt""></i> Имя, Login, Email</div></bu");
            WriteLiteral(@"tton>' +
                        '<button id=""editRole"" class=""btn btn-info"" style=""width:300px; margin: 3px;""><div style=""text-align: left; padding-left: 20%""><i class=""fas fa-arrow-right""></i> Переместить в...</div></button>' +
                        '<button id=""editPass"" class=""btn btn-info"" style=""width:300px; margin: 3px;""><div style=""text-align: left; padding-left: 20%""><i class=""fas fa-key""></i> Новый пароль</div></button>' +
                        '<button id=""deleteUser"" class=""btn btn-danger"" style=""width:300px; margin: 3px;"">Удалить</button>',
                    onBeforeOpen: () => {
                        const content = Swal.getContent()
                        const $ = content.querySelector.bind(content)
                        const editMain = $('#editMain');
                        const editRole = $('#editRole');
                        const editPass = $('#editPass');
                        const deleteUser = $('#deleteUser');
                        editMain.addEventListener('click',");
            WriteLiteral(@" () => {
                            EditMain(data); //Диалог: Изменить Имя, Login, Email
                        });
                        editRole.addEventListener('click', () => {
                            UpdateRole(data); //Диалог: Изменить роль
                        });
                        editPass.addEventListener('click', () => {
                            EditPass(data); //Диалог: Установить новый пароль
                        });
                        deleteUser.addEventListener('click', () => {
                            DeleteUser(data); //Диалог: Удалить пользователя
                        });
                    }
                })
            })
    }
    //Диалог изменить Имя, Login, Email
    function EditMain(userData) {
        Swal.fire({
            title: 'Изменить данные',
            html:
                '<input id=""inputName"" class=""swal2-input"" value=""' + userData.Name + '"">' +
                '<input id=""inputLogin"" class=""swal2-input"" value=""' + userData.Login + '");
            WriteLiteral(@""">' +
                '<input id=""inputEmail"" class=""swal2-input"" value=""' + userData.Email + '"">',
            focusConfirm: false,
            showCancelButton: true,
            cancelButtonText: 'Отмена',
            confirmButtonText: 'Сохранить',
            focusCancel: true,
            preConfirm: () => {
                return {
                    Id: userData.Id,
                    Login: $('#inputLogin').val(),
                    Name: $('#inputName').val(),
                    Email: $('#inputEmail').val()
                }
            }
        }).then(userNew => {
            if (userNew.value) {
                fetch('/Users/UpdateUserInfo', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(userNew.value)
                }).then((response) => {
                    if (response.ok) {
                        GetUsersTable(selectedRoleId);
                        ok('Данные успешно изменены');
   ");
            WriteLiteral(@"                 } else { err('Ошибка сервера' + response.statusText); }
                });
            }
        });
    }
    //Установить новый пароль
    function EditPass(userData) {
        let uData = { Id: userData.Id, Password: '' };
        Swal.fire({
            title: 'Пароль',
            input: 'password',
            inputPlaceholder: 'Введите новый пароль',
            inputAttributes: {
                autocapitalize: 'off',
                autocorrect: 'off'
            }
        }).then(newPass => {
            if (newPass.value) {
                uData.Password = newPass.value;
                fetch('/Users/NewPass', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(uData)
                }).then((response) => {
                    if (response.status === 200) {
                        ok('Новый пароль записан успешно');
                    } else { err('Ошибка сервера' + response.statusText");
            WriteLiteral(@"); }
                });
            }
        });
    }

    //Добавить пользователя
    function AddUser() {
        Swal.fire({
            title: 'Новый пользователь',
            html:
                '<input id=""inputName"" class=""swal2-input"" placeholder=""ФИО"">' +
                '<input id=""inputLogin"" class=""swal2-input"" placeholder=""Логин"">' +
                '<input id=""inputPass"" class=""swal2-input"" placeholder=""Пароль"">' +
                '<input id=""inputEmail"" class=""swal2-input"" placeholder=""e-mail"">',
            focusConfirm: false,
            showCancelButton: true,
            cancelButtonText: 'Отмена',
            confirmButtonText: 'Сохранить',
            focusCancel: true,
            preConfirm: () => {
                return {
                    Id: 0,
                    Name: $('#inputName').val(),
                    Login: $('#inputLogin').val(),
                    Password: $('#inputPass').val(),
                    Email: $('#inputEmail').val(),
                    RoleId: s");
            WriteLiteral(@"electedRoleId
                }
            }
        }).then(userNew => {
            if (userNew.value) {
                fetch('/Users/AddNewUser', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(userNew.value)
                }).then((response) => {
                    if (response.status === 200) {
                        UpdateRolesList();
                        ok('Пользователь успешно добавлен');
                    } else { err('Ошибка сервера' + response.statusText); }
                });
            }
        });
    }
    //Удалить пользователя
    function DeleteUser(user) {
        Swal.fire({
            title: 'Удалить пользователя ' + user.Name + '?',
            text: ""Это необратимое действие! Подумой..."",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Да, удали");
            WriteLiteral(@"ть его!',
            cancelButtonText: 'Отмена'
        }).then((result) => {
            if (result.value) {
                fetch('/Users/DeleteUser', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(user)
                }).then((response) => {
                    if (response.status === 200) {
                        UpdateRolesList();
                        ok('Пользователь удален');
                    } else { err('Ошибка сервера' + response.statusText); }
                });
            }
        })
    }

    function UpdateRole(user) {
        Swal.fire({
            title: 'Установить новую роль для пользователя',
            input: 'select',
            inputOptions: fetch('/Users/GetRoles').then(r => r.json()).then(data => data),
            inputPlaceholder: 'Выберите роль...',
            showCancelButton: true,
            inputValidator: (value) => {
                return new Promise((resolve");
            WriteLiteral(@") => {
                    if (value === '') {
                        resolve('Необходимо выбрать роль из списка');
                    } else {
                        resolve();
                        user.RoleId = value;
                        fetch('/Users/UpdateUserRole', {
                            method: 'POST',
                            headers: { 'Content-Type': 'application/json' },
                            body: JSON.stringify(user)
                        }).then((response) => {
                            if (response.status === 200) {
                                selectedRoleId = value;
                                UpdateRolesList();
                                ok('Новая роль сохранена');
                            } else { err('Ошибка сервера' + response.statusText); }
                        });
                    }
                })
            }
        })
    }

    function ok(titleText) {
        return Swal.fire({
            title: titleText,
            type: 's");
            WriteLiteral(@"uccess',
            showConfirmButton: false,
            timer: 1500
        });
    }
    function err(titleText) {
        return Swal.fire({
            title: titleText,
            type: 'error',
            showConfirmButton: false,
            timer: 500
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
