#pragma checksum "D:\New folder\hyd\HYDSWM\HYDSWM\Views\Master\AddOwnerType.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d6c83bc2d118f312465a4a199fa6673a5d8ebab8ca34894e4f0defd8ebd96c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_AddOwnerType), @"mvc.1.0.view", @"/Views/Master/AddOwnerType.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\New folder\hyd\HYDSWM\HYDSWM\Views\_ViewImports.cshtml"
using HYDSWM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\hyd\HYDSWM\HYDSWM\Views\_ViewImports.cshtml"
using HYDSWM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d6c83bc2d118f312465a4a199fa6673a5d8ebab8ca34894e4f0defd8ebd96c2e", @"/Views/Master/AddOwnerType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dfbc6d86d6228acc4aef58d99b94d50f49354e7b3986e4605dd0550eb847091a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Master_AddOwnerType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"modal-content\">\r\n    <div class=\"modal-header\">\r\n        <h3 class=\"modal-title\">Add Owner Type</h3>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" onclick=\"CloseModal()\">&times;</button>\r\n    </div>\r\n");
            WriteLiteral(@"
    <div class=""modal-body"">


        <div class=""form-group"">
            <div class=""row"">

                <div class=""col-sm-8"">
                    <label>Owner Type</label>
                    <input type=""hidden"" id=""hfZId"" />
                    <span class=""text-danger"">*</span>
                    <input type=""text"" placeholder=""Enter Owner Type"" class=""form-control"" id=""txtOwnerType"" onkeypress = ""return isAlpha(event.keyCode);"" required>
                </div>
               
                <div class=""col-sm-4"">
                    <div class=""form-check"">
                        <br />
                        <label class=""form-check-label"">
                            <input type=""checkbox"" class=""square-o"" id=""ckbIsActive"" name=""IsActive"">
                            Is Active
                        </label>
                    </div>

                </div>

            </div>
        </div>

    </div>
    <div class=""card-footer d-flex justify-content-betwee");
            WriteLiteral(@"n align-items-center bg-info border-top-0"">
        <button type=""button"" class=""btn bg-transparent text-white border-white border-2"" data-dismiss=""modal"" onclick=""CloseModal()"">Close</button>
        <button type=""submit"" class=""btn btn-outline bg-white text-white border-white border-2"">Submit <i class=""icon-paperplane ml-2""></i></button>
    </div>
</div>
<script type=""text/javascript"">


    function isAlpha(keyCode) {

        return ((keyCode >= 65 && keyCode <= 90) || keyCode == 8 || keyCode == 32 || keyCode == 190 || (keyCode >= 48 && keyCode <= 57) || (keyCode >= 97 && keyCode <= 122))

    }
    $(document).keydown(function (keyCode) {
        if (keyCode.ctrlKey == true && (keyCode.which == '118' || keyCode.which == '86')) {

            keyCode.preventDefault();
        }
    });

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
