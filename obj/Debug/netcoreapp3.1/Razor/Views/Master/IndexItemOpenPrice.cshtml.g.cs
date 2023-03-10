#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0991a9a0897b364d3055d55a79b69a1ab3dc50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_IndexItemOpenPrice), @"mvc.1.0.view", @"/Views/Master/IndexItemOpenPrice.cshtml")]
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
#nullable restore
#line 1 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0991a9a0897b364d3055d55a79b69a1ab3dc50", @"/Views/Master/IndexItemOpenPrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Master_IndexItemOpenPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDateTime>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_js.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
  
    var factAbbr = Context.Session.GetString("_FAbbrs");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<div class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n    <div class=\"row mb-2\">\r\n        <div class=\"col-sm-6\">\r\n        <h1 class=\"m-0 text-dark\"> Master <small>Items Open Price (");
#nullable restore
#line 12 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
                                                              Write(factAbbr);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small></h1>\r\n        </div><!-- /.col -->\r\n        <div class=\"col-sm-6\">\r\n        <ol class=\"breadcrumb float-sm-right\">\r\n            <li class=\"breadcrumb-item\"><a href=\"#\">Master</a></li>\r\n");
            WriteLiteral(@"            <li class=""breadcrumb-item active"">Items Open Price</li>
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
                        <i class=""fas fa-cogs mr-1""></i>
                        <b>Refresh</b> Items Open Price
                    </h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""col-md-12"">
                            <div class=""form-group row"">                                
                                <button type=""button"" class=""btn bg-gradient-primary"" onclick=""refreshItemOpenPrice()""><i class=""fa fa-sync mr-1""><");
            WriteLiteral(@"/i></i>Refresh Items Open Price</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.col -->
        </div>
        <!-- /.card -->
    </div>
    <!-- /.container-fluid -->
    <div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-default card-outline"">
                <div class=""card-header"">
                    <h3 class=""card-title brand-text font-weight-light"">
                        <i class=""fas fa-table mr-1""></i>
                            <b>List</b> Items Open Price
                    </h3>
                </div>
                <div>
                    <div class=""card-body"">
                        <div class=""col-md-12"">
                            <div class=""form-group row"">
                                <label class=""col-md-2 col-form-label""><h3 class=""card-title brand-text font-weight-ligh");
            WriteLiteral("t\"><b>Sub Category</b></h3></label>\r\n                                <div class=\"col-8\">\r\n                                    <select class=\"form-control select2-ctg\" style=\"width: 100%;\" id=\"subcat\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d0991a9a0897b364d3055d55a79b69a1ab3dc507491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
                                         if(ViewBag.SubCat.data != null){
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
                                             foreach (var item in ViewBag.SubCat.data)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d0991a9a0897b364d3055d55a79b69a1ab3dc509260", async() => {
#nullable restore
#line 71 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
                                                                               Write(item.SubCategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
                                                   WriteLiteral(item.SubCategoryID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Master\IndexItemOpenPrice.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </select>
                                </div>
                                <div>
                                    <button type=""button"" class=""btn btn-block bg-gradient-primary"" id=""search"" onclick=""getitemopenprice()""><i class=""fa fa-search mr-1""></i>Search</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <hr>
                <div>
                    <div class=""card-body"" id=""isidetail"">
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d0991a9a0897b364d3055d55a79b69a1ab3dc5012351", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDateTime> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
