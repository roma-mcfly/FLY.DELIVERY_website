#pragma checksum "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4212e9bc432760fa8e9ace7578398fe4b430a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllDishes), @"mvc.1.0.view", @"/Views/Shared/AllDishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllDishes.cshtml", typeof(AspNetCore.Views_Shared_AllDishes))]
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
#line 1 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\_ViewImports.cshtml"
using FoodDelivery.ViewModels;

#line default
#line hidden
#line 2 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\_ViewImports.cshtml"
using FoodDelivery.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4212e9bc432760fa8e9ace7578398fe4b430a4b", @"/Views/Shared/AllDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147cf64a10d930d7b39a7e34c1c186443ec87a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 16px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeliveryCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 105, true);
            WriteLiteral("\r\n<div class=\"card-container\">\r\n    <div class=\"card\" style=\"width:270px\">\r\n        <img class=\"rest-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 118, "\"", 134, 1);
#line 5 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml"
WriteAttributeValue("", 124, Model.img, 124, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 135, "\"", 152, 1);
#line 5 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml"
WriteAttributeValue("", 141, Model.name, 141, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(153, 34, true);
            WriteLiteral(" style=\"width:100%\">\r\n        <h4>");
            EndContext();
            BeginContext(188, 10, false);
#line 6 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml"
       Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(198, 74, true);
            WriteLiteral("</h4>\r\n        <div class=\"rest-desc\">\r\n            <p><span-1>—</span-1> ");
            EndContext();
            BeginContext(273, 15, false);
#line 8 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml"
                             Write(Model.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(288, 40, true);
            WriteLiteral("</p>\r\n            <p><span-1>—</span-1> ");
            EndContext();
            BeginContext(329, 12, false);
#line 9 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml"
                             Write(Model.weight);

#line default
#line hidden
            EndContext();
            BeginContext(341, 101, true);
            WriteLiteral(" гр.</p>\r\n            <p style=\"font-size: 20px; color: red; text-align: center;\"><span-2>—</span-2> ");
            EndContext();
            BeginContext(443, 11, false);
#line 10 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml"
                                                                                      Write(Model.price);

#line default
#line hidden
            EndContext();
            BeginContext(454, 134, true);
            WriteLiteral(" руб. </p>\r\n        </div>\r\n        <div class=\"rest-card-btn\">\r\n            <button class=\"main-btn\" type=\"button\">\r\n                ");
            EndContext();
            BeginContext(588, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4212e9bc432760fa8e9ace7578398fe4b430a4b7611", async() => {
                BeginContext(724, 18, true);
                WriteLiteral("Добавить в корзину");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Shared\AllDishes.cshtml"
                                                                                                                                 WriteLiteral(Model.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(746, 61, true);
            WriteLiteral("\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
