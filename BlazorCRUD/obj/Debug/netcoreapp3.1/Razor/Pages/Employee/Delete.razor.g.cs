#pragma checksum "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e951c7c954c4ba370e549b12b607b94ef5f13464"
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
#line 2 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
using BlazorCRUD.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employee/Delete/{CurrentID}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete</h3>\r\n<hr>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h2>Are you sure you want to delete this?</h2>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-8");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label>Employee ID:</label>\r\n            ");
            __builder.OpenElement(12, "label");
            __builder.AddContent(13, 
#nullable restore
#line 15 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
                    model.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<label>First name:</label>\r\n            ");
            __builder.OpenElement(20, "label");
            __builder.AddContent(21, 
#nullable restore
#line 19 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
                    model.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<label>Last name:</label>\r\n            ");
            __builder.OpenElement(28, "label");
            __builder.AddContent(29, 
#nullable restore
#line 23 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
                    model.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<label>Age:</label>\r\n            ");
            __builder.OpenElement(36, "label");
            __builder.AddContent(37, 
#nullable restore
#line 27 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
                    model.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-md-4");
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-danger");
            __builder.AddAttribute(54, "value", "Delete");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
                                                                                  EditEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            &nbsp;\r\n            ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "value", "Cancel");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
                                                                                   cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Delete.razor"
       


    [Parameter]
    public string currentID { get; set; }

    EmployeeViewModel model = new EmployeeViewModel();

    protected override async Task OnInitializedAsync()
    {
        model = await Task.Run(() => _employeeservice.GetEmployeeDetails(Convert.ToInt32(currentID)));
    }

    protected void EditEmployee()
    {
        bool result = _employeeservice.DeleteEmployee(Convert.ToInt32(currentID));
        if (result)
        {
            NavigationManager.NavigateTo("/Employee/Index");
        }

    }

    protected void cancel()
    {
        NavigationManager.NavigateTo("/Employee/Index");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorCRUD.Models.Services.EmployeeService _employeeservice { get; set; }
    }
}
#pragma warning restore 1591
