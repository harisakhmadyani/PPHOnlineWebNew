#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f2787e5a2e80a7a3dd84e6c0c5b4e41d13c638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Index3), @"mvc.1.0.view", @"/Views/Supplier/Index3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f2787e5a2e80a7a3dd84e6c0c5b4e41d13c638", @"/Views/Supplier/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Supplier_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemRequest>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon btn-circle btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_js.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_modal3.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        <h1 class=""m-0 text-dark""> Transaction Supplier <small>My Prices</small></h1>
        </div><!-- /.col -->
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Transaction Supplier</a></li>
");
            WriteLiteral(@"            <li class=""breadcrumb-item active"">My Prices</li>
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
                                <b>List</b> My Prices 
                        </h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""col-md-12"">
                            <div class=""table-responsive"" style=""height: 500px;"">
                                <table class=""table table-hover dtr-inline table-head-fixed"" id=""datatables"">
                                    <t");
            WriteLiteral(@"head>
                                        <tr>
                                            <th style=""width: 25%;""><h3 class=""card-title brand-text font-weight-light""><b>Item</b></h3></th>
                                            <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>UOM</b></h3></th>
                                            <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>Qty</b></h3></th>
                                            <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>Currency</b></h3></th>
                                            <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>My Price</b></h3></th>
                                            <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>Valid Until</b></h3></th>
                                            <th style=""width: 10%;""><h3 class=""card-title brand-text f");
            WriteLiteral(@"ont-weight-light""><b>Delivery Date</b></h3></th>
                                            <th style=""width: 15%;""><h3 class=""card-title brand-text font-weight-light""><b>Remark</b></h3></th>
                                            <th style=""width: 2%;""><h3 class=""card-title brand-text font-weight-light""><b>Images</b></h3></th>
                                            <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>Action</b></h3></th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 50 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                         if(Model.data != null){
                                            int a = 0; 
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                             foreach (var item in Model.data)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                

                                                var qnty2 = item.Qnty.ToString();
                                                var qtyrt2 = item.QtyRt.ToString();
                                                var harga2 = item.Harga.ToString();

                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                     
                                                var image = item.ItemID+".jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr");
            BeginWriteAttribute("id", " id=\'", 4510, "\'", 4527, 1);
#nullable restore
#line 68 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 4515, item.ItemID, 4515, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">                                            \r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 70 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                   Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                                        ");
#nullable restore
#line 71 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                   Write(item.ItemDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>");
#nullable restore
#line 73 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                   Write(item.UOMName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                     if (qnty2.Substring(qnty2.Length - 3) == ".00"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td style=\"text-align: right;\" class=\"autonum_nondecimal\">");
#nullable restore
#line 76 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                             Write(qnty2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 77 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                    } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td style=\"text-align: right;\" class=\"autonum_price\">");
#nullable restore
#line 78 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                        Write(qnty2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 79 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    \r\n                                                    <td style=\"text-align: center;\">");
#nullable restore
#line 81 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                               Write(item.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    \r\n");
#nullable restore
#line 83 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                     if (harga2.Substring(harga2.Length - 3) == ".00"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                         <td style=\"text-align: right;\" class=\"autonum_nondecimal\">");
#nullable restore
#line 84 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                              Write(harga2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 85 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                    } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                         <td style=\"text-align: right;\" class=\"autonum_price\">");
#nullable restore
#line 86 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                         Write(harga2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 87 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                   \r\n                                                    <td style=\"text-align: center;\">");
#nullable restore
#line 89 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                     if(@item.ValidUntil != null) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                              Write(item.ValidUntil.Value.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"text-align: center;\">");
#nullable restore
#line 90 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                     if(@item.DeliveryDate != null) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                                Write(item.DeliveryDate.Value.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 91 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                   Write(item.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                                    <td style=\"text-align: center;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f2787e5a2e80a7a3dd84e6c0c5b4e41d13c63817160", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6635, "~/ItemImage/", 6635, 12, true);
#nullable restore
#line 92 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
AddHtmlAttributeValue("", 6647, image, 6647, 6, false);

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
            WriteLiteral("</td>                                       \r\n                                                    <td style=\"text-align: center;\">\r\n");
#nullable restore
#line 94 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                         if(item.ImportBy is null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <button type=\"button\" class=\"btn bg-gradient-primary btn-sm\" data-toggle=\"modal\" data-target=\"#modal-lg3\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7140, "\"", 7302, 27);
            WriteAttributeValue("", 7150, "isidetail2(\'", 7150, 12, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7162, item.ItemID, 7162, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7174, "\',", 7174, 2, true);
            WriteAttributeValue(" ", 7176, "\'", 7177, 2, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7178, item.ItemName, 7178, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7192, "\',", 7192, 2, true);
            WriteAttributeValue(" ", 7194, "\'", 7195, 2, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7196, item.ItemDesc, 7196, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7210, "\',", 7210, 2, true);
            WriteAttributeValue(" ", 7212, "\'", 7213, 2, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7214, item.UOMName, 7214, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7227, "\'", 7227, 1, true);
            WriteAttributeValue(" ", 7228, ",\'", 7229, 3, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7231, qnty2, 7231, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7237, "\',", 7237, 2, true);
            WriteAttributeValue(" ", 7239, "\'", 7240, 2, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7241, item.IDInput, 7241, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7254, "\',", 7254, 2, true);
            WriteAttributeValue(" ", 7256, "\'", 7257, 2, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7258, harga2, 7258, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7265, "\',", 7265, 2, true);
            WriteAttributeValue(" ", 7267, "\'", 7268, 2, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7269, item.Remark, 7269, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7281, "\',", 7281, 2, true);
            WriteAttributeValue(" ", 7283, "\'", 7284, 2, true);
#nullable restore
#line 95 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7285, item.NewItemID, 7285, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7300, "\')", 7300, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-usd mr-1\"></i>Update Price</button>\r\n");
#nullable restore
#line 96 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                </tr>  \r\n");
#nullable restore
#line 99 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                                a++;   
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7802, "\"", 7841, 2);
            WriteAttributeValue("", 7809, "DownloadMyPrice?prd=", 7809, 20, true);
#nullable restore
#line 104 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\Index3.cshtml"
WriteAttributeValue("", 7829, ViewBag.Prd, 7829, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn bg-gradient-danger btn-sm""><i class=""far fa-file-pdf mr-1""></i>Download PDF</a>
                            </div>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62f2787e5a2e80a7a3dd84e6c0c5b4e41d13c63825004", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62f2787e5a2e80a7a3dd84e6c0c5b4e41d13c63826122", async() => {
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
