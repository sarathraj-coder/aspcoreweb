#pragma checksum "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdef3795d8e925ef4e16b9654e14eb565b647135"
// <auto-generated/>
#pragma warning disable 1591
namespace assetRegister.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 4 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
using assetRegister.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
using assetRegister.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 10 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-img");
            __builder.AddAttribute(8, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 13 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                                         product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 16 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, @"<div class=""card-footer"">
        <small class=""text-muted"">
            <button @onclick=""(e => SelectProduct(product.Id))"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                More Info
            </button>
        </small>
    </div>
");
            __builder.CloseElement();
#nullable restore
#line 26 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
#nullable restore
#line 29 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "modal fade");
            __builder.AddAttribute(23, "id", "productModal");
            __builder.AddAttribute(24, "tabindex", "-1");
            __builder.AddAttribute(25, "role", "dialog");
            __builder.AddAttribute(26, "aria-labelledby", "productTitle");
            __builder.AddAttribute(27, "aria-hidden", "true");
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(31, "role", "document");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal-content");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-header");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "h5");
            __builder.AddAttribute(40, "class", "modal-title");
            __builder.AddAttribute(41, "id", "productTitle");
            __builder.AddContent(42, 
#nullable restore
#line 35 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                                           selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-body");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-img");
            __builder.AddAttribute(54, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 42 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                                                         selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "card-body");
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "p");
            __builder.AddAttribute(61, "class", "card-text");
            __builder.AddContent(62, 
#nullable restore
#line 45 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                              selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-footer");
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 50 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                 if (voteCount == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "<span>Be the first to vote!</span> ");
#nullable restore
#line 52 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                   }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "span");
            __builder.AddContent(72, 
#nullable restore
#line 55 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
       voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, " ");
            __builder.AddContent(74, 
#nullable restore
#line 55 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                  voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 55 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                 for (int i = 1; i < 6; i++)
                {
                    var currentStar = i;
                    if (i <= currentRating)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<span class=\"fa fa-star checked\" @onclick=\"(e => SubmitRating(currentStar))\"></span> ");
#nullable restore
#line 61 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                                                                     }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(76, "<span class=\"fa fa-star\" @onclick=\"(e => SubmitRating(currentStar))\"></span>");
#nullable restore
#line 64 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
                                                                            }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 69 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "/Users/sraj/azdevops/netcore/assetRegister/Components/ProductList.razor"
 
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
      selectedProductId = productId;
      selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
      GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
      if(selectedProduct.Ratings == null)
      {
        currentRating = 0;
        voteCount = 0;
      }
      else
      {
        voteCount = selectedProduct.Ratings.Count();
        voteLabel = voteCount > 1 ? "Votes" : "Vote";
        currentRating = selectedProduct.Ratings.Sum() / voteCount;
      }

      System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
      System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
      ProductService.AddRating(selectedProductId, rating);
      SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591