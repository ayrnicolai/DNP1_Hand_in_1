#pragma checksum "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\Pages\SecurityLevel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aa435547ad1f475d774a9b1bba0d8b8d410711d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Security")]
    public partial class SecurityLevel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h3");
                __builder2.AddContent(3, "Hello ");
                __builder2.AddContent(4, 
#nullable restore
#line 5 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\Pages\SecurityLevel.razor"
               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(5, "\n\n    ");
                __builder2.OpenElement(6, "h5");
                __builder2.AddContent(7, "Your security level is ");
                __builder2.AddContent(8, 
#nullable restore
#line 7 "C:\Users\ayrni\OneDrive\Skrivebord\DNP\Hand in 1\Pages\SecurityLevel.razor"
                                context.User.FindFirst(claim => claim.Type.Equals("SecurityLevel")).Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n\n\n");
            __builder.AddMarkupContent(10, "<p>This piece of text is visible for level 0 and above</p>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Policy", "SecurityLevel2");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "<p>This piece of text is visible for level 2 and above</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "Policy", "SecurityLevel4");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "<p>This is visible for level 4 and above</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
