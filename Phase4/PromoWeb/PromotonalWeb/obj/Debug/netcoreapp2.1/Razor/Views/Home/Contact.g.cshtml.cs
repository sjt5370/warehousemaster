#pragma checksum "C:\Users\johnf\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\PromoWeb\PromotonalWeb\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edc1571f445b003c2417d71edd872a4b8303ebae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\johnf\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\PromoWeb\PromotonalWeb\Views\_ViewImports.cshtml"
using PromotonalWeb;

#line default
#line hidden
#line 2 "C:\Users\johnf\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\PromoWeb\PromotonalWeb\Views\_ViewImports.cshtml"
using PromotonalWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc1571f445b003c2417d71edd872a4b8303ebae", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"047149e70ca948e03e9334fb0c05104d259c047d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\johnf\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\PromoWeb\PromotonalWeb\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Support";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\Users\johnf\Source\Repos\NicholasTHall\cmpsc488CapstoneProjectGroupBirdDog\Phase4\PromoWeb\PromotonalWeb\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 1512, true);
            WriteLiteral(@"</h1>

<div id=""androidDoc"">
    <h3>Using the Android Application</h3>
    <p>When the app is opened you will see the login page. Users can login using their account credientials created on the desktop application.  Depending on the user's account type, one of two screens will be displayed.</p>
    <p>
        If the User is a Picker, they will see the picking homescreen.  From here, they can click next pallet to get a new pallet from the database.  This will open a new screen displaying the details of the new pallet.
        Products are sorted by their picking priority, so Pickers should pick the products from top to bottom.  Tapping on the priority headings will collapse all products of that priority for easier viewing. If more details are needed, Pickers can tap a product to see the product description and manufacturer.
        When a Picker picks a product, they should tap the scan button to read the barcode. This will confirm that they have picked the correct product.  At any point a Picker can");
            WriteLiteral(@" place the pallet on hold.  This will return the Picker to the picking homescreen and return all picked products back to the shelf.  When they have scanned all products, the finish order button will be activated. Upon clicking the button they will be returned to the picking homescreen.
    </p>
    <p>If the User is a Stocker,</p>
</div>
<div id=""desktopDoc"">
    <h3>Using the Desktop Application</h3>
</div>
<div id=""siteDoc"">
    <h3>Using the Ordering Website</h3>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
