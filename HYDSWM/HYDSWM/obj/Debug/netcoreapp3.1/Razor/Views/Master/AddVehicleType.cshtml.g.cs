#pragma checksum "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\Master\AddVehicleType.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9777a7447f8dbb414b72bccc048dafdfd2e71972ce7005ff9edd4dffbe2bf7ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_AddVehicleType), @"mvc.1.0.view", @"/Views/Master/AddVehicleType.cshtml")]
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
#line 1 "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\_ViewImports.cshtml"
using HYDSWM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\_ViewImports.cshtml"
using HYDSWM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9777a7447f8dbb414b72bccc048dafdfd2e71972ce7005ff9edd4dffbe2bf7ba", @"/Views/Master/AddVehicleType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dfbc6d86d6228acc4aef58d99b94d50f49354e7b3986e4605dd0550eb847091a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Master_AddVehicleType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"modal-content\">\r\n    <div class=\"modal-header\">\r\n        <h3 class=\"modal-title\">Add Vehicle Type</h3>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" onclick=\"CloseModal()\">&times;</button>\r\n    </div>\r\n");
            WriteLiteral(@"
    <div class=""modal-body"">


        <div class=""form-group"">
            <div class=""row"">

                <div class=""col-sm-4"">
                    <label>Vehicle Type</label>
                    <input type=""hidden"" id=""hfVehicleTypeId"" />
                    <span class=""text-danger"">*</span>
                    <input type=""text"" placeholder=""Enter Vehicle Type"" class=""form-control"" id=""txtVehicleType"" required>
                </div>
                <div class=""col-sm-4"">
                    <label>Volume</label>
                    <span class=""text-danger"">*</span>
                    <input type=""text"" placeholder=""Enter Volume"" class=""form-control"" id=""txtVolume"" required>
                </div>
                <div class=""col-sm-4"">
                    <label>Density</label>
                    <span class=""text-danger"">*</span>
                    <input type=""text"" placeholder=""Enter Density"" class=""form-control"" id=""txtDensity"" required>
                </div>
       ");
            WriteLiteral(@"         <div class=""col-sm-4"">
                    <div class=""form-check"">
                        <br />
                        <br />
                        <label class=""form-check-label"">
                            <input type=""checkbox"" class=""form-check-input"" id=""ckbIsActive"" name=""IsActive"">
                            Is Active
                        </label>
                    </div>

                </div>
               
                
                
                
                <div class=""col-sm-4"">
                    <label for=""OperationType"">Operation Type</label>

                    <select id=""ddlOperationType"" class=""form-control"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9777a7447f8dbb414b72bccc048dafdfd2e71972ce7005ff9edd4dffbe2bf7ba5756", async() => {
                WriteLiteral("Select");
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
            WriteLiteral(@"
                        
                    </select>

                </div>
                

            </div>
        </div>

    </div>
    <div class=""card-footer d-flex justify-content-between align-items-center bg-info border-top-0"">
        <button type=""button"" class=""btn bg-transparent text-white border-white border-2"" data-dismiss=""modal"" onclick=""CloseModal()"">Close</button>
        <button type=""submit"" class=""btn btn-outline bg-white text-white border-white border-2"">Submit <i class=""icon-paperplane ml-2""></i></button>
    </div>
</div>

");
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