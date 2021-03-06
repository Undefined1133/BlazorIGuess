#pragma checksum "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4639bee68d46a9e88a38a6ec5da6154ac1314334"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using BlazorAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using BlazorAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
using BlazorAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
using BlazorAssignment.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                                                        (arg) => Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n    Filter By Eye Color: ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                                                        (txt) => FilterByEyeColor(txt)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
 if (_adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p><em>Loading...</em></p>");
#nullable restore
#line 23 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, @"<thead><tr><th>Id</th>
            <th>FirstName</th>
            <th>LastName</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>JobTitle</th></tr></thead>
        ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 43 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
         foreach (var adults in _adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 46 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 47 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 48 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 49 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 50 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 51 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 52 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 53 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 54 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 55 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                     adults.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
                                          () => Edit(adults.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\Adults.razor"
       
    private IList<Adult> _adultList;
    private AdultsService _adultsService;
    private IList<Adult> _adultsToShow;
    
    private int? filterById;
    private string? filterByEyeColor;
    
    protected override async Task OnInitializedAsync()
    {
        _adultsService = new AdultsService();
        
        _adultList =  _adultsService.ReadData<Adult>();
        _adultsToShow = _adultList; //   "adults.json"
    }
    
    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }
    
    private void Edit(int id)
    {
        NavMgr.NavigateTo($"Edit/{id}");
    }
    
    private void FilterByEyeColor(ChangeEventArgs args)
    {
        filterByEyeColor = null;
        try
        {
            filterByEyeColor = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }
    private void ExecuteFilter()
    {
        _adultsToShow = _adultList.Where(a =>
            (filterById != null && a.Id == filterById || filterById == null)
            && filterByEyeColor!= null && a.EyeColor == filterByEyeColor || filterByEyeColor== null).ToList();
    }
    private void Filter(ChangeEventArgs changeEventArgs)
    {
        int? filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        if (filterById != null)
        {
            _adultsToShow = _adultList.Where(a => a.Id == filterById).ToList();
        }
        else
        {
            _adultsToShow = _adultList;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
    }
}
#pragma warning restore 1591
