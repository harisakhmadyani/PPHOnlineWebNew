#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Purchaser\X_AjaxGetItem2X.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06ad3aca9768aaab1ee32d0859fd90fae2cdcfc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchaser_X_AjaxGetItem2X), @"mvc.1.0.view", @"/Views/Purchaser/X_AjaxGetItem2X.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ad3aca9768aaab1ee32d0859fd90fae2cdcfc2", @"/Views/Purchaser/X_AjaxGetItem2X.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Purchaser_X_AjaxGetItem2X : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
                            <b>List</b> Price 
                    </h3>
                </div>
                <div class=""card-body"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover dtr-inline"" id=""datatables"">
                                <thead>
                                    <tr>
                                        <th style=""width: 25%;""><h3 class=""card-title brand-text font-weight-light""><b>Item</b></h3></th>
                                        <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>UOM</b></h3></th>
             ");
            WriteLiteral(@"                           <th style=""width: 5%;""><h3 class=""card-title brand-text font-weight-light""><b>Qty</b></h3></th>
                                        <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>Price / UOM</b></h3></th>
                                        <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>Valid Until</b></h3></th>
                                        <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>Delivery Date</b></h3></th>
                                        <th style=""width: 10%;""><h3 class=""card-title brand-text font-weight-light""><b>Remark</b></h3></th>
                                        <th style=""width: 7%;""><h3 class=""card-title brand-text font-weight-light""><b>Action</b></h3></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>             ");
            WriteLiteral(@"                               
                                        <td>Mouse</td>
                                        <td>Piece</td>
                                        <td style=""text-align: right;"">100</td>
                                        <td style=""text-align: right;"">10.000</td>
                                        <td style=""text-align: center;"">09-09-2020</td>
                                        <td style=""text-align: center;"">09-09-2020</td>
                                        <td>Oke</td>                                        
                                        <td style=""vertical-align: middle; text-align: center;"">
                                            <button type=""button"" class=""btn bg-gradient-primary"" data-toggle=""modal"" data-target=""#modal-lg""><i class=""fas fa-cogs mr-1""></i>Action</button>
                                        </td>
                                    </tr>
                                </tbody>
                     ");
            WriteLiteral(@"       </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
