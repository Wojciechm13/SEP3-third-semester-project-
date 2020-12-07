#pragma checksum "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/ViewRecipes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0f1d1bff16932be7b6516c684c855a96efea5e"
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
#line 1 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/wojtek/RiderProjects/SEP3/Blazor/_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/ViewRecipes.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/ViewRecipes.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewRecipes")]
    public partial class ViewRecipes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/ViewRecipes.razor"
       

 
    public IList<Recipe> Recipes { get; set; }

    protected override async Task OnInitializedAsync()
    {
      Recipes = await RecipeService.GetRecipesAsync();
        Console.WriteLine(Recipes[0].recipeName +"--> ViewRecipes.razor");
        base.OnInitialized();
    }

    private void NavigateToComponent(Recipe p) {
      NavigationManager.NavigateTo("recipeView/" + p.recipeId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService RecipeService { get; set; }
    }
}
#pragma warning restore 1591
