#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cbde6f80649ff6f00351481e94f9a6936db3a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier__AjaxGetItem), @"mvc.1.0.view", @"/Views/Supplier/_AjaxGetItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cbde6f80649ff6f00351481e94f9a6936db3a62", @"/Views/Supplier/_AjaxGetItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Supplier__AjaxGetItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemRequest>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon btn-circle btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-default card-outline"">
                <div class=""card-header"">
                    <h3 class=""card-title brand-text font-weight-light"">
                        <i class=""fas fa-table mr-1""></i>
                            <b>List</b> Item 
                    </h3>
                </div>
                <div class=""card-body"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"" style=""height: 500px;"">
                            <table class=""table table-hover dtr-inline table-head-fixed"" id=""datatables"">
                                <thead>
                                    <tr>
                                        <th style=""width: 35%;""><h3 class=""card-title brand-text font-weight-light""><b>Item</b></h3></th>
                                        <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-lig");
            WriteLiteral(@"ht""><b>Factory</b></h3></th>
                                        <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>UOM</b></h3></th>
                                        <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>Qty</b></h3></th>
                                        <th style=""width: 7%;""><h3 class=""card-title brand-text font-weight-light""><b>Usage / Year</b></h3></th>
                                        <th style=""width: 2%;""><h3 class=""card-title brand-text font-weight-light""><b>Images</b></h3></th>
");
            WriteLiteral(@"                                        <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>Action</b></h3></th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 31 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                     if(Model.data != null){
                                        int a = 0; 
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                         foreach (var item in Model.data)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                                                            

                                            var qnty2 = item.Qnty.ToString();
                                            var qtyrt2 = item.QtyRt.ToString();
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                                                                 
                                            var image = item.ItemID+".jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr");
            BeginWriteAttribute("id", " id=\'", 3591, "\'", 3608, 1);
#nullable restore
#line 49 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 3596, item.ItemID, 3596, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">                                            \r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 51 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                               Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                                    ");
#nullable restore
#line 52 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                               Write(item.ItemDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 54 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                               Write(item.Factory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 55 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                               Write(item.UOMName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 57 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                 if (qnty2.Substring(qnty2.Length - 3) == ".00"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"text-align: right;\" class=\"autonum_nondecimal\">");
#nullable restore
#line 58 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                                                                         Write(qnty2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"text-align: right;\" class=\"autonum_price\">");
#nullable restore
#line 60 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                                                                    Write(qnty2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 61 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 63 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                 if (qtyrt2.Substring(qtyrt2.Length - 2) == ".0"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"text-align: right;\" class=\"autonum_nondecimal\">");
#nullable restore
#line 64 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                                                                         Write(qtyrt2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 65 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"text-align: right;\" class=\"autonum_price\">");
#nullable restore
#line 66 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                                                                    Write(qtyrt2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 67 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <td style=\"text-align: center;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cbde6f80649ff6f00351481e94f9a6936db3a6212451", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5043, "~/ItemImage/", 5043, 12, true);
#nullable restore
#line 69 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
AddHtmlAttributeValue("", 5055, image, 5055, 6, false);

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
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                                <td style=\"text-align: center;\">\r\n");
            WriteLiteral("                                                        <button type=\"button\" class=\"btn bg-gradient-primary btn-sm\" data-toggle=\"modal\" data-target=\"#modal-lg\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5869, "\"", 6014, 24);
            WriteAttributeValue("", 5879, "isidetail(\'", 5879, 11, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5890, item.ItemID, 5890, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5902, "\',", 5902, 2, true);
            WriteAttributeValue(" ", 5904, "\'", 5905, 2, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5906, item.ItemName, 5906, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5920, "\',", 5920, 2, true);
            WriteAttributeValue(" ", 5922, "\'", 5923, 2, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5924, item.ItemDesc, 5924, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5938, "\',", 5938, 2, true);
            WriteAttributeValue(" ", 5940, "\'", 5941, 2, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5942, item.UOMName, 5942, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5955, "\'", 5955, 1, true);
            WriteAttributeValue(" ", 5956, ",\'", 5957, 3, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5959, qnty2, 5959, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5965, "\',", 5965, 2, true);
            WriteAttributeValue(" ", 5967, "\'", 5968, 2, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5969, qtyrt2, 5969, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5976, "\',", 5976, 2, true);
            WriteAttributeValue(" ", 5978, "\'", 5979, 2, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5980, item.NewItemID, 5980, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5995, "\',", 5995, 2, true);
            WriteAttributeValue(" ", 5997, "\'", 5998, 2, true);
#nullable restore
#line 75 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
WriteAttributeValue("", 5999, item.Factory, 5999, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6012, "\')", 6012, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-usd mr-1\"></i>Add Price</button>\r\n");
            WriteLiteral("                                                </td>\r\n                                            </tr>  \r\n");
#nullable restore
#line 79 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                            a++;   
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Supplier\_AjaxGetItem.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>  


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
</script>");
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
