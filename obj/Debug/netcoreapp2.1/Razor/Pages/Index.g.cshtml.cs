#pragma checksum "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2c898f3208ebd17f707fc8c60628eb92c185d55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Entity_Framework_Core_String_Filter_Tips.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Entity_Framework_Core_String_Filter_Tips.Pages.Pages_Index), null)]
namespace Entity_Framework_Core_String_Filter_Tips.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\_ViewImports.cshtml"
using Entity_Framework_Core_String_Filter_Tips;

#line default
#line hidden
#line 3 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\_ViewImports.cshtml"
using Entity_Framework_Core_String_Filter_Tips.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2c898f3208ebd17f707fc8c60628eb92c185d55", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b3f9392d792afa19cfa9898a9d038d3c4c5f70", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 24, true);
            WriteLiteral("<br>\r\n<br>\r\n<br>\r\n<ul>\r\n");
            EndContext();
#line 10 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml"
     foreach (var item in ViewData["Contacts"] as IEnumerable<Contact>)
    {

#line default
#line hidden
            BeginContext(175, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(188, 15, false);
#line 12 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml"
       Write(item.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(203, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 13 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(217, 35, true);
            WriteLiteral("</ul>\r\n\r\n\r\n<br>\r\n<br>\r\n<br>\r\n<ul>\r\n");
            EndContext();
#line 21 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml"
     foreach (var item in ViewData["ContactsLike"] as IEnumerable<Contact>)
    {

#line default
#line hidden
            BeginContext(336, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(349, 15, false);
#line 23 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml"
       Write(item.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(364, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "C:\Users\Jean\Desktop\Entity-Framework-Core-String-Filter-Tips\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(378, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
