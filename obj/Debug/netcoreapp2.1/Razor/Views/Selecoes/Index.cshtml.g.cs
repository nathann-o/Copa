#pragma checksum "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918b0e25e00efec45993a1cc2d0e5fcea13b95fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Selecoes_Index), @"mvc.1.0.view", @"/Views/Selecoes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Selecoes/Index.cshtml", typeof(AspNetCore.Views_Selecoes_Index))]
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
#line 1 "C:\Users\Nathann\source\repos\Copa\Views\_ViewImports.cshtml"
using Copa;

#line default
#line hidden
#line 2 "C:\Users\Nathann\source\repos\Copa\Views\_ViewImports.cshtml"
using Copa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918b0e25e00efec45993a1cc2d0e5fcea13b95fc", @"/Views/Selecoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15eb937d7ce6c7d1f28e496d0e78e641db9ba82", @"/Views/_ViewImports.cshtml")]
    public class Views_Selecoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Copa.Models.Selecao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarSelecao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirSelecao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
  
    ViewData["Title"] = "Listagem";

#line default
#line hidden
            BeginContext(89, 13, true);
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(102, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad8f577af7be4d88befdc1e618a9a2b3", async() => {
                BeginContext(131, 49, true);
                WriteLiteral("-> Adicione as seleções participantes do torneio ");
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
            BeginContext(184, 195, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Classificados\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(428, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(489, 39, false);
#line 28 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(528, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(595, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a9d88f4ca654a04a27f06c9867a62df", async() => {
                BeginContext(657, 6, true);
                WriteLiteral("Apagar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
                                                     WriteLiteral(item.SelecaoID);

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
            BeginContext(667, 46, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(724, 435, true);
            WriteLiteral(@"    </tbody>
</table>


<table>
    <thead>
        <tr>
            <th>Oitavas</th>
            <th>Quartas</th>
            <th>Semi</th>
            <th>Final</th>
            <th></th>
            <th></th>
            <th></th>
            <th>Final</th>
            <th>Semi</th>
            <th>Quartas</th>
            <th>Oitavas</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
            EndContext();
            BeginContext(1160, 41, false);
#line 58 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 230, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(1432, 41, false);
#line 68 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 75, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(1549, 41, false);
#line 72 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 184, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(1775, 41, false);
#line 80 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 75, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1892, 41, false);
#line 84 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 230, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(2164, 41, false);
#line 94 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 98, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(2304, 41, false);
#line 99 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 138, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(2484, 41, false);
#line 105 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(2525, 98, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(2624, 41, false);
#line 110 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(2665, 230, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(2896, 41, false);
#line 120 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(2937, 75, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(3013, 41, false);
#line 124 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(3054, 184, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(3239, 41, false);
#line 132 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(3280, 75, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(3356, 41, false);
#line 136 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(3397, 237, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <th>Campeão</th>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(3635, 41, false);
#line 146 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(3676, 121, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(3798, 41, false);
#line 152 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(3839, 46, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(3886, 41, false);
#line 154 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(3927, 46, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(3974, 41, false);
#line 156 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(4015, 121, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(4137, 41, false);
#line 162 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(4178, 230, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(4409, 41, false);
#line 172 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(4450, 75, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(4526, 41, false);
#line 176 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(4567, 184, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(4752, 41, false);
#line 184 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(4793, 75, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(4869, 41, false);
#line 188 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(4910, 230, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(5141, 41, false);
#line 198 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(5182, 98, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(5281, 41, false);
#line 203 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(5322, 138, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(5461, 41, false);
#line 209 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(5502, 98, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(5601, 41, false);
#line 214 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(5642, 230, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(5873, 41, false);
#line 224 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(5914, 75, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(5990, 41, false);
#line 228 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(6031, 184, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(6216, 41, false);
#line 236 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(6257, 75, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(6333, 41, false);
#line 240 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(6374, 230, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(6605, 41, false);
#line 250 "C:\Users\Nathann\source\repos\Copa\Views\Selecoes\Index.cshtml"
           Write(Html.DropDownList("SelecaoId", "Seleção"));

#line default
#line hidden
            EndContext();
            BeginContext(6646, 46, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Copa.Models.Selecao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
