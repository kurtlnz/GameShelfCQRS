#pragma checksum "/Users/kurt/RiderProjects/GameShelf/GameShelf/Views/BoardGame/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a36e3ec304186e6543a5990d0118173b1a30dab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BoardGame_Index), @"mvc.1.0.view", @"/Views/BoardGame/Index.cshtml")]
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
#line 1 "/Users/kurt/RiderProjects/GameShelf/GameShelf/Views/_ViewImports.cshtml"
using GameShelf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kurt/RiderProjects/GameShelf/GameShelf/Views/_ViewImports.cshtml"
using GameShelf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a36e3ec304186e6543a5990d0118173b1a30dab", @"/Views/BoardGame/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b876c6b403ed8528a0df83f115254d9a153a48", @"/Views/_ViewImports.cshtml")]
    public class Views_BoardGame_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameShelf.ViewModels.BoardGameViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/kurt/RiderProjects/GameShelf/GameShelf/Views/BoardGame/Index.cshtml"
  
    ViewBag.Title = "Board Games";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Board Games</h2>\n<ul>\n");
#nullable restore
#line 10 "/Users/kurt/RiderProjects/GameShelf/GameShelf/Views/BoardGame/Index.cshtml"
     foreach (var game in Model.BoardGames)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 12 "/Users/kurt/RiderProjects/GameShelf/GameShelf/Views/BoardGame/Index.cshtml"
       Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 13 "/Users/kurt/RiderProjects/GameShelf/GameShelf/Views/BoardGame/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameShelf.ViewModels.BoardGameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
