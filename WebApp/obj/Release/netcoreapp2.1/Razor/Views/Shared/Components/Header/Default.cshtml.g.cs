#pragma checksum "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e7e16626befafd8b5b881f435edd9dec2529548"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
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
#line 1 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e7e16626befafd8b5b881f435edd9dec2529548", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db46d8d3b5ca74f3e9c90eca25b2885d25d72ba5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 262, true);
            WriteLiteral(@"
<header>
    <nav id=""main_nav"">
        <div class=""container"">
            <div class=""row no-gutters "">

                <!-- logo part begins -->
                <div class=""col-lg-2"">
                    <div class=""logo"">
                        ");
            EndContext();
            BeginContext(276, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01a89aea0623421a94c9d86ab2dd204e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 286, "~/img/", 286, 6, true);
#line 11 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 292, Model.Logo, 292, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(312, 865, true);
            WriteLiteral(@"
                    </div>
                    <i class=""fas fa-bars fa-2x d-none""></i>
                </div>
                <!-- logo part ends -->
                <!-- navigation part begins -->
                <div class=""col-lg-8 col-6 sidebar"">
                    <div class=""navigator"">
                        <div class=""headers"">
                            <i class=""fas fa-window-close fa-2x d-none""></i>
                            <ul class=""margin-left"">
                                <li class=""main"">
                                    <div class=""header"">
                                        <a class=""activeelement"">HOME</a>
                                    </div>
                                    <div class=""content"">
                                        <ul>
                                            <li>");
            EndContext();
            BeginContext(1177, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33b914c662b745728f21bef845b7a9ae", async() => {
                BeginContext(1221, 9, true);
                WriteLiteral("Main Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1234, 4569, true);
            WriteLiteral(@"</li>
                                            <li><a href="""">Grid Home</a></li>
                                            <li><a href="""">Flower Shop</a></li>
                                            <li><a href="""">Animated Slider</a></li>
                                            <li><a href="""">Metro Showcase</a></li>
                                            <li><a href="""">Carousel Showcase</a></li>
                                            <li><a href="""">Landing</a></li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>PAGES</a>
                                    </div>
                                    <div class=""content"">
                                        <ul>
                                            <li><a href="""">About us</a></li>
    ");
            WriteLiteral(@"                                        <li><a href="""">FAQ Page</a></li>
                                            <li><a href="""">Contact Us</a></li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>SHOP</a>
                                    </div>
                                    <div class=""content"">
                                        <ul class=""subss"">
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Product Types</h2>
                                                </div>
                                                <div class=""subcontent"">
                                                    <ul>
               ");
            WriteLiteral(@"                                         <li><a href=""orange_amaryllis.html"">Standart Product</a></li>
                                                        <li><a href="""">Grouped Product</a></li>
                                                        <li><a href="""">Variable Product</a></li>
                                                        <li><a href="""">Virtual Product</a></li>
                                                        <li><a href="""">External Product</a></li>
                                                        <li><a href="""">Downloadable Product</a></li>
                                                        <li><a href="""">On Sale Product</a></li>
                                                        <li><a href="""">Out Of Stock Product</a></li>
                                                        <li><a href="""">New Product</a></li>
                                                    </ul>
                                                </div>
                     ");
            WriteLiteral(@"                       </li>
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Shop Pages</h2>
                                                </div>
                                                <div class=""subcontent"">
                                                    <ul>
                                                        <li><a href="""">My Account</a></li>
                                                        <li><a href="""">Cart</a></li>
                                                        <li><a href="""">Checkout</a></li>
                                                        <li><a href="""">Orders</a></li>
                                                        <li><a href="""">Downloads</a></li>
                                                    </ul>
                                                </div>
                                   ");
            WriteLiteral(@"         </li>
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Shop Types</h2>
                                                </div>
                                                <div class=""subcontent"">
                                                    <ul>
                                                        <li>");
            EndContext();
            BeginContext(5803, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b34ec6cdf83a4622bdd9ebaec78b30ab", async() => {
                BeginContext(5850, 12, true);
                WriteLiteral("Product List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5866, 4857, true);
            WriteLiteral(@"</li>
                                                        <li><a href="""">Without Sidebar</a></li>
                                                        <li><a href="""">With Category Filter</a></li>
                                                        <li><a href="""">With Ordering Filter</a></li>
                                                        <li><a href="""">Shop Carousel</a></li>
                                                        <li><a href="""">Product Categories</a></li>
                                                        <li><a href="""">Single Category</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                            <li class=""subs"">
                                                <div class=""subheader"">
                                                    <h2>Shop Layouts</h2>
                                               ");
            WriteLiteral(@" </div>
                                                <div class=""subcontent"">
                                                    <ul>
                                                        <li><a href="""">Two Columns Grid</a></li>
                                                        <li><a href="""">Three Columns Grid</a></li>
                                                        <li><a href="""">Four Columns Grid</a></li>
                                                        <li><a href="""">Four Columns Wide</a></li>
                                                        <li><a href="""">Five Columns Wide</a></li>
                                                        <li><a href="""">Six Columns Wide</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                <");
            WriteLiteral(@"/li>
                                <li class=""main"">
                                    <div class=""header"">
                                        <a>PORTFOLIO</a>
                                    </div>
                                    <div class=""content"">
                                        <ul>
                                            <li><a href="""">Standart</a></li>
                                            <li><a href="""">Gallery</a></li>
                                            <li><a href="""">Masonry</a></li>
                                            <li class=""rightarrow"">
                                                <a href="""">
                                                    Portfolio Layouts <i class=""fa fa-angle-right""></i>
                                                </a>
                                                <div class=""rightarrowinfo"">
                                                    <ul>
                                             ");
            WriteLiteral(@"           <li><a href="""">Two Columns</a></li>
                                                        <li><a href="""">Three Columns</a></li>
                                                        <li><a href="""">Four Columns</a></li>
                                                        <li><a href="""">Four Columns Wide</a></li>
                                                        <li><a href="""">Five Columns Wide</a></li>
                                                    </ul>
                                                </div>

                                            </li>
                                            <li class=""rightarrow"">
                                                <a href="""">
                                                    Portfolio Single <i class=""fa fa-angle-right""></i>
                                                </a>
                                                <div class=""rightarrowinfo"">
                                                    <ul");
            WriteLiteral(@">
                                                        <li><a href=""a"">Small Images</a></li>
                                                        <li><a href="""">Small Slider</a></li>
                                                        <li><a href="""">Big Images</a></li>
                                                        <li><a href="""">Big Slider</a></li>
                                                        <li><a href="""">Gallery</a></li>
                                                    </ul>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
");
            EndContext();
#line 163 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                 if (User.Identity.IsAuthenticated) {

#line default
#line hidden
            BeginContext(10794, 118, true);
            WriteLiteral("                                    <li class=\"main\">\r\n                                        <div class=\"header\"><a>");
            EndContext();
            BeginContext(10913, 20, false);
#line 165 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                                          Write(ViewBag.UserFullname);

#line default
#line hidden
            EndContext();
            BeginContext(10933, 73, true);
            WriteLiteral("</a></div>\r\n                                        <div class=\"content\">");
            EndContext();
            BeginContext(11006, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89b11c3052914c28965a3b29610776f0", async() => {
                BeginContext(11055, 7, true);
                WriteLiteral("Log Out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11066, 51, true);
            WriteLiteral("</div>\r\n                                    </li>\r\n");
            EndContext();
#line 168 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                }
                                else {

#line default
#line hidden
            BeginContext(11192, 235, true);
            WriteLiteral("                                    <li class=\"login\" style=\"margin-left:40px;float:left;font-family:\'Montserrat\',sans-serif;font-size:15px;margin-top:30px;cursor:pointer\">\r\n                                        <div class=\"headerx\">");
            EndContext();
            BeginContext(11427, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d650bd491ef7400a91ff76d396bc4ee3", async() => {
                BeginContext(11494, 6, true);
                WriteLiteral("LOG IN");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11504, 51, true);
            WriteLiteral("</div>\r\n                                    </li>\r\n");
            EndContext();
#line 173 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                    }

#line default
#line hidden
            BeginContext(11594, 1072, true);
            WriteLiteral(@"
                            </ul>

                        </div>
                    </div>
                </div>
                <!-- navigation part ends -->
                <!-- two little icon part begins -->
                <div class=""col-lg-2"">
                    <div class=""icons"">
                        <div class=""search"">
                            <span><i class=""fas fa-search searchicon""></i></span>
                            <div class=""search-box d-none"">
                                <input type=""text"" placeholder=""Search"" id=""search-box"">
                                <a href=""""><i class=""fas fa-search""></i></a>
                            </div>
                        </div>
                        <div class=""cartdiv"">
                            <a href=""#"" class=""cart"">
                                <span class=""bag-icon"">
                                    <i class=""fas fa-shopping-bag bag"">
                                        <sup>
              ");
            WriteLiteral("                              <p class=\"amount\">");
            EndContext();
            BeginContext(12667, 19, false);
#line 196 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                                         Write(ViewBag.BasketCount);

#line default
#line hidden
            EndContext();
            BeginContext(12686, 219, true);
            WriteLiteral("</p>\r\n                                        </sup>\r\n                                    </i>\r\n                                </span><span class=\"total\">\r\n                                    CART(<span class=\"price\">$");
            EndContext();
            BeginContext(12906, 19, false);
#line 200 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                                         Write(ViewBag.BasketTotal);

#line default
#line hidden
            EndContext();
            BeginContext(12925, 353, true);
            WriteLiteral(@"</span>)
                                </span>
                            </a>

                            <div class=""cart-dropdown"" style=""display: none;"">
                                <!-- <p class=""text-center no-product"" style=""display: none;"">No products in the cart</p> -->
                                <div class=""cart-header"">
");
            EndContext();
            BeginContext(13352, 362, true);
            WriteLiteral(@"                                </div>
                                <div class=""cart-bottom"">
                                    <div class=""subtotal-holder"">
                                        <span class=""total"">TOTAL:</span>
                                        <span class=""amount text-right"">
                                            <p>");
            EndContext();
            BeginContext(13715, 19, false);
#line 213 "C:\Users\Kanan\Desktop\WebApplication\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                          Write(ViewBag.BasketTotal);

#line default
#line hidden
            EndContext();
            BeginContext(13734, 766, true);
            WriteLiteral(@" $</p>
                                        </span>
                                    </div>
                                    <div class=""cart-buttons"">
                                        <input type=""submit"" value=""VIEW CART"" class=""button view-cart"">
                                        <input type=""submit"" value=""CHECKOUT"" class=""button checkout"">
                                    </div>

                                </div>
                            </div>
                        </div>


                        <span><i class=""fas fa-bars bar""></i></span>
                    </div>
                </div>

                <!-- two little icon part ends -->
            </div>
        </div>
    </nav>
</header>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data> Html { get; private set; }
    }
}
#pragma warning restore 1591
