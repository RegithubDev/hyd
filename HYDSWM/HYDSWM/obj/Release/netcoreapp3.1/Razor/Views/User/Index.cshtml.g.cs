#pragma checksum "C:\Projects\RAMKY HYDERABAD\HYDSWM\HYDSWM\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "866cb316b01561557f9ec82d09613f7b3d9c393d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Projects\RAMKY HYDERABAD\HYDSWM\HYDSWM\Views\_ViewImports.cshtml"
using HYDSWM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\RAMKY HYDERABAD\HYDSWM\HYDSWM\Views\_ViewImports.cshtml"
using HYDSWM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"866cb316b01561557f9ec82d09613f7b3d9c393d", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"612dcebc4488e5f17cc759fe13ef183dcad33681", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validate-jquery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return Formsubmit();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/Light/global_assets/js/plugins/forms/selects/nselect2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/assets/js/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/aes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\RAMKY HYDERABAD\HYDSWM\HYDSWM\Views\User\Index.cshtml"
  
    ViewData["Title"] = "All User";
    Layout = "_MonsterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-header border-bottom-0"">

    <div class=""page-breadcrumb"">
        <div class=""row"">
            <div class=""col-md-5 align-self-center"">
            </div>
            <div class=""
                col-md-7
                justify-content-end
                align-self-center
                d-none d-md-flex
              "">
");
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<div class=""content pt-0"">

    <!-- Page header -->
    <!-- /page header -->

    <div class=""card mt-1 mr-2"">
        <div class=""card-header header-elements-inline"">
            <div class=""page-title d-flex"">
                <h4> <span class=""font-weight-semibold"">All User </span> </h4>&nbsp;
