#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa11d1d559eb8c7832d8b6370be22c19edaa9aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_index2), @"mvc.1.0.view", @"/Views/Supplier/index2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa11d1d559eb8c7832d8b6370be22c19edaa9aa", @"/Views/Supplier/index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Supplier_index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemRequest>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon btn-circle btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_js.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_modal.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1 class=""m-0 text-dark""> Transaction Supplier <small>Input Price My Items</small></h1>
        </div><!-- /.col -->
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Transaction Supplier</a></li>
");
            WriteLiteral(@"            <li class=""breadcrumb-item active"">Input Price My Item</li>
        </ol>
        </div><!-- /.col -->
    </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card card-primary card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title brand-text font-weight-light"">
                            <i class=""fas fa-table mr-1""></i>
                                <b>List</b> My Items 
                        </h3>
                    </div>
                    <div id=""isidetail"">
");
#nullable restore
#line 32 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                           
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
            WriteLiteral(@"                        <div class=""card-body"">
                            <div class=""col-md-12"">
                                <div class=""table-responsive"" style=""height: 500px;"">
                                    <table class=""table table-hover dtr-inline table-head-fixed"" id=""datatables"">
                                        <thead>
                                            <tr>
                                                <th style=""width: 35%;""><h3 class=""card-title brand-text font-weight-light""><b>Item</b></h3></th>
                                                <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>Factory</b></h3></th>
                                                <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>UOM</b></h3></th>
                                                <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>Qty</b></h3></th>
                                   ");
            WriteLiteral(@"             <th style=""width: 7%;""><h3 class=""card-title brand-text font-weight-light""><b>Usage / Year</b></h3></th>
                                                <th style=""width: 2%;""><h3 class=""card-title brand-text font-weight-light""><b>Images</b></h3></th>
                                                <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>Action</b></h3></th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 68 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                             if(Model.data != null){
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                 foreach (var item in Model.data)
                                                {
                                                    var qnty2 = item.Qnty.ToString();
                                                    var qtyrt2 = item.QtyRt.ToString();

                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                            

                                                    var image = item.ItemID+".jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr");
            BeginWriteAttribute("id", " id=\'", 4601, "\'", 4618, 1);
#nullable restore
#line 78 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 4606, item.ItemID, 4606, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">                                            \r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 80 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                       Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                                            ");
#nullable restore
#line 81 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                       Write(item.ItemDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>");
#nullable restore
#line 83 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                       Write(item.Factory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 84 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                       Write(item.UOMName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 86 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                         if (qnty2.Substring(qnty2.Length - 3) == ".00"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td style=\"text-align: right;\" class=\"autonum_nondecimal\">");
#nullable restore
#line 87 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                 Write(qnty2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 88 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                        } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td style=\"text-align: right;\" class=\"autonum_price\">");
#nullable restore
#line 89 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                            Write(qnty2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 90 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 92 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                         if (qtyrt2.Substring(qtyrt2.Length - 2) == ".0"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td style=\"text-align: right;\" class=\"autonum_nondecimal\">");
#nullable restore
#line 93 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                 Write(qtyrt2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 94 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                        } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td style=\"text-align: right;\" class=\"autonum_price\">");
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                            Write(qtyrt2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 96 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        <td style=\"text-align: center;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa11d1d559eb8c7832d8b6370be22c19edaa9aa15084", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6189, "~/ItemImage/", 6189, 12, true);
#nullable restore
#line 98 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
AddHtmlAttributeValue("", 6201, image, 6201, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</td>
                                                        <td style=""text-align: center;"">
                                                            <button type=""button"" class=""btn bg-gradient-primary btn-sm"" data-toggle=""modal"" data-target=""#modal-lg""");
            BeginWriteAttribute("onclick", " onclick=\"", 6573, "\"", 6718, 24);
            WriteAttributeValue("", 6583, "isidetail(\'", 6583, 11, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6594, item.ItemID, 6594, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6606, "\',", 6606, 2, true);
            WriteAttributeValue(" ", 6608, "\'", 6609, 2, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6610, item.ItemName, 6610, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6624, "\',", 6624, 2, true);
            WriteAttributeValue(" ", 6626, "\'", 6627, 2, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6628, item.ItemDesc, 6628, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6642, "\',", 6642, 2, true);
            WriteAttributeValue(" ", 6644, "\'", 6645, 2, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6646, item.UOMName, 6646, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6659, "\'", 6659, 1, true);
            WriteAttributeValue(" ", 6660, ",\'", 6661, 3, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6663, qnty2, 6663, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6669, "\',", 6669, 2, true);
            WriteAttributeValue(" ", 6671, "\'", 6672, 2, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6673, qtyrt2, 6673, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6680, "\',", 6680, 2, true);
            WriteAttributeValue(" ", 6682, "\'", 6683, 2, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6684, item.NewItemID, 6684, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6699, "\',", 6699, 2, true);
            WriteAttributeValue(" ", 6701, "\'", 6702, 2, true);
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 6703, item.Factory, 6703, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6716, "\')", 6716, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-usd mr-1\"></i>Add Price</button>\r\n                                                        </td>\r\n                                                    </tr>  \r\n");
#nullable restore
#line 103 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7127, "\"", 7174, 2);
            WriteAttributeValue("", 7134, "DownloadMyProductItem?pages=", 7134, 28, true);
#nullable restore
#line 107 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 7162, CurrentPage, 7162, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn bg-gradient-danger btn-sm""><i class=""far fa-file-pdf mr-1""></i>Download PDF</a>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer clearfix"">
                            <div class=""pagination pagination-sm m-0 float-left"">Page ");
#nullable restore
#line 112 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                 Write(CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 112 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                 Write(CountPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <ul class=\"pagination pagination-sm m-0 float-right\">\r\n                                <li class=\"page-item\"><button type=\"button\" class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7732, "\"", 7771, 3);
            WriteAttributeValue("", 7742, "pagesMyProductItem(", 7742, 19, true);
#nullable restore
#line 114 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 7761, prevPage, 7761, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7770, ")", 7770, 1, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 114 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                                 Write(disPrev);

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"font-weight: ");
#nullable restore
#line 114 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                                                              Write(fontWeightPrev);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\">&laquo; Previous</button></li>\r\n");
#nullable restore
#line 115 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
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
            WriteLiteral("                                    <li class=\"page-item\"><button type=\"button\" class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8441, "\"", 8473, 3);
            WriteAttributeValue("", 8451, "pagesMyProductItem(", 8451, 19, true);
#nullable restore
#line 124 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 8470, i, 8470, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8472, ")", 8472, 1, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 124 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                              Write(disCur);

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"font-weight: ");
#nullable restore
#line 124 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                                                          Write(fontWeightCur);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\">");
#nullable restore
#line 124 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></li>\r\n");
#nullable restore
#line 125 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\"><button type=\"button\" class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8666, "\"", 8705, 3);
            WriteAttributeValue("", 8676, "pagesMyProductItem(", 8676, 19, true);
#nullable restore
#line 126 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
WriteAttributeValue("", 8695, nextPage, 8695, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8704, ")", 8704, 1, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 126 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                                 Write(disNext);

#line default
#line hidden
#nullable disable
            WriteLiteral(" style=\"font-weight: ");
#nullable restore
#line 126 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\index2.cshtml"
                                                                                                                                                              Write(fontWeightNext);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";"">Next &raquo;</button></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>  


<!-- ================================================ modul supplier ================================================== -->
<script type=""text/javascript"">
    $(function () {
        $('#datatables').DataTable({
            ""paging"": false
        });

        $('.autonum_price').autoNumeric('init', {
            mDec: 2,
            aDec: '.',
            aSep: ','
        });

        $('.autonum_nondecimal').autoNumeric('init', {
            mDec: 0,
            aDec: '.',
            aSep: ','
        });
    })
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2fa11d1d559eb8c7832d8b6370be22c19edaa9aa28229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2fa11d1d559eb8c7832d8b6370be22c19edaa9aa29347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemRequest> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
