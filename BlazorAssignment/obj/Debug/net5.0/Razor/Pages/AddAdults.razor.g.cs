#pragma checksum "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110544dc5ae36a05bf0874a8117549ff1ff3db83"
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
#line 3 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
using BlazorAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
using BlazorAssignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
           [Authorize(Policy = "MustBeAdult")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                  newAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                            AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n        User Id:<br>\r\n        ");
                __Blazor.BlazorAssignment.Pages.AddAdults.TypeInference.CreateInputNumber_0(__builder2, 11, 12, 
#nullable restore
#line 15 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                  newAdult.Id

#line default
#line hidden
#nullable disable
                , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Id = __value, newAdult.Id)), 14, () => newAdult.Id);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n        FirstName:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(19);
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                    newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n        LastName:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(27);
                __builder2.AddAttribute(28, "rows", "4");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                             newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n        HairColor:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(36);
                __builder2.AddAttribute(37, "rows", "4");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                             newAdult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.HairColor = __value, newAdult.HairColor))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n        EyeColor:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(45);
                __builder2.AddAttribute(46, "rows", "4");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                             newAdult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.EyeColor = __value, newAdult.EyeColor))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "\r\n        Age:<br>\r\n        ");
                __Blazor.BlazorAssignment.Pages.AddAdults.TypeInference.CreateInputNumber_1(__builder2, 54, 55, "4", 56, 
#nullable restore
#line 35 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                           newAdult.Age

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Age = __value, newAdult.Age)), 58, () => newAdult.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "\r\n        Weight:<br>\r\n        ");
                __Blazor.BlazorAssignment.Pages.AddAdults.TypeInference.CreateInputNumber_2(__builder2, 63, 64, "4", 65, 
#nullable restore
#line 39 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                           newAdult.Weight

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Weight = __value, newAdult.Weight)), 67, () => newAdult.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "\r\n        Height:<br>\r\n        ");
                __Blazor.BlazorAssignment.Pages.AddAdults.TypeInference.CreateInputNumber_3(__builder2, 72, 73, "4", 74, 
#nullable restore
#line 43 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                           newAdult.Height

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Height = __value, newAdult.Height)), 76, () => newAdult.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group");
                __builder2.AddMarkupContent(80, "\r\n        Sex:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(81);
                __builder2.AddAttribute(82, "rows", "4");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
                                             newAdult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Sex = __value, newAdult.Sex))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n     \r\n    \r\n    ");
                __builder2.AddMarkupContent(87, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\cooln\RiderProjects\BlazorAssignment\BlazorAssignment\Pages\AddAdults.razor"
       
    private Adult newAdult = new Adult();
    
    
    private void AddNewAdult()
    {
        AdultsService.addAdult(newAdult);
        NavigationManager.NavigateTo("/Adults");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
namespace __Blazor.BlazorAssignment.Pages.AddAdults
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
