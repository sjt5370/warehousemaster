#pragma checksum "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5982e901ad87d8828363764d625c42779b69f52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderItemsAsync), @"mvc.1.0.view", @"/Views/Home/OrderItemsAsync.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OrderItemsAsync.cshtml", typeof(AspNetCore.Views_Home_OrderItemsAsync))]
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
#line 1 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest;

#line default
#line hidden
#line 2 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5982e901ad87d8828363764d625c42779b69f52", @"/Views/Home/OrderItemsAsync.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0367e1ab19b265a544dc18b55df4c8735f4ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderItemsAsync : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebTest.Models.OrderItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
  
    ViewData["Title"] = "OrderItems";

#line default
#line hidden
            BeginContext(94, 34, true);
            WriteLiteral("\r\n<h2>OrderItems</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1519750d3c4c378a0b63954658ad36", async() => {
                BeginContext(157, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(171, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 45, false);
#line 16 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
           Write(Html.DisplayNameFor(model => model.order_num));

#line default
#line hidden
            EndContext();
            BeginContext(309, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(365, 43, false);
#line 19 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
           Write(Html.DisplayNameFor(model => model.prod_id));

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(464, 44, false);
#line 22 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
           Write(Html.DisplayNameFor(model => model.quantity));

#line default
#line hidden
            EndContext();
            BeginContext(508, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(626, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(675, 44, false);
#line 31 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.order_num));

#line default
#line hidden
            EndContext();
            BeginContext(719, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(775, 42, false);
#line 34 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_id));

#line default
#line hidden
            EndContext();
            BeginContext(817, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(873, 43, false);
#line 37 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
           Write(Html.DisplayFor(modelItem => item.quantity));

#line default
#line hidden
            EndContext();
            BeginContext(916, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(972, 71, false);
#line 40 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Nicholas\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\Ordering Website\WebTest\WebTest\Views\Home\OrderItemsAsync.cshtml"
}

#line default
#line hidden
            BeginContext(1082, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebTest.Models.OrderItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
