#pragma checksum "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f6a38106573e11d57e6daad0ab69efe3ebc16f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orden_Carrito), @"mvc.1.0.view", @"/Views/Orden/Carrito.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\_ViewImports.cshtml"
using LibreriaProgra;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\_ViewImports.cshtml"
using LibreriaProgra.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f6a38106573e11d57e6daad0ab69efe3ebc16f", @"/Views/Orden/Carrito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72d18f3b78c872c2a0364814e7f140d16b058a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orden_Carrito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibreriaProgra.Models.OrdenDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Proceso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
  
    ViewData["Title"] = "Carrito de Compras";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""catalogue"" class=""catalogue section-bg"">
      <div class=""container"">

        <div class=""section-title"">
          <h2 data-aos=""fade-in"">Carrito de Compras</h2>
          <p data-aos=""fade-in"">Los producto seleccionados apareceran aca</p>
        </div>


    <div class=""row catalogue-container"" data-aos=""fade-up"">

    <table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
                <th scope=""col"">
                    ");
#nullable restore
#line 21 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
               Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
               Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 31 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
     foreach (var item in Model)
	{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
         if (item.Email == @User.Identity.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\PC\Desktop\Progra1\LibreriaProgra\Views\Orden\Carrito.cshtml"
         
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>    \r\n</table>\r\n            <div class=\"form-group\">\r\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f6a38106573e11d57e6daad0ab69efe3ebc16f7533", async() => {
                WriteLiteral("<button class=\"btn btn-primary\">Confirmar</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            </div>
    </section>

<footer id=""footer"">

    <div class=""footer-top"">

      <div class=""container"" data-aos=""fade-up"">

        <div class=""row  justify-content-center"">
          <div class=""col-lg-6"">
            <h3>The One</h3>
            <p>Dirección: Av La Molina, 305 Las gardenias </p>
            <p>Telefono: +51 996644587</p>
          </div>
        </div>

        

        <div class=""social-links"">
          <a href=""#"" class=""twitter""><i class=""bx bxl-twitter""></i></a>
          <a href=""#"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
          <a href=""#"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
          <a href=""#"" class=""google-plus""><i class=""bx bxl-skype""></i></a>
          <a href=""#"" class=""linkedin""><i class=""bx bxl-linkedin""></i></a>
 
    </div>

    <div class=""container footer-bottom clearfix"">
      <div class=""copyright"">
        &copy; Copyright <strong><span> Copyright</span></strong>. Todos los derecho");
            WriteLiteral("s reservador\r\n      </div>\r\n      <div class=\"credits\">\r\n        Diseñado por <a href=\"#\"> The One</a>\r\n      </div>\r\n    </div>\r\n  </footer>\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibreriaProgra.Models.OrdenDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591