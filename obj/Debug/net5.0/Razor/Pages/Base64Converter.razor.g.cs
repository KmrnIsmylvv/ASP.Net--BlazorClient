#pragma checksum "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac4ff85205c282ea8c0f739b6ddb9ca21e449e70"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAPIClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using BlazorAPIClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\_Imports.razor"
using BlazorAPIClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/base64converter")]
    public partial class Base64Converter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Base 64 Converter</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-froup");
            __builder.OpenElement(3, "textarea");
            __builder.AddAttribute(4, "class", "form-control col-md-6");
            __builder.AddAttribute(5, "placeholder", "Non Base64");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor"
                                                                                  NonBase64Body

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NonBase64Body = __value, NonBase64Body));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<small class=\"form-text text-muted\">This is value you want to encode as Base64</small>");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor"
                                                        ConvertToBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "<span class=\"oi oi-arrow-thick-bottom\"></span> Encode\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-success");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor"
                                                        ConvertFromBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<span class=\"oi oi-arrow-thick-top\"></span> Decode\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.OpenElement(25, "textarea");
            __builder.AddAttribute(26, "class", "form-control col-md-6");
            __builder.AddAttribute(27, "placeholder", "Base64");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor"
                                                                              Base64Body

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Base64Body = __value, Base64Body));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.AddMarkupContent(31, "<small class=\"form-text text-muted\">This is value you want to encode from Base64</small>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor"
       
    public string NonBase64Body { get; set; }
    public string Base64Body { get; set; }

    private void ConvertToBase64()
    {
        byte[] plainTextByte = Encoding.UTF8.GetBytes(NonBase64Body);
        Base64Body = Convert.ToBase64String(plainTextByte);
    }

    private void ConvertFromBase64()
    {
        byte[] base64EncodedBytes = Convert.FromBase64String(Base64Body);
        NonBase64Body = Encoding.UTF8.GetString(base64EncodedBytes);
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