");
            WriteLiteral("            </div>\r\n\r\n            <div class=\"list-icons\">\r\n                <a title=\"Add\"");
            BeginWriteAttribute("cid", " cid=\"", 2161, "\"", 2167, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""CallFunc(this);"" id=""btnAdd""><i class=""icon-add""></i></a>
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
        <div class=""card-body"">


            <div class=""dataTables_wrapper no-footer"">

                <div class=""datatable-scroll-wrap"">

                    <table class=""table datatable-button-html5-columns"" id=""example"">
                        <thead>
                            <tr>
                                <th>Sr. No</th>
                                <th>Name</th>
                                <th>Emp Code</th>
                                <th>Role</th>
                                <th>Email</th>
                                <th>Mobile</th>
                                <th>Last Active on</th>
");
            WriteLiteral(@"                                <th>Transfer Station</th>
                                <th>Status</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tfoot>
                        </tfoot>
                        <tbody></tbody>
                    </table>

                </div>
            </div>
        </div>
    </div>
</div>
<!-- Vertical form modal -->
<div id=""modal_form_vertical"" class=""modal fade"" tabindex=""-1"" data-backdrop=""static"" data-keyboard=""false"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cb316b01561557f9ec82d09613f7b3d9c393d9371", async() => {
                WriteLiteral(@"
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h3 class=""modal-title"" id=""modalTitle""></h3>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""CloseModal()"">&times;</button>
                </div>

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <input type=""hidden"" value=""0"" id=""UserId"" />
                                    <label>Name</label>
                                    <span class=""text-danger"">*</span>
                                    <input type=""text"" placeholder=""Enter Name"" class=""form-control"" id=""FullName"" onkeypress=""return isAlpha(event.keyCode);"" required>
                                </div>
                            </div>
                           ");
                WriteLiteral(" <div class=\"col-sm-6\">\r\n                                <div class=\"form-group\">\r\n                                    <label>Employee</label>\r\n");
                WriteLiteral("                                    <select id=\"ddlEmp\" style=\"width  : 100%;\" onchange=\"OnEmpChange(this);\" class=\"form-control\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cb316b01561557f9ec82d09613f7b3d9c393d11100", async() => {
                    WriteLiteral("--select--");
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
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col-sm-6"">
                                    <label>Role</label>
                                    <span class=""text-danger"">*</span>
                                    <select id=""ddlRole"" required class=""form-control"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cb316b01561557f9ec82d09613f7b3d9c393d12909", async() => {
                    WriteLiteral("-select-");
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

                                <div class=""col-sm-6"">
                                    <label>Mobile</label>
                                    <input type=""text"" maxlength=""10""  placeholder=""Mobile No"" class=""form-control"" id=""Mobile"" onkeypress=""return (event.charCode !=8 && event.charCode ==0 || (event.charCode >= 48 && event.charCode <= 57))"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col-sm-6"">
                                    <label>Password</label>
                                    <span class=""text-danger"">*</span>
                                    <input type=""text"" placeholder=""Password""");
                BeginWriteAttribute("value", " value=\"", 7029, "\"", 7037, 0);
                EndWriteAttribute();
                WriteLiteral(@" required class=""form-control"" id=""Password"" onkeypress=""return IsAlphaNumeric(event);"" minlength=""8"">
                                </div>
                                <div class=""col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Login Id</label>
                                        <span class=""text-danger"">*</span>
                                        <input type=""text"" placeholder=""Enter Login Id"" class=""form-control"" id=""Email"" required>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col-sm-6"">
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
                                            <inpu");
                WriteLiteral(@"t type=""checkbox"" checked=""checked"" class=""form-check-input"" id=""IsActive"">
                                            Is Active
                                        </label>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""datatable-scroll-wrap"">
                                <table class=""table datatable-button-html5-columns"" id=""tblCirclemaster"">
                                    <thead>
                                        <tr>
                                            <th>Zone</th>
                                            <th>Transfer Station</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                    </tfoot>
                                    <tbody>
                       ");
                WriteLiteral(@"             </tbody>
                                </table>
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
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<!-- /vertical form modal -->
<script>
    function CloseModal() {
        $("".modal"").modal('hide');
    }
    function isAlpha(keyCode) {

        return ((keyCode >= 65 && keyCode <= 90) || keyCode == 8 || keyCode == 32 || keyCode == 190 || (keyCode >= 48 && keyCode <= 57) || (keyCode >= 97 && keyCode <= 122))

    }
    function IsAlphaNumeric(e) {
        
        var keyCode = e.keyCode == 0 ? e.charCode : e.keyCode;
        var ret = ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 64 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122));
       // document.getElementById(""error"").style.display = ret ? ""none"" : ""inline"";
        return ret;
    }
</script>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"


    <script src=""/otherfiles/global_assets/js/plugins/ui/moment/moment.min.js""></script>
    <script src=""/otherfiles/global_assets/js/plugins/pickers/daterangepicker.js""></script>
    <script src=""/otherfiles/global_assets/js/plugins/pickers/anytime.min.js""></script>
    <script src=""/otherfiles/global_assets/js/plugins/pickers/pickadate/picker.js""></script>
    <script src=""/otherfiles/global_assets/js/plugins/pickers/pickadate/picker.date.js""></script>
    <script src=""/otherfiles/global_assets/js/plugins/pickers/pickadate/legacy.js""></script>
    <script src=""/otherfiles/global_assets/js/demo_pages/picker_date.js""></script>
    <script src=""/otherfiles/global_assets/js/demo_pages/datatables_extension_buttons_html5.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cb316b01561557f9ec82d09613f7b3d9c393d20987", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""/otherfiles/Light/global_assets/js/demo_pages/form_layouts.js""></script>
    <script src=""/otherfiles/global_assets/js/demo_pages/form_validation.js""></script>
    <link href=""/otherfiles/assets/css/sweetalert.css"" rel=""stylesheet"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cb316b01561557f9ec82d09613f7b3d9c393d22349", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cb316b01561557f9ec82d09613f7b3d9c393d23449", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866cb316b01561557f9ec82d09613f7b3d9c393d24549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 11746, "~/ViewJs/UserAccount/UserAccount.js?", 11746, 36, true);
#nullable restore
#line 239 "C:\Projects\RAMKY HYDERABAD\HYDSWM\HYDSWM\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 11782, DateTime.Now.Ticks, 11782, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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