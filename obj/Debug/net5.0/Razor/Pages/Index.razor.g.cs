#pragma checksum "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f694a966ec5eeeb7886124b35bf33952f9389a4"
// <auto-generated/>
#pragma warning disable 1591
namespace Hand_in_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Hand_in_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\_Imports.razor"
using Hand_in_1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "wrapper");
            __builder.AddMarkupContent(3, "<div class=\"logo\"><img src=\"https://i.postimg.cc/HxD4Zp7v/Snapchat-17086115.jpg\" alt></div>\n        ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "nav-area");
            __builder.OpenElement(6, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "nav-link");
            __builder.AddAttribute(9, "href", "Index");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "nav-link");
            __builder.AddAttribute(16, "href", "AddAdult");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "Add Adult");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "Adult");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(25, "Show Adults");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n            ");
            __builder.OpenElement(27, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", "SecurityLevel");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Security Level");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n    ");
            __builder.AddMarkupContent(34, "<div class=\"welcome-text\"><h1>\n            We are creative</h1>\n        <a href=\"https://www.youtube.com/watch?v=dQw4w9WgXcQ\">Contact US</a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n\n\n\n");
            __builder.OpenComponent<Hand_in_1.Shared.SurveyPrompt>(36);
            __builder.AddAttribute(37, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
