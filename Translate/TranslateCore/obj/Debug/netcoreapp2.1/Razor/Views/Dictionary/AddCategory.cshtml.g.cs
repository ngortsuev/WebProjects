#pragma checksum "C:\Users\foxland\Dev\TranslateCore\Views\Dictionary\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83bac0fd2bdbadc92836b44540e4ddae4e118a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dictionary_AddCategory), @"mvc.1.0.view", @"/Views/Dictionary/AddCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dictionary/AddCategory.cshtml", typeof(AspNetCore.Views_Dictionary_AddCategory))]
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
#line 1 "C:\Users\foxland\Dev\TranslateCore\Views\_ViewImports.cshtml"
using TranslateCore;

#line default
#line hidden
#line 2 "C:\Users\foxland\Dev\TranslateCore\Views\_ViewImports.cshtml"
using TranslateCore.Models;

#line default
#line hidden
#line 3 "C:\Users\foxland\Dev\TranslateCore\Views\_ViewImports.cshtml"
using TranslateCore.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bac0fd2bdbadc92836b44540e4ddae4e118a9f", @"/Views/Dictionary/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f686fb8d9252e528d6ca3199ed7b8cc197d8231e", @"/Views/_ViewImports.cshtml")]
    public class Views_Dictionary_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WordCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\foxland\Dev\TranslateCore\Views\Dictionary\AddCategory.cshtml"
  
    ViewData["Title"] = "AddType";
    Layout = null;

#line default
#line hidden
            BeginContext(97, 60, true);
            WriteLiteral("\r\n<input type=\"hidden\" name=\"hiddenWordId\" id=\"hiddenWordId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 157, "\"", 180, 1);
#line 7 "C:\Users\foxland\Dev\TranslateCore\Views\Dictionary\AddCategory.cshtml"
WriteAttributeValue("", 165, ViewBag.wordId, 165, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(181, 460, true);
            WriteLiteral(@" />

<div class=""modal fade"" id=""modalAddCategory"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Add Category</h4>
            </div>
            <div class=""modal-body"">
                <ul class=""list-group"">
");
            EndContext();
#line 20 "C:\Users\foxland\Dev\TranslateCore\Views\Dictionary\AddCategory.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(714, 59, true);
            WriteLiteral("                        <a href=\"#\" class=\"list-group-item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 773, "\"", 804, 3);
            WriteAttributeValue("", 783, "addCategory(", 783, 12, true);
#line 22 "C:\Users\foxland\Dev\TranslateCore\Views\Dictionary\AddCategory.cshtml"
WriteAttributeValue("", 795, item.Id, 795, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 803, ")", 803, 1, true);
            EndWriteAttribute();
            BeginContext(805, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(807, 9, false);
#line 22 "C:\Users\foxland\Dev\TranslateCore\Views\Dictionary\AddCategory.cshtml"
                                                                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(816, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 23 "C:\Users\foxland\Dev\TranslateCore\Views\Dictionary\AddCategory.cshtml"
                    }

#line default
#line hidden
            BeginContext(845, 318, true);
            WriteLiteral(@"                </ul>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"">Add</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WordCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
