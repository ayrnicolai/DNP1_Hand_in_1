// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Hand_in_1.Pages
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
#line 2 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Pages\Adult.razor"
using Hand_in_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Pages\Adult.razor"
using Hand_in_1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adult")]
    public partial class Adult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\ayrni\OneDrive\Skrivebord\Hand in 1\Pages\Adult.razor"
       
    private IList<Person> adult;
    private IList<Person> allAdults;
    private IList<Person> adultsToShow;

    private void Filter(ChangeEventArgs changeEventArgs)
    {
        int? filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) {}
        if (filterById != null)
        {
            adultsToShow = allAdults.Where(t => t.Id == filterById).ToList();
        }
        else
        {
            adultsToShow = allAdults;
        }
        
    }

    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultData.getAdult();
        adultsToShow = allAdults;
    }

    private void RemoveAdult(int Id)
    {
        Person personToRemove = adultsToShow.First(t => t.Id == Id);
        AdultData.RemoveAdult(Id);
        allAdults.Remove(personToRemove);
        adultsToShow.Remove(personToRemove);
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
