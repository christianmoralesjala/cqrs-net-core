// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using MainLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using MainLibrary.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\_Imports.razor"
using MainLibrary.Queries;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\christian.morales\Desktop\enterview\BlazorUI\Pages\Index.razor"
       
    List<PersonModel> people;

    protected override async Task OnInitializedAsync()
    {
        people = await _mediator.Send(new GetPersonListQuery());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MediatR.IMediator _mediator { get; set; }
    }
}
#pragma warning restore 1591
