#pragma checksum "C:\Users\HP\Desktop\Kamran\Programming\.NET Core - API\Blazor\BlazorAPIClient\Pages\Base64Converter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5dc11c6246b46dbc1b5a4d7201aa81591c2324d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/base64converter")]
    public partial class Base64Converter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Base 64 Converter</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-froup\"><textarea class=\"form-control col-md-6\" placeholder=\"Non Base64\"></textarea>\r\n    <small class=\"form-text text-muted\">This is value you want to encode to Base64</small></div>\r\n\r\n");
            __builder.AddMarkupContent(2, "<button class=\"btn btn-primary\" type=\"button\"><span class=\"oi oi-arrow-thick-bottom\"></span> Encode\r\n</button>\r\n\r\n");
            __builder.AddMarkupContent(3, "<button class=\"btn btn-success\" type=\"button\"><span class=\"oi oi-arrow-thick-top\"></span> Decode\r\n</button>\r\n\r\n");
            __builder.AddMarkupContent(4, "<div class=\"form-group\"><textarea class=\"form-control col-md-6\" placeholder=\"Non Base64\"></textarea>\r\n    <small class=\"form-text text-muted\">This is value you want to encode as Base64</small></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
