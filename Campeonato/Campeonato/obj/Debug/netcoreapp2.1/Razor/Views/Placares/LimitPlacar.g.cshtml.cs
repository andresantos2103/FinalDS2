#pragma checksum "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c530f1f30adbd74dfda374bdfd72eff462f631d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Placares_LimitPlacar), @"mvc.1.0.view", @"/Views/Placares/LimitPlacar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Placares/LimitPlacar.cshtml", typeof(AspNetCore.Views_Placares_LimitPlacar))]
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
#line 1 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\_ViewImports.cshtml"
using Campeonato;

#line default
#line hidden
#line 2 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\_ViewImports.cshtml"
using Campeonato.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c530f1f30adbd74dfda374bdfd72eff462f631d", @"/Views/Placares/LimitPlacar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3c11bc86e3ea3f6211ab85a40190a49828b141", @"/Views/_ViewImports.cshtml")]
    public class Views_Placares_LimitPlacar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Campeonato.Models.Placar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
  
    ViewData["Title"] = "Ranking Global";

#line default
#line hidden
            BeginContext(98, 114, true);
            WriteLiteral("\r\n\r\n<h2>Raking Global</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(213, 43, false);
#line 14 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
           Write(Html.DisplayNameFor(model => model.Jogador));

#line default
#line hidden
            EndContext();
            BeginContext(256, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(312, 47, false);
#line 17 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPontos));

#line default
#line hidden
            EndContext();
            BeginContext(359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(415, 45, false);
#line 20 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
           Write(Html.DisplayNameFor(model => model.HorarioId));

#line default
#line hidden
            EndContext();
            BeginContext(460, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(595, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(656, 47, false);
#line 30 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
               Write(Html.DisplayFor(modelItem => item.Jogador.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(703, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(771, 46, false);
#line 33 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalPontos));

#line default
#line hidden
            EndContext();
            BeginContext(817, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(885, 44, false);
#line 36 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
               Write(Html.DisplayFor(modelItem => item.HorarioId));

#line default
#line hidden
            EndContext();
            BeginContext(929, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Lany\Desktop\Campeonato\Campeonato\Views\Placares\LimitPlacar.cshtml"
        }

#line default
#line hidden
            BeginContext(984, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Campeonato.Models.Placar>> Html { get; private set; }
    }
}
#pragma warning restore 1591