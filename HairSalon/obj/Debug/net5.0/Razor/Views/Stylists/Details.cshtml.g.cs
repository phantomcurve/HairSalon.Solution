#pragma checksum "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a008157242dfd04eefa5130c1e2d4cfea91360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
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
#line 5 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a008157242dfd04eefa5130c1e2d4cfea91360", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Stylist Details</h1>\n<hr />\n<h2>");
#nullable restore
#line 10 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\n<ul>\n");
#nullable restore
#line 12 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
 if (@Model.Clients.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No clients have been added yet!</h3>\n");
#nullable restore
#line 15 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul> \n<h3><i>Client List</i></h3>\n");
#nullable restore
#line 18 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
 foreach (Client client in Model.Clients)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 20 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
 Write(client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 21 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 22 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Add a client", "Create", "Clients"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<hr />\n<p>");
#nullable restore
#line 24 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Edit Stylist", "Edit", new { id = Model.StylistId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 25 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Delete Stylist", "Delete", new { id = Model.StylistId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 26 "/Users/phantom/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Back to Stylists", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
