#pragma checksum "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db95baf2fa9deaaeec8914f6defe42d9dbf74f01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
#line 1 "D:\Projects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#line 2 "D:\Projects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db95baf2fa9deaaeec8914f6defe42d9dbf74f01", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movies.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 34, true);
            WriteLiteral("\r\n<h1>Movie List</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db95baf2fa9deaaeec8914f6defe42d9dbf74f013680", async() => {
                BeginContext(141, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(155, 277, true);
            WriteLiteral(@"
</p>
<div>
    <input type=""text"" name=""searchString"" id=""searchString"" /><input type=""button"" id=""btnSearch"" value=""Search"" />
</div>
<hr/>
<table class=""table table-striped table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(433, 41, false);
#line 20 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(474, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(530, 44, false);
#line 23 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(574, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(630, 42, false);
#line 26 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors));

#line default
#line hidden
            EndContext();
            BeginContext(672, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(728, 40, false);
#line 29 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(768, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(824, 41, false);
#line 32 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(865, 132, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1046, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1107, 40, false);
#line 44 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1215, 43, false);
#line 47 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1326, 41, false);
#line 50 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actors));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1435, 39, false);
#line 53 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 102, true);
            WriteLiteral("\r\n                </td>\r\n                <td valign=\"middle\" align=\"center\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1576, "\"", 1607, 1);
#line 56 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1582, Url.Content(@item.Image), 1582, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1608, "\"", 1655, 1);
#line 56 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1614, Html.DisplayFor(modelItem => item.Title), 1614, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1656, 17, true);
            WriteLiteral(" width=\"100\" />\r\n");
            EndContext();
            BeginContext(1740, 43, true);
            WriteLiteral("                </td>\r\n                <td>");
            EndContext();
            BeginContext(1784, 62, false);
#line 59 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", "Movie", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1874, 68, false);
#line 60 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", "Movie", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1970, 66, false);
#line 61 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "Movie", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 63 "D:\Projects\Movies\Movies\Views\Movie\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2073, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2116, 705, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {

            $(""#btnSearch"").click(function () {
                var searchString = $(""#searchString"").val();
                $(""tbody tr td"").each(function (i, element) {
                    var content = $(element).text();
                    if ((content.indexOf(searchString) != -1) & ($(element)[0].cellIndex < 5)){
                        //found
                        $(element).css(""background-color"", ""yellow"");
                    }
                    else {
                        $(element).css(""background-color"", ""white"");
                    }
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movies.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
