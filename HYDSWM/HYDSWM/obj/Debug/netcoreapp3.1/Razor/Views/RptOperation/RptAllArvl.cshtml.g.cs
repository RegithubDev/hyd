#pragma checksum "D:\New folder\hyd\HYDSWM\HYDSWM\Views\RptOperation\RptAllArvl.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RptOperation_RptAllArvl), @"mvc.1.0.view", @"/Views/RptOperation/RptAllArvl.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c3", @"/Views/RptOperation/RptAllArvl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dfbc6d86d6228acc4aef58d99b94d50f49354e7b3986e4605dd0550eb847091a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RptOperation_RptAllArvl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "CONTAINER", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "VEHICLE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/assets/js/jquery.datetimepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/assets/css/jquery.datetimepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/Light/global_assets/js/plugins/forms/selects/nselect2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\New folder\hyd\HYDSWM\HYDSWM\Views\RptOperation\RptAllArvl.cshtml"
  
    ViewData["Title"] = "Arrival Report Of Entity";
    Layout = "~/Views/Shared/_MonsterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-header border-bottom-0"">

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
    <div class=""page-header border-bottom-0"">
    </div>
    <!-- /page header -->

    <div class=""card mt-1 mr-2"">
        <div class=""card-header header-elements-inline pt-0 pb-0 "">
            <div class=""page-title d-flex mt-4"">
                <h4><i class=""icon-arrow-left52 mr-2""></i> <span class=""font-weight-semibold"" id=""spnHeader"">All Arrival Entity </span> Report</h4>&nbsp;

            </div>

            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
        <div class=""card-body"">

            <div class=""row"">
                <div class=""col-md-4"">
                    <label>TS/SCTP</label>
                    <select id=""ddlTransferStation"" clas");
            WriteLiteral("s=\"form-control form-control-select2\" data-fouc>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c37638", async() => {
                WriteLiteral("All Transfer Station");
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

                 <div class=""col-md-4"">
                    <label>Entity Type</label>
                    <select id=""ddlEntityType"" data-placeholder="""" class=""form-control form-control-select2"" data-fouc>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c39133", async() => {
                WriteLiteral("CONTAINER");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c310343", async() => {
                WriteLiteral("VEHICLE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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

             <br />
            <div class=""row"">

                <div class=""col-md-4"">
                    <label>From Date</label>
                    <input type=""text"" placeholder=""Select From Date"" class=""form-control"" id=""txtFromDate"" autocomplete=""off"">
                </div>

                <div class=""col-md-4"">
                    <label>To Date</label>
                    <input type=""text"" placeholder=""Select To Date"" id=""txtToDate"" class=""form-control"" autocomplete=""off"">
                </div>
                <div class=""col-md-4"">
                    <div class=""button-group"">
                        <input type=""button"" id=""btnSearch"" class=""btn btn-primary"" value=""Search"" onclick=""GetDataTableData('Click');"">
                        <div style=""top:2px; right:-9px"" id=""btnExcel"" class=""btn-group""
                             role=""group""
                             aria-label=""Button group wi");
            WriteLiteral(@"th nested dropdown"">


                            <div class=""btn-group"" role=""group"">
                                <button id=""btnGroupDrop1""
                                        type=""button""
                                        class=""btn btn-success  dropdown-toggle""
                                        data-bs-toggle=""dropdown""
                                        aria-haspopup=""true""
                                        aria-expanded=""false"">
                                    Export
                                </button>
                                <div class=""dropdown-menu""
                                     aria-labelledby=""btnGroupDrop1"">
                                    <a class=""dropdown-item"" href=""javascript:void(0)"" onclick=""DownloadFile('Excel');""><strong>Excel</strong></a>
                                    <a class=""dropdown-item"" href=""javascript:void(0)"" onclick=""CSVData('CSV');""><strong>CSV</strong></a>
                                </div");
            WriteLiteral(">\r\n                            </div>\r\n\r\n                        </div>\r\n");
            WriteLiteral(@"                    </div>
                </div>
            </div>


        </div>

        <div class=""dataTables_wrapper no-footer"">

            <div class=""datatable-scroll-wrap"" id=""dv1"">

                <table class=""table datatable-button-html5-columns"" id=""example"">
                    <thead>
                        <tr>
                            <th>Sr. No</th>
                            <th>Date & Time</th>
                            <th>Zone</th>
                            <th>Transfer Station Name</th>
                            <th>Entity Type</th>
                            <th>Entity No</th>
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

<style>
    td.details-control {
        background: url('/otherfiles/Light/global_assets/images/details_open.png') no-repe");
            WriteLiteral(@"at center center;
    }

    tr.shown td.details-control {
        background: url('/otherfiles/Light/global_assets/images/details_close.png') no-repeat center center;
    }
</style>
<script>
    function CloseModal() {
        $("".modal"").modal('hide');
    }
</script>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c315278", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c316398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<script src=\"/otherfiles/global_assets/js/plugins/ui/moment/moment.min.js\"></script>\r\n<script src=\"/otherfiles/global_assets/js/plugins/pickers/daterangepicker.js\"></script>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c317780", async() => {
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
                WriteLiteral("\r\n<script src=\"/otherfiles/Light/global_assets/js/demo_pages/form_layouts.js\"></script>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c318991", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7171, "~/js/CommonHelper.js?", 7171, 21, true);
#nullable restore
#line 181 "D:\New folder\hyd\HYDSWM\HYDSWM\Views\RptOperation\RptAllArvl.cshtml"
AddHtmlAttributeValue("", 7192, DateTime.Now.Ticks, 7192, 19, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c320579", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7237, "~/ViewJs/Common/AllGenericFunc.js?", 7237, 34, true);
#nullable restore
#line 182 "D:\New folder\hyd\HYDSWM\HYDSWM\Views\RptOperation\RptAllArvl.cshtml"
AddHtmlAttributeValue("", 7271, DateTime.Now.Ticks, 7271, 19, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8579849ded411b006af7984c912d065076c85be17e932b6854c601e91f6d6c322180", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7316, "~/ViewJs/Operation_Report/RptArvlInfo.js?", 7316, 41, true);
#nullable restore
#line 183 "D:\New folder\hyd\HYDSWM\HYDSWM\Views\RptOperation\RptAllArvl.cshtml"
AddHtmlAttributeValue("", 7357, DateTime.Now.Ticks, 7357, 19, false);

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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
