#pragma checksum "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b4fb6d1323a1b71835dde9d05abaf0d3a3b0d2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Product : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Product</h3>");
#nullable restore
#line 7 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Product Name</th>\r\n                <th>Unit Price (C)</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 21 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 24 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
                         forecast.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 25 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
                         forecast.UnitPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "hidden", 
#nullable restore
#line 32 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
              IsShow

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "<h3>Edit Product</h3>\r\n    Product Name<br>\r\n    ");
            __builder.OpenElement(16, "p");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
                                          ProdName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProdName = __value, ProdName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    Price<br>\r\n    ");
            __builder.OpenElement(22, "p");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
                                          UnitPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UnitPrice = __value, UnitPrice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
                                           Show

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
                                           ProductUpdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Update");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\mydata\OneDrive - mvp\temp\DevsSpeak\BlazorApp1\BlazorApp1\Pages\Product.razor"
       
    //private WeatherForecast[] forecasts;
    private ProductModel[] forecasts;
    private bool IsShow { get; set; } = true;

    private float UnitPrice { get; set; }
    public string ProdName { get; set; }

    private void Show()
    {
        IsShow = !IsShow;
    }

    protected override async Task OnInitializedAsync()
    {

        forecasts = await PeopleService.GetProductAsync(DateTime.Now);
    }

    public void ProductUpdate()
    {
        PeopleService.UpdateProduct(ProdName, UnitPrice);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PeopleService PeopleService { get; set; }
    }
}
#pragma warning restore 1591