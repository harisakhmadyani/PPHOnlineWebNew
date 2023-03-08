#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cf07d2bc051035029fcce28ecf32b26f60637eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master__AjaxGetPagesMyItem), @"mvc.1.0.view", @"/Views/Master/_AjaxGetPagesMyItem.cshtml")]
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
#line 1 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\_ViewImports.cshtml"
using PlgRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\_ViewImports.cshtml"
using PlgRequest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf07d2bc051035029fcce28ecf32b26f60637eb", @"/Views/Master/_AjaxGetPagesMyItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Master__AjaxGetPagesMyItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemSupplier>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card-body\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"table-responsive\" style=\"height: 500px;\">\r\n");
            WriteLiteral(@"            <table class=""table table-hover dtr-inline table-head-fixed"" id=""datatables"">
                <thead>
                    <tr>
                        <th style=""width: 25%;""><h3 class=""card-title brand-text font-weight-light""><b>Item Name</b></h3></th>
                        <th style=""width: 25%;""><h3 class=""card-title brand-text font-weight-light""><b>Item Description</b></h3></th>
                        <th style=""width: 3%;""><h3 class=""card-title brand-text font-weight-light""><b>Action</b></h3></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 15 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                     if(Model.data != null){
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                         foreach (var item in Model.data)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>                                            \r\n                                <td>");
#nullable restore
#line 19 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                               Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                <td>");
#nullable restore
#line 20 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                               Write(item.ItemDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                                  \r\n                                <td>\r\n                                    <button type=\"button\" class=\"btn bg-gradient-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1347, "\"", 1408, 7);
            WriteAttributeValue("", 1357, "removeItem(this,", 1357, 16, true);
            WriteAttributeValue(" ", 1373, "\'", 1374, 2, true);
#nullable restore
#line 22 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
WriteAttributeValue("", 1375, item.ItemID, 1375, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1387, "\',", 1387, 2, true);
            WriteAttributeValue(" ", 1389, "\'", 1390, 2, true);
#nullable restore
#line 22 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
WriteAttributeValue("", 1391, item.NewItemID, 1391, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1406, "\')", 1406, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-trash-alt mr-1\"></i>Remove</button>\r\n                                </td>\r\n                            </tr> \r\n");
#nullable restore
#line 25 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 32 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
  
    var CountPage = Math.Ceiling(ViewBag.CountPage / 500);
    var CurrentPage = ViewBag.CurrentPage;
    var disPrev = "";
    var disNext = "";
    var fontWeightPrev = "";
    var fontWeightNext = "normal";
    var prevPage = CurrentPage - 1;
    var nextPage = CurrentPage + 1;
    if (CurrentPage == 1)
    {
        disPrev = "disabled";
        fontWeightPrev = "bold";
    }
    if (CurrentPage == CountPage)
    {
        disNext = "disabled";
        fontWeightNext = "bold";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-footer clearfix\">\r\n    <div class=\"pagination pagination-sm m-0 float-left\">Page ");
#nullable restore
#line 53 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                         Write(CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 53 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                         Write(CountPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <ul class=\"pagination pagination-sm m-0 float-right\">\r\n        <li class=\"page-item\"><button type=\"button\" class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2450, "\"", 2482, 3);
            WriteAttributeValue("", 2460, "pagesMyItem(", 2460, 12, true);
#nullable restore
#line 55 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
WriteAttributeValue("", 2472, prevPage, 2472, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2481, ")", 2481, 1, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 55 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                                                  Write(disPrev);

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"font-weight: ");
#nullable restore
#line 55 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                                                                               Write(fontWeightPrev);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\">&laquo; Previous</button></li>\r\n");
#nullable restore
#line 56 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
         for(int i = 1; i <= @CountPage ; i++)
        {
            var disCur = "";
            var fontWeightCur = "normal";
            if (CurrentPage == i)
            {
                disCur = "disabled";
                fontWeightCur = "bold";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><button type=\"button\" class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2912, "\"", 2937, 3);
            WriteAttributeValue("", 2922, "pagesMyItem(", 2922, 12, true);
#nullable restore
#line 65 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
WriteAttributeValue("", 2934, i, 2934, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2936, ")", 2936, 1, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 65 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                                               Write(disCur);

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"font-weight: ");
#nullable restore
#line 65 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                                                                           Write(fontWeightCur);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\">");
#nullable restore
#line 65 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></li>\r\n");
#nullable restore
#line 66 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\"><button type=\"button\" class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3082, "\"", 3114, 3);
            WriteAttributeValue("", 3092, "pagesMyItem(", 3092, 12, true);
#nullable restore
#line 67 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
WriteAttributeValue("", 3104, nextPage, 3104, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3113, ")", 3113, 1, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 67 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                                                  Write(disNext);

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"font-weight: ");
#nullable restore
#line 67 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\_AjaxGetPagesMyItem.cshtml"
                                                                                                                               Write(fontWeightNext);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\">Next &raquo;</button></li>\r\n    </ul>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    $(function () {\r\n        $(\'#datatables\').DataTable({\r\n            \"paging\": false\r\n        });\r\n    })\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemSupplier> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591