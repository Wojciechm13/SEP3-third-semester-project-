#pragma checksum "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3aeb27ff081d561aa1bd8e88c667acb1b76d316"
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
#line 1 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
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
#line 8 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
 if (accounts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 13 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
}
else if (!accounts.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p>\r\n        <em>No user items exist. Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 19 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>User name</th>\r\n            <th>Password</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 30 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
         foreach (var account in accountsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 33 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
                     account.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
                     account.password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 36 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 39 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\jtyta\RiderProjects\SEP3v5\Blazor\Pages\ViewUsers.razor"
       

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
