#pragma checksum "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8353a765c2286628faf6e8dccacdab3d9c02a27c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_getListRoom), @"mvc.1.0.view", @"/Views/Admin/getListRoom.cshtml")]
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
#line 1 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\_ViewImports.cshtml"
using BuildAppYD.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\_ViewImports.cshtml"
using BuildAppYD.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8353a765c2286628faf6e8dccacdab3d9c02a27c", @"/Views/Admin/getListRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be61d123ad75f5c7ef802c57b0713ee567ebf8bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_getListRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoomModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteRoom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
  
    ViewData["Title"] = "getListRoom";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>getListRoomAsync</h1>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <a class=\"btn btn-danger float-right\" href=\"/AddRoom\">Yeni Oda Ekle</a>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n");
            WriteLiteral("<div><strong>");
#nullable restore
#line 19 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
        Write(TempData["MethodBilgisi"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <td>Room Name</td>\r\n            <td>Building Id - Name</td>\r\n            <td style=\"width:150px;\"></td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
               Write(item.roomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
               Write(item.BuildingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("  - ");
#nullable restore
#line 35 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
                                   Write(item.Buildings.buildingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm mr-2\"");
            BeginWriteAttribute("href", " href=\"", 852, "\"", 881, 2);
            WriteAttributeValue("", 859, "UpdateRoom?id=", 859, 14, true);
#nullable restore
#line 37 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
WriteAttributeValue("", 873, item.Id, 873, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8353a765c2286628faf6e8dccacdab3d9c02a27c6909", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"roomId\"");
                BeginWriteAttribute("value", " value=\"", 1042, "\"", 1058, 1);
#nullable restore
#line 40 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
WriteAttributeValue("", 1050, item.Id, 1050, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\kemal\source\repos\BuildAppYD\BuildAppYD.WebUI\Views\Admin\getListRoom.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoomModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
