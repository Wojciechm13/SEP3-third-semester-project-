using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Database.Model;
using System.Threading.Tasks;
using Db;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Database.Networking;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Server
{
    class Program
    {
        async static Task Main(string[] args)
        {
            using (DatabaseContext dataContext = new DatabaseContext())
            {
                if (!dataContext.accounts.Any())
                {
                    Console.WriteLine("Trying to seed");
                    Seed(dataContext);
                }
            }
            ServerToJava toJava = new ServerToJava();
            Server server = new Server();
            Thread th1 = new Thread(new ThreadStart(toJava.start));
            Thread th2 = new Thread(new ThreadStart(server.start));
            th1.Start();
            th2.Start();
        }

        private static async Task Seed(DatabaseContext databaseContext)
        {
            Console.WriteLine("Start of seed");
            Address[] addresses = {
                new Address{
                    street = "Solvgade 1, 3tv",
                    city = "Horsens",
                    zipCode = 8700,
                },
            };
            foreach (var address in addresses)
            {
                databaseContext.addresses.Add(address);
            }
            Console.WriteLine("2");
            
            BankInfo[] bankInfos = {
                new BankInfo{
                    cardNumber = 1234123412341234,
                    cardHolder = "Pawel Skrzypkowski"
                },
            };
            foreach (var bankInfo in bankInfos)
            {
                databaseContext.bankInfos.Add(bankInfo);
            }
            Console.WriteLine("3");

            
            Account[] acs = {
                new Account{
                    username = "Jannik",
                    password = "12345",
                    email = "Jannik@viauc.dk",
                },
            };
            
            foreach (var account in acs)
            {
                databaseContext.accounts.Add(account);
            }
            Console.WriteLine("4");
            
            Category[] categories = {
                new Category(){
                    categoryName = "Italian",
                },
                new Category(){
                    categoryName = "Greek",
                },
            };

            foreach (var cat in categories)
            {
                databaseContext.categories.Add(cat);
            }
            Console.WriteLine("5");
            
            
            Recipe[] recipes = {
                new Recipe(){
                    recipeName = "Arrabbiata",
                    recipeId = 1,
                    description = "Arrabbiata sauce, or sugo all'arrabbiata in Italian, is a spicy sauce for pasta made from garlic, tomatoes, and dried red chili peppers cooked in olive oil. The sauce originates from the Lazio region, around Rome. Arrabbiata literally means 'angry' in Italian; the name of the sauce refers to the spiciness of the chili peppers.",
                    instructions = "Sauté the crushed red pepper flakes: Heat the butter (or olive oil) in a large saucepan or deep sauté pan.  Add the crushed red pepper flakes and sauté for about 2 minutes, to help toast and bring out their flavor.\nAdd onion and garlic: Add in the onions and sauté until softened, followed by the garlic.\nAdd tomatoes:  Then add in the cans of whole tomatoes, juices included.  And as they begin to heat up, use a wooden spoon or a potato masher to carefully break up the tomatoes.  (Just wear an apron so that those juices inside of the tomatoes don’t accidentally splatter you!)\nSimmer: Continue heating the sauce until it comes to a simmer.  Then reduce heat to medium (or medium-low) to maintain a low simmer, and let the sauce cook for about 30 minutes, or until it reaches your desired consistency.\nStir in the basil, salt and pepper.  Then taste the sauce, and season with any extra salt, pepper and/or crushed red pepper flakes as needed.\nServe warm.  Or let the sauce cool and then refrigerate it in a sealed container for up to 4 days.",
                    cookingTime = 40,
                    imageName = "Arrabiata.jpg"
                },
                
                new Recipe(){
                    recipeName = "Pizza",
                    recipeId = 2,
                    description = "Pizza, dish of Italian origin consisting of a flattened disk of bread dough topped with some combination of olive oil, oregano, tomato, olives, mozzarella or other cheese, and many other ingredients, baked quickly—usually, in a commercial setting, using a wood-fired oven heated to a very high temperature—and served hot.",
                    instructions = "Add warm water to the bowl of a stand mixer with the dough attachment, and sprinkle the yeast on top of the water.  Give the yeast a quick stir to mix it in with the water.  Then let it sit for 5-10 minute until the yeast is foamy.\nTurn the mixer onto low speed, and add gradually flour, honey, olive oil and salt.  Increase speed to medium-low, and continue mixing the dough for 5 minutes.\nRemove dough from the mixing bowl, and use your hands to shape it into a ball.  Grease the mixing bowl (or a separate bowl) with olive oil or cooking spray, then place the dough ball back in the bowl and cover it with a damp towel.  Place in a warm location (I set mine by the window) and let it rise for 30-45 minutes until the dough has nearly doubled in size.\nPreheat oven to 450 degrees F.  Turn the dough onto a floured surface, and roll the dough into a 12- to 14-inch round for a thick-crusted pizza.  (Or cut the dough in half, and roll it into two 12-inch rounds for two thin crust pizzas.)  Sprinkle a baking sheet or pizza stone evenly with the cornmeal, then place the dough on the baking sheet.\nTop the dough with your desired sauce and toppings.  (And for extra-golden crust, brush the crust with an extra few teaspoons of olive oil or butter.)\nFor thick crust, bake for 16-18 minutes, or until the crust is golden brown and the toppings are melted and cooked.  For the (two) thin crusts, bake for 14-16 minutes, or until the crust is golden brown and the toppings are melted and cooked.\nSlice and serve pizza warm.",
                    cookingTime = 75,
                    imageName = "Pizza.jpeg"
                },
                
                
            };
            foreach (var rec in recipes)
            {
                databaseContext.recipes.Add(rec);
            }
            Console.WriteLine("6");

            Ingredient[] ingredients = {
            new Ingredient(){
                ingredientId = 1,
                ingredientName = "Garlic",
                number = 3,
                unitType = "cloves"
            },
            new Ingredient(){
                ingredientId = 2,
                ingredientName = "Pasta",
                number = 0.5,
                unitType = "kg"
              }
            };

            foreach (var ing in ingredients)
            {
                databaseContext.ingredients.Add(ing);
            }
            Console.WriteLine("8");
            
            databaseContext.SaveChanges();
            
            Shop[] shops = {
                new Shop{
                    shopId = 1,
                    shopName = "Lidl",
                    shopAddress = addresses[0]
                },
            };

            foreach (var shop in shops)
            {
                databaseContext.shops.Add(shop);
            }
            Console.WriteLine("9");
            
            ShopIngredient[] shopIngredients = {
                new ShopIngredient(){
                    id = 1,
                    name = "Garlic",
                    price = 3,
                    amount = 3,
                    unitType = "cloves"
                },
                new ShopIngredient(){
                    id = 2,
                    name = "Pasta",
                    price = 2,
                    amount = 0.2,
                    unitType = "kg"
                },
            };

            foreach (var shoping in shopIngredients)
            {
                databaseContext.shopIngredients.Add(shoping);
            }
            Console.WriteLine("10");

            databaseContext.SaveChanges();
            
            Account steve = await databaseContext.accounts.FirstAsync(s => s.username.Equals("Jannik") );
            Address tek = await databaseContext.addresses.FirstAsync(c => c.street.Equals("Solvgade 1, 3tv"));
            AccountAddress sc = new AccountAddress()
            {
                address = tek,
                account = steve
            };
            
            steve.AccountAddresses = new List<AccountAddress>();
            steve.AccountAddresses.Add(sc);
            databaseContext.Update(steve);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            Account steve2 = await databaseContext.accounts.FirstAsync(s => s.username.Equals("Jannik") );
            BankInfo bankInfo2 = await databaseContext.bankInfos.FirstAsync(c => c.cardNumber == 1234123412341234);
            AccountBankInfo sc2 = new AccountBankInfo()
            {
               account = steve2,
               bankInfo = bankInfo2
            };
            
            steve.AccountBankInfos = new List<AccountBankInfo>();
            steve.AccountBankInfos.Add(sc2);
            databaseContext.Update(steve2);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            //Connecting ingredients with recipes
            
            Recipe steve1 = await databaseContext.recipes.FirstAsync(s => s.recipeId == 1 );
            Ingredient tek1 = await databaseContext.ingredients.FirstAsync(c => c.ingredientId == 1);
            
            IngredientRecipe sc1 = new IngredientRecipe()
            {
                ingredient = tek1,
                recipe = steve1
            };
            
            steve1.IngredientRecipes = new List<IngredientRecipe>();
            steve1.IngredientRecipes.Add(sc1);
            databaseContext.Update(steve1);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            Recipe steve3 = await databaseContext.recipes.FirstAsync(s => s.recipeId == 1 );
            Category bankInfo3 = await databaseContext.categories.FirstAsync(c => c.categoryName.Equals("Italian"));
            
            RecipeCategory sc3 = new RecipeCategory()
            {
                recipe = steve3,
                category = bankInfo3
            };
            
            steve3.RecipeCategories = new List<RecipeCategory>();
            steve3.RecipeCategories.Add(sc3);
            databaseContext.Update(steve3);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            
            //connecting second recipe
            Recipe steve5 = await databaseContext.recipes.FirstAsync(s => s.recipeId == 2 );
            Ingredient tek5 = await databaseContext.ingredients.FirstAsync(c => c.ingredientId == 1);
            
            IngredientRecipe sc5 = new IngredientRecipe()
            {
                ingredient = tek5,
                recipe = steve5
            };
            
            steve5.IngredientRecipes = new List<IngredientRecipe>();
            steve5.IngredientRecipes.Add(sc5);
            databaseContext.Update(steve5);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            //adding second ingredient
            Recipe steve7 = await databaseContext.recipes.FirstAsync(s => s.recipeId == 2 );
            Ingredient tek7 = await databaseContext.ingredients.FirstAsync(c => c.ingredientId == 2);
            
            IngredientRecipe sc7 = new IngredientRecipe()
            {
                ingredient = tek7,
                recipe = steve7
            };

            if (steve7.IngredientRecipes == null)
            {
                steve7.IngredientRecipes = new List<IngredientRecipe>();
            }
            steve7.IngredientRecipes.Add(sc7);
            databaseContext.Update(steve7);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            Recipe steve6 = await databaseContext.recipes.FirstAsync(s => s.recipeId == 2 );
            Category bankInfo6 = await databaseContext.categories.FirstAsync(c => c.categoryName.Equals("Greek"));
            
            RecipeCategory sc6 = new RecipeCategory()
            {
                recipe = steve6,
                category = bankInfo6
            };
            
            steve6.RecipeCategories = new List<RecipeCategory>();
            steve6.RecipeCategories.Add(sc6);
            databaseContext.Update(steve6);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            //shops
            
            
            //adding shopingredients
            Shop shop1 = await databaseContext.shops.FirstAsync(s => s.shopId == 1);
            ShopIngredient shopIngredient1 = await databaseContext.shopIngredients.FirstAsync(c => c.id == 1);
            
            ShopVare ss1 = new ShopVare()
            {
                shop = shop1,
                shopIngredient = shopIngredient1
            };

            if (shop1.shopVares == null)
            {
                shop1.shopVares = new List<ShopVare>();
            }
            shop1.shopVares.Add(ss1);
            databaseContext.Update(shop1);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();
            
            Shop shop2 = await databaseContext.shops.FirstAsync(s => s.shopId == 1);
            ShopIngredient shopIngredient2 = await databaseContext.shopIngredients.FirstAsync(c => c.id == 2);
            
            ShopVare ss2 = new ShopVare()
            {
                shop = shop2,
                shopIngredient = shopIngredient2
            };

            if (shop2.shopVares == null)
            {
                shop2.shopVares = new List<ShopVare>();
            }
            shop2.shopVares.Add(ss2);
            databaseContext.Update(shop2);
            
            // ctx.Set<StudentCourse>().Add(sc); This is an alternative
            await databaseContext.SaveChangesAsync();

            //update categories in recipes
            Recipe recipeUp1 = recipes[0];
            Recipe recipeUp2 = recipes[1];
            List<Category> categoriesUp = await databaseContext.categories.ToListAsync();
            recipeUp1.category = categoriesUp[0];
            recipeUp2.category = categoriesUp[1];
            databaseContext.recipes.Update(recipeUp1);
            databaseContext.recipes.Update(recipeUp2);
            await databaseContext.SaveChangesAsync();
            Console.WriteLine("Finished seeding");
        }
    }
}