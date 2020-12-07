#pragma checksum "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/RecipeView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba5f874bb496974692bf481b09d3fa55fc6231d5"
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
#line 3 "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/RecipeView.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/RecipeView.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/RecipeView.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipeView")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipeView/{Id:int}")]
    public partial class RecipeView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "/Users/wojtek/RiderProjects/SEP3/Blazor/Pages/RecipeView.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Recipe Recipe { get; set; }
    public IList<Ingredient> ingredients { get; set; } 



    protected override async Task OnInitializedAsync() {
        if (Id != 0) {
            Recipe = RecipeService.Recipes.FirstOrDefault(p => p.recipeId == Id);
            await IngredientsService.GetIngredientsAsync(Id);
            ingredients = IngredientsService.Ingredients;
        }
    }

    public async Task ChooseRecipe()
    {
        try
        {
            NavigationManager.NavigateTo("/ingredientsList");
        }
        catch (Exception e)
        {
            Console.WriteLine("failed");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIngredientsService IngredientsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService RecipeService { get; set; }
    }
}
#pragma warning restore 1591
