#pragma checksum "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c16108409461b4a44b95c6b1fcc1c555dbbe935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Index), @"mvc.1.0.view", @"/Views/Catalogo/Index.cshtml")]
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
#line 1 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\_ViewImports.cshtml"
using LibreriaProgra;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\_ViewImports.cshtml"
using LibreriaProgra.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c16108409461b4a44b95c6b1fcc1c555dbbe935", @"/Views/Catalogo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d80698b305714f4d15f1862dbb7f8e758987ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibreriaProgra.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
  
    ViewData["Title"] = "Catalogo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""catalogue"" class=""catalogue section-bg"">
      <div class=""container"">

        <div class=""section-title"">
          <h2 data-aos=""fade-in"">Nuestros Libros</h2>
          <p data-aos=""fade-in"">Los mejores libros para agregarlos a su biblioteca</p>
        </div>


    <div class=""row catalogue-container"" data-aos=""fade-up"">

");
#nullable restore
#line 17 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
     foreach (var item in Model)



	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"col-lg-4 catalogue-item filter-app\">\n            <div style=\"text-align:center;\" >\n        \t\t<img");
            BeginWriteAttribute("src", " src=\"", 581, "\"", 599, 1);
#nullable restore
#line 24 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
WriteAttributeValue("", 587, item.imagen, 587, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\" height: 500px;\">\n            </div>\n\t\t\t<div class=\"catalogo\" style=\"height: 250px;\">\n\t\t\t\t<div style=\"text-align:center;\" class=\"card-body\" >\n\t\t\t\t\t<h5 class=\"card-title\" style=\"color:#fdd067;\">");
#nullable restore
#line 28 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t<div style=\"margin-top: 30px;\">\n\t\t\t\t\t\t<p style=\"text-align: center;\"><a class=\"btn btn-primary\" disabled><i class=\"icofont-price\"></i> S/ ");
#nullable restore
#line 31 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
                                                                                                                       Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n\t\t\t\t\t\t<div class=\"col\" style=\"text-align: center;\">\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c16108409461b4a44b95c6b1fcc1c555dbbe9357184", async() => {
                WriteLiteral("<i class=\"icofont-cart\"></i> Agregar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
                                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c16108409461b4a44b95c6b1fcc1c555dbbe9359693", async() => {
                WriteLiteral("<i class=\"icofont-info-circle\"></i> Leer más");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
                                     WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n    </div>\n");
#nullable restore
#line 40 "C:\Users\limps\Desktop\Mi proyecto\LibreriaProgra-main\Views\Catalogo\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

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
        &copy; Copyright <strong><span> Copyright</span></strong>. Todos los derechos reservador
      </div>
      <div class=""credits"">
");
            WriteLiteral("        Diseñado por <a href=\"#\"> The One</a>\n      </div>\n    </div>\n  </footer>\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibreriaProgra.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
