#pragma checksum "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c000f7a13271d5f43b6781ca4e26101479d27660"
// <auto-generated/>
#pragma warning disable 1591
namespace Hand_in_1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Hand_in_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\_Imports.razor"
using Hand_in_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Shared\MainLayout.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Shared\MainLayout.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Shared\MainLayout.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Shared\MainLayout.razor"
using Hand_in_1.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<Hand_in_1.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row px-4");
            __builder.OpenComponent<LoginComponent.Login>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.AddMarkupContent(10, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddContent(14, 
#nullable restore
#line 21 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n}");
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Shared\MainLayout.razor"
      
    
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    public IList<User> users { get; private set; }
    private readonly string adultsFile = "adults.json";
    
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var user = (await AuthStat).User;
        if(!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/login");
            // NavigationManager.NavigateTo($"/Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }

   // private void SaveChanges()
 //   {
      //  string user = JsonSerializer.Serialize(User, new JsonSerializerOptions
    //    {
    //        WriteIndented = true
    //    });
       // using (StreamWriter outputFile = new StreamWriter(user, false))
     //    using StreamWriter sw = new StreamWriter("Filecontext.cs");
     //   {
       //     sw.Write(user);
       // }
        
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591