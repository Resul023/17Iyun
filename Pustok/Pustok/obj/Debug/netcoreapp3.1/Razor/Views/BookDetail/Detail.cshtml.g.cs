#pragma checksum "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528adab2d217a8eda5112745c740c7e2c4ff3804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookDetail_Detail), @"mvc.1.0.view", @"/Views/BookDetail/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528adab2d217a8eda5112745c740c7e2c4ff3804", @"/Views/BookDetail/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8d2ec98bcfff3ea842b43546fdef4a1a134b952", @"/Views/_ViewImports.cshtml")]
    public class Views_BookDetail_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://demo.hasthemes.com/pustok-preview/pustok/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt--15 site-form "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb-section"">
    <h2 class=""sr-only"">Site Breadcrumb</h2>
    <div class=""container"">
        <div class=""breadcrumb-contents"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                    <li class=""breadcrumb-item active"">Product Details</li>
                </ol>
            </nav>
        </div>
    </div>
</section>
<main class=""inner-page-sec-padding-bottom"">
    <div class=""container"">
        <div class=""row  mb--60"">
            <div class=""col-lg-5 mb--30"">
                <!-- Product Details Slider Big Image-->
                <div class=""product-details-slider sb-slick-slider arrow-type-two"" data-slick-setting='{
              ""slidesToShow"": 1,
              ""arrows"": false,
              ""fade"": true,
              ""draggable"": false,
              ""swipe"": false,
              ""asNavFor"": "".product-slider-nav""
           ");
            WriteLiteral("   }\'>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                     foreach (var item in Model.Book.BookImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-slide\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "528adab2d217a8eda5112745c740c7e2c4ff38046356", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1283, "~/upload/book/", 1283, 14, true);
#nullable restore
#line 36 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
AddHtmlAttributeValue("", 1297, item.Name, 1297, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <!-- Product Details Slider Nav -->
                <div class=""mt--30 product-slider-nav sb-slick-slider arrow-type-two"" data-slick-setting='{
            ""infinite"":true,
              ""autoplay"": true,
              ""autoplaySpeed"": 8000,
              ""slidesToShow"": 4,
              ""arrows"": true,
              ""prevArrow"":{""buttonClass"": ""slick-prev"",""iconClass"":""fa fa-chevron-left""},
              ""nextArrow"":{""buttonClass"": ""slick-next"",""iconClass"":""fa fa-chevron-right""},
              ""asNavFor"": "".product-details-slider"",
              ""focusOnSelect"": true
              }'>
");
#nullable restore
#line 53 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                     foreach (var item in Model.Book.BookImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-slide\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "528adab2d217a8eda5112745c740c7e2c4ff38049232", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2195, "~/upload/book/", 2195, 14, true);
#nullable restore
#line 56 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
AddHtmlAttributeValue("", 2209, item.Name, 2209, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                         </div>\r\n");
#nullable restore
#line 58 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-lg-7"">
                <div class=""product-details-info pl-lg--30 "">
                    <p class=""tag-block"">Tags: <a href=""#"">Movado</a>, <a href=""#"">Omega</a></p>
                    <h3 class=""product-title"">");
#nullable restore
#line 65 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                         Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>Author: <a href=\"#\" class=\"list-value font-weight-bold\"> ");
#nullable restore
#line 67 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                                                Write(Model.Book.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li>Genre: <span class=\"list-value\"> ");
#nullable restore
#line 68 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                        Write(Model.Book.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n\r\n                        <li>Availability: <span class=\"list-value\"> ");
#nullable restore
#line 70 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                                Write(@Model.Book.IsAvailable?"In Stock":"Out of stock");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ul>\r\n                    <div class=\"price-block\">\r\n");
#nullable restore
#line 73 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                         if (Model.Book.DiscountPercent > 0)
                        {
                            double discountedPrice = Model.Book.SalePrice * (100 - Model.Book.DiscountPercent) / 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 76 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                            Write(discountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <del class=\"price-old\">");
#nullable restore
#line 77 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                              Write(Model.Book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 78 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                    Write(Model.Book.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 79 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 82 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                            Write(Model.Book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 83 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"rating-widget\">\r\n                        <div class=\"rating-block\">\r\n");
#nullable restore
#line 87 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                             for (int i = 1; i <= 5; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span");
            BeginWriteAttribute("class", " class=\"", 3973, "\"", 4040, 2);
            WriteAttributeValue("", 3981, "ion-android-star-outline", 3981, 24, true);
#nullable restore
#line 89 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
WriteAttributeValue(" ", 4005, i<=Model.Book.Rate?"star_on":"", 4006, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n");
#nullable restore
#line 90 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""review-widget"">
                            <a href=""#"">(1 Reviews)</a> <span>|</span>
                            <a href=""#"">Write a review</a>
                        </div>
                    </div>
                    <article class=""product-details-article"">
                        <h4 class=""sr-only"">Product Summery</h4>
                        <p>
                            Long printed dress with thin adjustable straps. V-neckline and wiring under the Dust
                            with ruffles at the bottom of the
                            dress.
                        </p>
                    </article>
                    <div class=""add-to-cart-row"">
                        <div class=""count-input-block"">
                            <span class=""widget-label"">Qty</span>
                            <input type=""number"" class=""form-control text-center"" value=""1"">
                        </div>
           ");
            WriteLiteral(@"             <div class=""add-cart-btn"">
                            <a href=""#"" class=""btn btn-outlined--primary"">
                                <span class=""plus-icon"">+</span>Add to
                                Cart
                            </a>
                        </div>
                    </div>
                    <div class=""compare-wishlist-row"">
                        <a href=""#"" class=""add-link""><i class=""fas fa-heart""></i>Add to Wish List</a>
                        <a href=""#"" class=""add-link""><i class=""fas fa-random""></i>Add to Compare</a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""sb-custom-tab review-tab section-padding"">
            <ul class=""nav nav-tabs nav-style-2"" id=""myTab2"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""tab1"" data-toggle=""tab"" href=""#tab-1"" role=""tab""
                       aria-controls=""tab-1"" aria-selected=""true"">
    ");
            WriteLiteral(@"                    DESCRIPTION
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""tab2"" data-toggle=""tab"" href=""#tab-2"" role=""tab""
                       aria-controls=""tab-2"" aria-selected=""true"">
                        REVIEWS (1)
                    </a>
                </li>
            </ul>
            <div class=""tab-content space-db--20"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""tab-1"" role=""tabpanel"" aria-labelledby=""tab1"">
                    <article class=""review-article"">
                        <h1 class=""sr-only"">Tab Article</h1>
                        <p>
                           ");
#nullable restore
#line 146 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                      Write(Model.Book.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </article>
                </div>
                <div class=""tab-pane fade"" id=""tab-2"" role=""tabpanel"" aria-labelledby=""tab2"">
                    <div class=""review-wrapper"">
                        <h2 class=""title-lg mb--20"">1 REVIEW FOR AUCTOR GRAVIDA ENIM</h2>
                        <div class=""review-comment mb--20"">
                            <div class=""avatar"">
                                <img src=""image/icon/author-logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 7389, "\"", 7395, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""text"">
                                <div class=""rating-block mb--15"">
                                    <span class=""ion-android-star-outline star_on""></span>
                                    <span class=""ion-android-star-outline star_on""></span>
                                    <span class=""ion-android-star-outline star_on""></span>
                                    <span class=""ion-android-star-outline""></span>
                                    <span class=""ion-android-star-outline""></span>
                                </div>
                                <h6 class=""author"">
                                    ADMIN – <span class=""font-weight-400"">March 23, 2015</span>
                                </h6>
                                <p>
                                    Lorem et placerat vestibulum, metus nisi posuere nisl, in accumsan elit odio
                                    quis mi.
");
            WriteLiteral(@"                                </p>
                            </div>
                        </div>
                        <h2 class=""title-lg mb--20 pt--15"">ADD A REVIEW</h2>
                        <div class=""rating-row pt-2"">
                            <p class=""d-block"">Your Rating</p>
                            <span class=""rating-widget-block"">
                                <input type=""radio"" name=""star"" id=""star1"">
                                <label for=""star1""></label>
                                <input type=""radio"" name=""star"" id=""star2"">
                                <label for=""star2""></label>
                                <input type=""radio"" name=""star"" id=""star3"">
                                <label for=""star3""></label>
                                <input type=""radio"" name=""star"" id=""star4"">
                                <label for=""star4""></label>
                                <input type=""radio"" name=""star"" id=""star5"">
                            ");
            WriteLiteral("    <label for=\"star5\"></label>\r\n                            </span>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "528adab2d217a8eda5112745c740c7e2c4ff380422515", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-12"">
                                        <div class=""form-group"">
                                            <label for=""message"">Comment</label>
                                            <textarea name=""message"" id=""message"" cols=""30"" rows=""10""
                                                      class=""form-control""></textarea>
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label for=""name"">Name *</label>
                                            <input type=""text"" id=""name"" class=""form-control"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                              ");
                WriteLiteral(@"          <div class=""form-group"">
                                            <label for=""email"">Email *</label>
                                            <input type=""text"" id=""email"" class=""form-control"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label for=""website"">Website</label>
                                            <input type=""text"" id=""website"" class=""form-control"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""submit-btn"">
                                            <a href=""#"" class=""btn btn-black"">Post Comment</a>
                                        </div>
                                    </div>
      ");
                WriteLiteral("                          </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- <div class=""tab-product-details"">
          <div class=""brand"">
            <img src=""image/others/review-tab-product-details.jpg"" alt="""">
          </div>
          <h5 class=""meta"">Reference <span class=""small-text"">demo_5</span></h5>
          <h5 class=""meta"">In stock <span class=""small-text"">297 Items</span></h5>
          <section class=""product-features"">
            <h3 class=""title"">Data sheet</h3>
            <dl class=""data-sheet"">
              <dt class=""name"">Compositions</dt>
              <dd class=""value"">Viscose</dd>
              <dt class=""name"">Styles</dt>
              <dd class=""value"">Casual</dd>
              <dt class=""name"">Properties</dt>
              <dd class=""value"">Maxi Dress</dd>
            </dl>
          </section>
        </div> -->
    </div>
    <!--=================================
        RELATED PRODUCTS BOOKS
   ");
            WriteLiteral(" ===================================== -->\r\n    <section");
            BeginWriteAttribute("class", " class=\"", 12830, "\"", 12838, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""container"">
            <div class=""section-title section-title--bordered"">
                <h2>RELATED PRODUCTS</h2>
            </div>
            <div class=""product-slider sb-slick-slider slider-border-single-row"" data-slick-setting='{
                ""autoplay"": true,
                ""autoplaySpeed"": 8000,
                ""slidesToShow"": 4,
                ""dots"":true
            }' data-slick-responsive='[
                {""breakpoint"":1200, ""settings"": {""slidesToShow"": 4} },
                {""breakpoint"":992, ""settings"": {""slidesToShow"": 3} },
                {""breakpoint"":768, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} }
            ]'>
");
#nullable restore
#line 266 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                 foreach (var book in Model.RelatedBooks)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-slide\">\r\n                        <div class=\"product-card\">\r\n                            <div class=\"product-header\">\r\n                                <a href=\"#\" class=\"author\">\r\n                                    ");
#nullable restore
#line 272 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                               Write(book.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                                <h3><a href=\"product-details.html\">");
#nullable restore
#line 274 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                              Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            </div>\r\n                            <div class=\"product-card--body\">\r\n                                <div class=\"card-image\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "528adab2d217a8eda5112745c740c7e2c4ff380429644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 14273, "~/upload/book/", 14273, 14, true);
#nullable restore
#line 278 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
AddHtmlAttributeValue("", 14287, book.BookImages.FirstOrDefault(x=>x.PosterStatus==true)?.Name, 14287, 62, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"hover-contents\">\r\n                                        <a href=\"product-details.html\" class=\"hover-image\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "528adab2d217a8eda5112745c740c7e2c4ff380431487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 14573, "~/upload/book/", 14573, 14, true);
#nullable restore
#line 281 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
AddHtmlAttributeValue("", 14587, book.BookImages.FirstOrDefault(x=>x.PosterStatus==false)?.Name, 14587, 63, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <div class=""hover-btns"">
                                            <a href=""cart.html"" class=""single-btn"">
                                                <i class=""fas fa-shopping-basket""></i>
                                            </a>
                                            <a href=""wishlist.html"" class=""single-btn"">
                                                <i class=""fas fa-heart""></i>
                                            </a>
                                            <a href=""compare.html"" class=""single-btn"">
                                                <i class=""fas fa-random""></i>
                                            </a>
                                            <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                               class=""single-btn"">
                                                <i class=""fas fa-eye""></i>
      ");
            WriteLiteral("                                      </a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"price-block\">\r\n");
#nullable restore
#line 301 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                     if (Model.Book.DiscountPercent > 0)
                                    {
                                        double discountedPrice = Model.Book.SalePrice * (100 - Model.Book.DiscountPercent) / 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"price\">£");
#nullable restore
#line 304 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                        Write(discountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <del class=\"price-old\">");
#nullable restore
#line 305 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                          Write(Model.Book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                        <span class=\"price-discount\">");
#nullable restore
#line 306 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                                Write(Model.Book.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 307 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"price\">£");
#nullable restore
#line 310 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                                        Write(Model.Book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 311 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 316 "C:\Users\Resul023\Desktop\asdas\17Iyun\Pustok\Pustok\Views\BookDetail\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- Modal -->\r\n    \r\n</main>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
