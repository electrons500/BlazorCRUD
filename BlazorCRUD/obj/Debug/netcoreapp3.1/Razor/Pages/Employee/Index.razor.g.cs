#pragma checksum "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a797930d9ecd97d959cb312d5c02f4027aaf27c6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages.Employee
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
using BlazorCRUD.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employee/Index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index</h3>\r\n<br>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
 if (GetEmployees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em> Loading.......</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<a href=\"Employee/Create\">Create</a>\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Employee ID</th>\r\n                <th>First name</th>\r\n                <th>Last name</th>\r\n                <th>Age</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
             foreach (var model in GetEmployees)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
                         model.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
                         model.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
                         model.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
                         model.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "Employee/Edit/" + (
#nullable restore
#line 34 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
                                                model.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "Employee/Delete/" + (
#nullable restore
#line 35 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
                                                  model.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 38 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 42 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Index.razor"
       
    List<EmployeeViewModel> GetEmployees;

    protected override async Task OnInitializedAsync()
    {
        GetEmployees = await Task.Run(() => _employeeService.GetEmployees());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorCRUD.Models.Services.EmployeeService _employeeService { get; set; }
    }
}
#pragma warning restore 1591