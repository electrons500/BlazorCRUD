#pragma checksum "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f87a9be157997dcda5e1b362609fce757fa6a5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Create.razor"
using BlazorCRUD.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employee/Create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\BlazorCRUD\BlazorCRUD\Pages\Employee\Create.razor"
       

    EmployeeViewModel model = new EmployeeViewModel();

    protected void CreateEmployee()
    {
        bool result = _employeeservice.AddEmployee(model);
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
