#pragma checksum "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01bfd115e3d0986d85eb09296d490c9804af434d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\_ViewImports.cshtml"
using TicketSystem.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\_ViewImports.cshtml"
using TicketSystem.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using TicketSystem.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01bfd115e3d0986d85eb09296d490c9804af434d", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81059fc78e1881e61bae550e048d06bfc0cd398d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64bed5805d1b2d51499daf6b360f649d9a04c61", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
      
        if (@Model.DisplayConfirmAccountLink)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <p>
                This app does not currently have a real email sender registered, see <a href=""https://aka.ms/aspaccountconf"">these docs</a> for how to configure a real email sender.
                Normally this would be emailed: <a id=""confirm-link""");
            BeginWriteAttribute("href", " href=\"", 487, "\"", 521, 1);
#nullable restore
#line 14 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 494, Model.EmailConfirmationUrl, 494, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\r\n            </p>\r\n");
#nullable restore
#line 16 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                Please check your email to confirm your account.\r\n            </p>\r\n");
#nullable restore
#line 22 "C:\Projects\ResumeProjects\TicketSystem\TicketSystem\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591