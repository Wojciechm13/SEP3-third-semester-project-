#pragma checksum "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01feafc8df4b36c07fc1c5987546f3a0af371aa2"
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
#line 2 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
using System.Numerics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
using Database.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                  newAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                              HandleValidRegister

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                     HandleInvalidRegister

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    \r\n        \r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n            \r\n            ");
                __builder2.AddMarkupContent(10, "<h3 class=\"sectionHeader\">Account information</h3>\r\n            \r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group mx-5");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, "<label>Username:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "placeholder", "Username");
                __builder2.AddAttribute(18, "aria-label", "Username");
                __builder2.AddAttribute(19, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                          newAccount.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.username = __value, newAccount.username))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group mx-5");
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.AddMarkupContent(28, "<label>Password:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "placeholder", "password");
                __builder2.AddAttribute(32, "aria-label", "password");
                __builder2.AddAttribute(33, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                          newAccount.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.password = __value, newAccount.password))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.AddMarkupContent(38, "<small id=\"emailHelp\" class=\"form-text text-muted\">Your password should contain both small and capital letters and at least two digits.</small>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group mx-5");
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.AddMarkupContent(43, "<label>Email:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "placeholder", "Email");
                __builder2.AddAttribute(47, "aria-label", "Email");
                __builder2.AddAttribute(48, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                    newAccount.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.email = __value, newAccount.email))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.AddMarkupContent(53, "<small id=\"emailHelp\" class=\"form-text text-muted\">We\'ll never share your email with anyone else.</small>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n\r\n            \r\n\r\n            ");
                __builder2.AddMarkupContent(55, "<h3 class=\"sectionHeader\">Address information</h3>\r\n\r\n                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group mx-5");
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.AddMarkupContent(59, "<label>Street:</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "placeholder", "Street");
                __builder2.AddAttribute(63, "aria-label", "street");
                __builder2.AddAttribute(64, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                          newAddress.street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAddress.street = __value, newAddress.street))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAddress.street));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group mx-5");
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.AddMarkupContent(73, "<label>City:</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "placeholder", "City");
                __builder2.AddAttribute(77, "aria-label", "City");
                __builder2.AddAttribute(78, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                      newAddress.city

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAddress.city = __value, newAddress.city))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAddress.city));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group mx-5");
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __builder2.AddMarkupContent(87, "<label>Zip code:</label>\r\n                    ");
                __Blazor.Blazor.Pages.Register.TypeInference.CreateInputNumber_0(__builder2, 88, 89, "form-control", 90, "Zip code", 91, "Zip code", 92, "basic-addon1", 93, 
#nullable restore
#line 48 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                                newAddress.zipCode

#line default
#line hidden
#nullable disable
                , 94, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAddress.zipCode = __value, newAddress.zipCode)), 95, () => newAddress.zipCode);
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n\r\n            \r\n            ");
                __builder2.AddMarkupContent(98, "<h3 class=\"sectionHeader\">Payment information</h3>\r\n            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group mx-5");
                __builder2.AddMarkupContent(101, "\r\n                    ");
                __builder2.AddMarkupContent(102, "<p>Card Holder:</p>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(103);
                __builder2.AddAttribute(104, "class", "form-control");
                __builder2.AddAttribute(105, "placeholder", "Card holder");
                __builder2.AddAttribute(106, "aria-label", "Card holder");
                __builder2.AddAttribute(107, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                                    newBankInfo.cardHolder

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBankInfo.cardHolder = __value, newBankInfo.cardHolder))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newBankInfo.cardHolder));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group mx-5");
                __builder2.AddMarkupContent(115, "\r\n                    ");
                __builder2.AddMarkupContent(116, "<p>Card Number:</p>\r\n                    ");
                __Blazor.Blazor.Pages.Register.TypeInference.CreateInputNumber_1(__builder2, 117, 118, "form-control", 119, "Card number", 120, "Card number", 121, "basic-addon1", 122, 
#nullable restore
#line 60 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
                                                                                                                                                      newBankInfo.cardNumber

#line default
#line hidden
#nullable disable
                , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBankInfo.cardNumber = __value, newBankInfo.cardNumber)), 124, () => newBankInfo.cardNumber);
                __builder2.AddMarkupContent(125, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n\r\n\r\n\r\n            \r\n            ");
                __builder2.AddMarkupContent(127, "<p class=\"actions \">\r\n                <button class=\"btn btn-primary registerBtn\" type=\"submit\">Register</button>\r\n            </p>\r\n       \r\n    \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Janni\OneDrive\Skrivebord\SEP3Code\Blazor\Pages\Register.razor"
       

    private string username;
    private string password;
    private string email;
    private string street;
    private string streetNumber;
    private string city;
    private int zipCode;
    private long cardNumber;

    private string errorMessage;

    private Account newAccount = new Account();
    private Address newAddress = new Address();
    private BankInfo newBankInfo = new BankInfo();

    public async Task HandleValidRegister()
    {
        errorMessage = "";
        try
        {
            Console.WriteLine("Trying register");
            await AccountService.Register(newAccount, newAddress, newBankInfo);
        }
        catch (Exception e)
        {
            Console.WriteLine("Register failed");
            errorMessage = e.Message;
        }
    }

    public async Task HandleInvalidRegister()
    {
        Console.WriteLine("Invalid");
    }

    protected override async Task OnInitializedAsync()
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
namespace __Blazor.Blazor.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "aria-label", __arg2);
        __builder.AddAttribute(__seq3, "aria-describedby", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "aria-label", __arg2);
        __builder.AddAttribute(__seq3, "aria-describedby", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
