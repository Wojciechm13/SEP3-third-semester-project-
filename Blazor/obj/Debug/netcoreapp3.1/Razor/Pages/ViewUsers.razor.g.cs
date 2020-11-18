#pragma checksum "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46edeb5a7ef3cea842a9c8576bac79121fae5b01"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewUsers")]
    public partial class ViewUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
 if (accounts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
}
else if (!accounts.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>No user items exist. Please add some.</em></p>");
#nullable restore
#line 19 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>User name</th>\r\n            <th>Password</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 30 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
         foreach (var account in accountsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 33 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
                     account.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 34 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
                     account.password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\ViewUsers.razor"
       

    private IList<Account> accounts;
    private IList<Account> accountsToShow;
    
    protected override async Task OnInitializedAsync()
    {
        accounts = await AccountService.GetAccountsAsync();
        accountsToShow = accounts;
        
        base.OnInitialized();
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
