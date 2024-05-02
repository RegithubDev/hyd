#pragma checksum "D:\New folder\hyd\HYDSWM\HYDSWM\Views\Account\ChangePassword.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c616d55d1e50ea3be74829f125f437ad6dd1ce08846c26b864da6040485ec6d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePassword), @"mvc.1.0.view", @"/Views/Account/ChangePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c616d55d1e50ea3be74829f125f437ad6dd1ce08846c26b864da6040485ec6d4", @"/Views/Account/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dfbc6d86d6228acc4aef58d99b94d50f49354e7b3986e4605dd0550eb847091a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal-content"">
    <div class=""modal-header"">
        <h3 class=""modal-title"">Change User Password</h3>
        <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""CloseModal()"">&times;</button>
    </div>
    <div class=""modal-body"">
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Login Id</label>
                        <input type=""text"" class=""form-control"" id=""txtLoginId""");
            BeginWriteAttribute("value", " value=\"", 549, "\"", 573, 1);
#nullable restore
#line 13 "D:\New folder\hyd\HYDSWM\HYDSWM\Views\Account\ChangePassword.cshtml"
WriteAttributeValue("", 557, ViewBag.LoginId, 557, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Current Password</label>
                        <span class=""text-danger"">*</span>
                        <input type=""password"" placeholder=""Enter Current Password""");
            BeginWriteAttribute("value", " value=\"", 924, "\"", 932, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" id=""txtCurrentPassword"" autocomplete=""off"" onkeypress=""return IsAlphaNumeric(event);""  required>
                    </div>
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <label>New Password</label>
                    <span class=""text-danger"">*</span>
                    <input type=""password"" name=""txtNewpassword"" id=""txtNewpassword""");
            BeginWriteAttribute("value", " value=\"", 1437, "\"", 1445, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control validate-equalTo-blur"" required autocomplete=""off"" placeholder=""Minimum 8 characters allowed"" onkeypress=""return IsAlphaNumeric(event);"" aria-invalid=""false"" minlength=""8"">
                    <label id=""password-error"" class=""validation-invalid-label validation-valid-label"" for=""txtNewpassword"">Success.</label>
                </div>

                <div class=""col-sm-6"">
                    <label>Repeat password</label>
                    <input type=""password"" name=""repeat_password"" id=""txtrepeat_password"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2011, "\"", 2019, 0);
            EndWriteAttribute();
            WriteLiteral(@" required autocomplete=""off"" placeholder=""Try different password"" onkeypress=""return IsAlphaNumeric(event);"" aria-invalid=""false"" minlength=""8"">
                    <label id=""repeat_password-error"" class=""validation-invalid-label validation-valid-label"" for=""repeat_password"">Success.</label>
                </div>
            </div>
        </div>

    </div>

    <div class=""card-footer d-flex justify-content-between align-items-center bg-info border-top-0"">
        <button type=""button"" class=""btn bg-transparent text-white border-white border-2"" data-dismiss=""modal"" onclick=""CloseModal()"">Close</button>
        <button type=""submit"" class=""btn btn-outline bg-white text-white border-white border-2"">Submit <i class=""icon-paperplane ml-2""></i></button>
    </div>

</div>
<script>
    
    function IsAlphaNumeric(e) {
        
        var keyCode = e.keyCode == 0 ? e.charCode : e.keyCode;
        var ret = ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 64 && keyCode <= 90) || (keyCode >= 9");
            WriteLiteral("7 && keyCode <= 122));\r\n        // document.getElementById(\"error\").style.display = ret ? \"none\" : \"inline\";\r\n        return ret;\r\n    }\r\n</script>");
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
