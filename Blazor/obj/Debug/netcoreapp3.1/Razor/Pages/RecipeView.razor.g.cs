#pragma checksum "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d69d03821a5b8ceca84f5157f6c00a4ff353db44"
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
#line 3 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
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
#nullable restore
#line 11 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
 if (Recipe == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
}
else if (ingredients == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 22 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
}
else if (!ingredients.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>No ingredient exist. Please add some.</em></p>");
#nullable restore
#line 28 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "jumbotron");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-4");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", "../Images/" + (
#nullable restore
#line 34 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                                     Recipe.imageName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", true);
            __builder.AddAttribute(12, "alt", "...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-8");
            __builder.OpenElement(16, "h1");
            __builder.AddAttribute(17, "class", "display-4");
            __builder.AddContent(18, 
#nullable restore
#line 37 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                                       Recipe.recipeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "lead");
            __builder.AddContent(22, 
#nullable restore
#line 38 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                                 Recipe.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                <hr class=\"my-4\">\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col");
            __builder.OpenElement(28, "ul");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "my-3");
            __builder.AddContent(31, "Preparation time: ");
            __builder.AddContent(32, 
#nullable restore
#line 43 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                                                                Recipe.cookingTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.AddMarkupContent(34, "<div class=\"col\"><a class=\"btn btn-primary btn-lg mt-5\" href=\"#\" role=\"button\">Order necessary ingredients to your home!</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "jumbotron instruction");
            __builder.AddMarkupContent(41, "<h2 class=\"mb-5\">Preparation guide</h2>\n                ");
            __builder.OpenElement(42, "ol");
            __builder.OpenElement(43, "li");
            __builder.AddContent(44, 
#nullable restore
#line 63 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                         Recipe.instructions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    \n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "jumbotron ingredients");
            __builder.AddMarkupContent(50, "<h2 class=\"mb-5\">Needed ingredients</h2>\n                ");
            __builder.OpenElement(51, "ul");
#nullable restore
#line 72 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                     foreach(Ingredient ingredient in ingredients)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "li");
            __builder.AddAttribute(53, "class", "my-3");
            __builder.AddContent(54, 
#nullable restore
#line 74 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                                          ingredient.number

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " ");
            __builder.AddContent(56, 
#nullable restore
#line 74 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                                                             ingredient.unitType

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " of ");
            __builder.AddContent(58, 
#nullable restore
#line 74 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                                                                                     ingredient.ingredientName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\maria\OneDrive\Documents\Rider\SEP3\SEP3\Blazor\Pages\RecipeView.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Recipe Recipe { get; set; }
    public IList<Ingredient> ingredients { get; set; } 



    protected override async Task OnInitializedAsync() {
        if (Id != 0) {
            Recipe = RecipeService.Recipes.FirstOrDefault(p => p.recipeId == Id);
            Console.WriteLine(1);
            await IngredientsService.GetIngredientsAsync(Id);
            ingredients = IngredientsService.Ingredients;
        }
    }

    private void HandleInvalidSubmit() {
        Console.WriteLine("Invalid");
    }

    private void HandleValidSubmit() {
        NavigationManager.NavigateTo("/ordersuccess");
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
