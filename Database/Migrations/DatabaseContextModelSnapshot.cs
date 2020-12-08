﻿// <auto-generated />
using System;
using Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Database.Model.Account", b =>
                {
                    b.Property<string>("username")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.HasKey("username");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Database.Model.AccountAddress", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.Property<string>("street")
                        .HasColumnType("TEXT");

                    b.HasKey("username", "street");

                    b.HasIndex("street");

                    b.ToTable("AccountAddresses");
                });

            modelBuilder.Entity("Database.Model.AccountBankInfo", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.Property<long>("cardNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("username", "cardNumber");

                    b.HasIndex("cardNumber");

                    b.ToTable("AccountBankInfos");
                });

            modelBuilder.Entity("Database.Model.Address", b =>
                {
                    b.Property<string>("street")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("TEXT");

                    b.Property<int>("zipCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("street");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Database.Model.BankInfo", b =>
                {
                    b.Property<long>("cardNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cardHolder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("cardNumber");

                    b.ToTable("bankInfos");
                });

            modelBuilder.Entity("Database.Model.OrderedShopIngredients", b =>
                {
                    b.Property<int>("osId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ShopIngredientid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("amount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("orderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("totalPrice")
                        .HasColumnType("REAL");

                    b.HasKey("osId");

                    b.HasIndex("ShopIngredientid");

                    b.HasIndex("orderId");

                    b.ToTable("orderedShopIngredients");
                });

            modelBuilder.Entity("Model.Category", b =>
                {
                    b.Property<string>("categoryName")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("categoryName");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Model.Ingredient", b =>
                {
                    b.Property<int>("ingredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ingredientName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<double>("number")
                        .HasColumnType("REAL");

                    b.Property<int?>("recipeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("unitType")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("ingredientId");

                    b.HasIndex("recipeId");

                    b.ToTable("ingredients");
                });

            modelBuilder.Entity("Model.IngredientRecipe", b =>
                {
                    b.Property<int>("ingredientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("recipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ingredientId", "recipeId");

                    b.HasIndex("recipeId");

                    b.ToTable("IngredientRecipes");
                });

            modelBuilder.Entity("Model.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Accountusername")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("orderPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("recipeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("orderId");

                    b.HasIndex("Accountusername");

                    b.HasIndex("recipeId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Model.Recipe", b =>
                {
                    b.Property<int>("recipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoryName")
                        .HasColumnType("TEXT");

                    b.Property<int>("cookingTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("imageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("instructions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("recipeName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("recipeId");

                    b.HasIndex("categoryName");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("Model.RecipeCategory", b =>
                {
                    b.Property<string>("categoryName")
                        .HasColumnType("TEXT");

                    b.Property<int>("recipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("categoryName", "recipeId");

                    b.HasIndex("recipeId");

                    b.ToTable("RecipeCategories");
                });

            modelBuilder.Entity("Model.Shop", b =>
                {
                    b.Property<int>("shopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("shopAddressstreet")
                        .HasColumnType("TEXT");

                    b.Property<string>("shopName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("shopId");

                    b.HasIndex("shopAddressstreet");

                    b.ToTable("shops");
                });

            modelBuilder.Entity("Model.ShopIngredient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("amount")
                        .HasColumnType("REAL");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.Property<int?>("shopId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("unitType")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("shopId");

                    b.ToTable("shopIngredients");
                });

            modelBuilder.Entity("Model.ShopVare", b =>
                {
                    b.Property<int>("shopId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id")
                        .HasColumnType("INTEGER");

                    b.HasKey("shopId", "id");

                    b.HasIndex("id");

                    b.ToTable("ShopVares");
                });

            modelBuilder.Entity("Database.Model.AccountAddress", b =>
                {
                    b.HasOne("Database.Model.Address", "address")
                        .WithMany("AccountAddresses")
                        .HasForeignKey("street")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Model.Account", "account")
                        .WithMany("AccountAddresses")
                        .HasForeignKey("username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");

                    b.Navigation("address");
                });

            modelBuilder.Entity("Database.Model.AccountBankInfo", b =>
                {
                    b.HasOne("Database.Model.BankInfo", "bankInfo")
                        .WithMany("AccountBankInfos")
                        .HasForeignKey("cardNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Model.Account", "account")
                        .WithMany("AccountBankInfos")
                        .HasForeignKey("username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");

                    b.Navigation("bankInfo");
                });

            modelBuilder.Entity("Database.Model.OrderedShopIngredients", b =>
                {
                    b.HasOne("Model.ShopIngredient", "ShopIngredient")
                        .WithMany()
                        .HasForeignKey("ShopIngredientid");

                    b.HasOne("Model.Order", "Order")
                        .WithMany("OrderedShopIngredients")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ShopIngredient");
                });

            modelBuilder.Entity("Model.Ingredient", b =>
                {
                    b.HasOne("Model.Recipe", null)
                        .WithMany("ingredients")
                        .HasForeignKey("recipeId");
                });

            modelBuilder.Entity("Model.IngredientRecipe", b =>
                {
                    b.HasOne("Model.Ingredient", "ingredient")
                        .WithMany("IngredientRecipes")
                        .HasForeignKey("ingredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Recipe", "recipe")
                        .WithMany("IngredientRecipes")
                        .HasForeignKey("recipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ingredient");

                    b.Navigation("recipe");
                });

            modelBuilder.Entity("Model.Order", b =>
                {
                    b.HasOne("Database.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("Accountusername");

                    b.HasOne("Model.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("recipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Model.Recipe", b =>
                {
                    b.HasOne("Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryName");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Model.RecipeCategory", b =>
                {
                    b.HasOne("Model.Category", "category")
                        .WithMany("RecipeCategories")
                        .HasForeignKey("categoryName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Recipe", "recipe")
                        .WithMany("RecipeCategories")
                        .HasForeignKey("recipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("recipe");
                });

            modelBuilder.Entity("Model.Shop", b =>
                {
                    b.HasOne("Database.Model.Address", "shopAddress")
                        .WithMany()
                        .HasForeignKey("shopAddressstreet");

                    b.Navigation("shopAddress");
                });

            modelBuilder.Entity("Model.ShopIngredient", b =>
                {
                    b.HasOne("Model.Shop", null)
                        .WithMany("vares")
                        .HasForeignKey("shopId");
                });

            modelBuilder.Entity("Model.ShopVare", b =>
                {
                    b.HasOne("Model.ShopIngredient", "shopIngredient")
                        .WithMany("shopVares")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shop", "shop")
                        .WithMany("shopVares")
                        .HasForeignKey("shopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("shop");

                    b.Navigation("shopIngredient");
                });

            modelBuilder.Entity("Database.Model.Account", b =>
                {
                    b.Navigation("AccountAddresses");

                    b.Navigation("AccountBankInfos");
                });

            modelBuilder.Entity("Database.Model.Address", b =>
                {
                    b.Navigation("AccountAddresses");
                });

            modelBuilder.Entity("Database.Model.BankInfo", b =>
                {
                    b.Navigation("AccountBankInfos");
                });

            modelBuilder.Entity("Model.Category", b =>
                {
                    b.Navigation("RecipeCategories");
                });

            modelBuilder.Entity("Model.Ingredient", b =>
                {
                    b.Navigation("IngredientRecipes");
                });

            modelBuilder.Entity("Model.Order", b =>
                {
                    b.Navigation("OrderedShopIngredients");
                });

            modelBuilder.Entity("Model.Recipe", b =>
                {
                    b.Navigation("IngredientRecipes");

                    b.Navigation("ingredients");

                    b.Navigation("RecipeCategories");
                });

            modelBuilder.Entity("Model.Shop", b =>
                {
                    b.Navigation("shopVares");

                    b.Navigation("vares");
                });

            modelBuilder.Entity("Model.ShopIngredient", b =>
                {
                    b.Navigation("shopVares");
                });
#pragma warning restore 612, 618
        }
    }
}
