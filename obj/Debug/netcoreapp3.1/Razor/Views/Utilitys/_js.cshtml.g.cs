#pragma checksum "D:\GitHubASP.Net\PPHOnline\PlgRequest\Views\Utilitys\_js.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec55d4bfc6e2a13eedd5b8ae0213e663a2b746a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilitys__js), @"mvc.1.0.view", @"/Views/Utilitys/_js.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec55d4bfc6e2a13eedd5b8ae0213e663a2b746a9", @"/Views/Utilitys/_js.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7713f4f90e95aa0d101a8995d0e7355d8e90e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Utilitys__js : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<Script type=""text/javascript"">
    function saveData(){
        var groupAccessID = $('#groupAccessID').val();
        var groupAccessName = $('#groupAccessName').val();
        
        $url = ""/PlgRequest/Utilitys/AjaxSaveGroupAccess"";
        
        $.ajax({
            url: $url,
            data: {
                groupAccessID : groupAccessID, groupAccessName : groupAccessName
            },
            type: ""POST"",
            success: function(response){
                if(response.msg == ""ok""){
                    swal({
                            title: 'Success',
                            text: ""Success To Save"",
                            type: 'success'
                        }, function(isConfirm){   
                            if (isConfirm) {
                                location.reload(true);
                            }
                        });
                }
                else{
                    swal({
                        title: 'Error'");
            WriteLiteral(@",
                        text: ""Failed To Save"",
                        type: 'error'
                    }, function(isConfirm){   
                        if (isConfirm) {
                            $('#modal-xl').modal('hide');
                        }
                    });
                }
            }
        });
    }

    function showModalEdit(groupAccessID, groupAccessName){
        $('#groupAccessIDEdit').val(groupAccessID);
        $('#groupAccessNameEdit').val(groupAccessName);
        $('#modal-xl-edit').modal('show');
    }

    function updateData(){
        var groupAccessID = $('#groupAccessIDEdit').val();
        var groupAccessName = $('#groupAccessNameEdit').val();
        
        $url = ""/PlgRequest/Utilitys/AjaxUpdateGroupAccess"";
        
        $.ajax({
            url: $url,
            data: {
                groupAccessID : groupAccessID, groupAccessName : groupAccessName
            },
            type: ""POST"",
            success: function(");
            WriteLiteral(@"response){
                if(response.msg == ""ok""){
                    swal({
                            title: 'Success',
                            text: ""Success To Update"",
                            type: 'success'
                        }, function(isConfirm){   
                            if (isConfirm) {
                                location.reload(true);
                            }
                        });
                }
                else{
                    swal({
                        title: 'Error',
                        text: ""Failed To Update"",
                        type: 'error'
                    }, function(isConfirm){   
                        if (isConfirm) {
                            $('#modal-xl-edit').modal('hide');
                        }
                    });
                }
            }
        });
    }

    function deleteData(btn, groupAccessID){
        $url = ""/PlgRequest/Utilitys/AjaxDeleteGroupAccess"";
        ");
            WriteLiteral(@"
        $.ajax({
            url: $url,
            data: {
                groupAccessID : groupAccessID
            },
            type: ""POST"",
            success: function(response){
                if(response.msg == ""ok""){
                    swal({
                            title: 'Success',
                            text: ""Success To Non-Active"",
                            type: 'success'
                        }, function(isConfirm){   
                            if (isConfirm) {
                                var row = btn.parentNode.parentNode;
                                row.parentNode.removeChild(row);
                            }
                        });
                }
                else{
                    swal({
                        title: 'Error',
                        text: ""Failed To Non-Active"",
                        type: 'error'
                    }, function(isConfirm){   
                        if (isConfirm) {
               ");
            WriteLiteral(@"         }
                    });
                }
            }
        });
    }

    function saveMenuAccess(){
        var checkbox = document.getElementsByName(""menu"");

        var menu = [];
        for(var i = 0; i < checkbox.length; i++){
            if(checkbox[i].checked){
                menu.push(checkbox[i].value);
            }
        }

        console.log(menu);
    }
</Script>");
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