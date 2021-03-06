// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\ChartsAdultInfo.razor"
using Syncfusion.Blazor.HeatMap.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\ChartsAdultInfo.razor"
using BlazorAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\ChartsAdultInfo.razor"
using BlazorAssignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\ChartsAdultInfo.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChartsAdultInfo")]
    public partial class ChartsAdultInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\ChartsAdultInfo.razor"
 

    private IList<Adult> _adultList;
    private AdultsService _adultsService;
    private List<Adult> _adultListForPieChart;
    
    private List<UniqueColors> _uniqueColors;

    protected override async Task OnInitializedAsync()
    {
        _adultsService = new AdultsService();

        _adultList = _adultsService.ReadData<Adult>(); //   "adults.json"

        _uniqueColors = new List<UniqueColors>();
       


        gettingAllUniqueColors();
    }

    public void gettingAllUniqueColors()
    {

        foreach (var adult in _adultList)
        {
            if (!_uniqueColors.Any(u => u.color == adult.GetEyeColor()))
            {
                _uniqueColors.Add(new UniqueColors { color = adult.GetEyeColor(), numberOfColors = 0 });
            }
        }

        foreach (var unique in _uniqueColors)
        {
            int counter = 0;

            foreach(var adults in _adultList)
            {
                if (adults.GetEyeColor() == unique.getUniqueColor())
                    counter++;
            }
            unique.numberOfColors = counter;
        }
    }



    // string currentEyeColor = "";

    // foreach (var adult in _adultList)
    // {
    //     currentEyeColor = adult.GetEyeColor();
    //    
    //    bool flag = true;
    //   int currentEyeColorNumber = 0;
    //   foreach (var unique in _uniqueColors)
    //   {
    //       if (currentEyeColor == unique.getUniqueColor())
    //      {
    //          flag = false;
    //          currentEyeColorNumber++;
    // //     }
    //  }
    //  if (flag == true)
    //  {
    //       _uniqueColors.Add(new UniqueColors(currentEyeColor,currentEyeColorNumber));
    //  }
    // }
    

        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
