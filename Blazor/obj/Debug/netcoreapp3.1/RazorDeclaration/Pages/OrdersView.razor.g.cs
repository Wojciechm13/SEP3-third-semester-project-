#pragma checksum "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\OrdersView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1e5589f736888ef8f3a54040c5814f08bee5a46"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\OrdersView.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\OrdersView.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\OrdersView.razor"
using Blazor.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders")]
    public partial class OrdersView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\OrdersView.razor"
       
    private IList<Order> orders;
    private IList<Order> ordersToShow;

    protected override async Task OnInitializedAsync()
    {
        orders = await OrderService.GetOrdersAsync();
        ordersToShow = orders.Where(u => u.username.Equals(CustomAuthenticationStateProvider.getUser().username)).ToList();

        base.OnInitialized();
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService OrderService { get; set; }
    }
}
#pragma warning restore 1591