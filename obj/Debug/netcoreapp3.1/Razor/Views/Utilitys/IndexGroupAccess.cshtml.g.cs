#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f28e1132f86669700a1e208cb614f167be11205d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilitys_IndexGroupAccess), @"mvc.1.0.view", @"/Views/Utilitys/IndexGroupAccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28e1132f86669700a1e208cb614f167be11205d", @"/Views/Utilitys/IndexGroupAccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Utilitys_IndexGroupAccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupAccess>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_js.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_modal.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1 class=""m-0 text-dark""> Utility <small>Group Access</small></h1>
        </div><!-- /.col -->
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Utility</a></li>
");
            WriteLiteral(@"            <li class=""breadcrumb-item active"">Group Access</li>
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
                                <b>List</b> Group Access 
                        </h3>
                        <button type=""button"" class=""btn bg-gradient-primary btn-sm"" data-toggle=""modal"" data-target=""#modal-xl"" style=""float: right;""><i class=""fas fa-plus mr-1""></i>Create New</button>
                    </div>
                    <div class=""card-body"">
                        <div class=""col-md-12"">
                      ");
            WriteLiteral(@"      <div class=""table-responsive"" style=""height: 500px;"">
                                <table class=""table table-hover dtr-inline table-head-fixed"" id=""datatables"">
                                    <thead>
                                        <tr>
                                            <th style=""width: 15%;""><h3 class=""card-title brand-text font-weight-light""><b>Group Access ID</b></h3></th>
                                            <th style=""width: 25%;""><h3 class=""card-title brand-text font-weight-light""><b>Group Access Name</b></h3></th>
                                            <th style=""width: 50%;""><h3 class=""card-title brand-text font-weight-light""><b>Action</b></h3></th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 44 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
                                         if(Model.data != null){
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
                                             foreach (var item in Model.data)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>                                            \r\n                                                    <td>");
#nullable restore
#line 48 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
                                                   Write(item.GroupAccessID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                                                    <td>");
#nullable restore
#line 49 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
                                                   Write(item.GroupAccessName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                                  \r\n                                                    <td>\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 3024, "\"", 3090, 2);
            WriteAttributeValue("", 3031, "/PlgRequest/Utilitys/IndexMenuAccess?id=", 3031, 40, true);
#nullable restore
#line 51 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
WriteAttributeValue("", 3071, item.GroupAccessID, 3071, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-gradient-info btn-sm\"><i class=\"fas fa-indent mr-1\"></i>Menu Access</a>\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 3237, "\"", 3310, 2);
            WriteAttributeValue("", 3244, "/PlgRequest/Utilitys/IndexSubCategoryAccess?id=", 3244, 47, true);
#nullable restore
#line 52 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
WriteAttributeValue("", 3291, item.GroupAccessID, 3291, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-gradient-success btn-sm\"><i class=\"fas fa-list-ol mr-1\"></i>Sub Category Access</a>\r\n                                                        <button type=\"button\" class=\"btn bg-gradient-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3527, "\"", 3598, 6);
            WriteAttributeValue("", 3537, "showModalEdit(\'", 3537, 15, true);
#nullable restore
#line 53 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
WriteAttributeValue("", 3552, item.GroupAccessID, 3552, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3571, "\',", 3571, 2, true);
            WriteAttributeValue(" ", 3573, "\'", 3574, 2, true);
#nullable restore
#line 53 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
WriteAttributeValue("", 3575, item.GroupAccessName, 3575, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3596, "\')", 3596, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-pencil-alt mr-1\"></i>Edit</button>\r\n                                                        <button type=\"button\" class=\"btn bg-gradient-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3768, "\"", 3817, 4);
            WriteAttributeValue("", 3778, "deleteData(this,", 3778, 16, true);
            WriteAttributeValue(" ", 3794, "\'", 3795, 2, true);
#nullable restore
#line 54 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
WriteAttributeValue("", 3796, item.GroupAccessID, 3796, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3815, "\')", 3815, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-power-off mr-1\"></i>Non-Active</button>\r\n                                                    </td>\r\n                                                </tr> \r\n");
#nullable restore
#line 57 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\IndexGroupAccess.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
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
    })
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f28e1132f86669700a1e208cb614f167be11205d11890", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f28e1132f86669700a1e208cb614f167be11205d13008", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupAccess> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
