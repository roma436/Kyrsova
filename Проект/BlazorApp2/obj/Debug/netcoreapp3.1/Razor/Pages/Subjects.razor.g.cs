#pragma checksum "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5758f2dc021f83d24f394ca3ed74ef497f83a059"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using BlazorApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\_Imports.razor"
using myprogram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
using myprogram.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
using BlazorApp2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Subject")]
    public partial class Subjects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> Предмети </h1>\r\n");
#nullable restore
#line 9 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
 if (subject != null && mode == MODE.Add)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "placeholder", "Name");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                   name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    <br>\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                      Insert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddMarkupContent(10, "Вставити ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 14 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
 if (subject != null && mode == MODE.EditDelete) // Update & Delete form
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "placeholder", "Name");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                   name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    <br>\r\n    ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                      Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddMarkupContent(22, "Оновити");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.AddMarkupContent(24, "<span>&nbsp;&nbsp;&nbsp;&nbsp;</span>\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                      Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddMarkupContent(28, "Видалити");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 25 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
 if (subject == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.AddMarkupContent(32, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 31 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                      Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-success");
            __builder.AddMarkupContent(37, "Додати");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-hover");
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.AddMarkupContent(42, "<thead>\r\n            <tr>\r\n                <th>Код Предмета</th>\r\n                <th>Ім\'я предмета</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(43, "tbody");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 44 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
             foreach (var item in subject)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.OpenElement(46, "tr");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                              (() => Show(item.KodSubject.ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 47 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                         item.KodSubject

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 48 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 50 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 53 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Рома\Desktop\учоба\2-ий семестр\Куратор\Проект\BlazorApp2\Pages\Subjects.razor"
       
    Subject[] subject;
    int kodsubject;
    string name;

    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    Subject subjects;


    protected override async Task OnInitializedAsync()
    {

        await load();
    }
    protected async Task load()
    {
        subject = await subjectService.GetSubjectAsync();
    }

    protected async Task Insert()
    {
        Subject s = new Subject()
        {

            Name = name
        };
        await subjectService.InsertSubjetcAsync(s);
        ClearFields();
        await load();
        mode = MODE.None;
    }
    protected void ClearFields()
    {
        name = string.Empty;
    }
    protected void Add()
    {
        ClearFields();
        mode = MODE.Add;
    }
    protected async Task Update()
    {

        Subject s = new Subject()
        {
            KodSubject = kodsubject,
            Name = name
        };

        await subjectService.UpdateSubjectAsync(kodsubject.ToString(), s);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Delete()
    {
        await subjectService.DeleteSubjectAsync(kodsubject);
        ClearFields();
        await load();
        mode = MODE.None;
    }
    protected async Task Show(string id)
    {
        subjects = await subjectService.GetSubjectByIdAsync(id);
        kodsubject = subjects.KodSubject;
        name = subjects.Name;
        mode = MODE.EditDelete;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SubjectService subjectService { get; set; }
    }
}
#pragma warning restore 1591
