#pragma checksum "C:\Users\dtame\source\repos\WandaPlusTv\WandaPlusTv.Flix\Views\Home\Video.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dc3c0c3ddd9ce4429349b0242fd33a3b6fbfd61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Video), @"mvc.1.0.view", @"/Views/Home/Video.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Video.cshtml", typeof(AspNetCore.Views_Home_Video))]
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
#line 1 "C:\Users\dtame\source\repos\WandaPlusTv\WandaPlusTv.Flix\Views\_ViewImports.cshtml"
using WandaPlusTv.Flix;

#line default
#line hidden
#line 2 "C:\Users\dtame\source\repos\WandaPlusTv\WandaPlusTv.Flix\Views\_ViewImports.cshtml"
using WandaPlusTv.Flix.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc3c0c3ddd9ce4429349b0242fd33a3b6fbfd61", @"/Views/Home/Video.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ac7dda549fa466c4c9961ce71f5c018ac05b08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Video : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\dtame\source\repos\WandaPlusTv\WandaPlusTv.Flix\Views\Home\Video.cshtml"
  
    ViewData["Title"] = "Video";

#line default
#line hidden
            BeginContext(43, 170, true);
            WriteLiteral("\r\n<h2>Video</h2>\r\n\r\n<iframe src=\"https://player.vimeo.com/video/382737340\" width=\"640\" height=\"564\" frameborder=\"0\" allow=\"autoplay; fullscreen\" allowfullscreen></iframe>");
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
