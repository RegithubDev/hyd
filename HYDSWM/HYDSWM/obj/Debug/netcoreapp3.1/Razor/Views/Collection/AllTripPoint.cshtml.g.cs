#pragma checksum "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\Collection\AllTripPoint.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collection_AllTripPoint), @"mvc.1.0.view", @"/Views/Collection/AllTripPoint.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d075", @"/Views/Collection/AllTripPoint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dfbc6d86d6228acc4aef58d99b94d50f49354e7b3986e4605dd0550eb847091a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Collection_AllTripPoint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/FancyBox/jquery.fancybox.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/FancyBox/jquery.fancybox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/otherfiles/Light/global_assets/js/plugins/forms/selects/nselect2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\Collection\AllTripPoint.cshtml"
  
    ViewData["Title"] = "All Trip Point";
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
                
            </div>
        </div>
    </div>
</div>
<div class=""content pt-0"">


    <!-- /page header -->

    <div class=""card mt-1 mr-2"">
        <div class=""card-header header-elements-inline pt-0 pb-0"">
            <div class=""page-title d-flex mt-4"">
                <h4><i class=""icon-arrow-left52 mr-2""></i> <span class=""font-weight-semibold"" id=""spnHeader"">All Trip Points</span> Information</h4>&nbsp;

            </div>

            <div class=""list-icons"">
                
                <input type=""button"" id=""btnExcel"" class=""btn btn-success"" style="" left: -10px; top: 3px"" value=""Export To Excel"" onclick=""D");
            WriteLiteral(@"ownloadFile('Excel');"">
                    
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
        <div class=""card-body"">

            <div class=""row"">
            </div>
        </div>

        <div class=""dataTables_wrapper no-footer"">

            <div class=""datatable-scroll-wrap"">

                <table class=""table datatable-button-html5-columns"" id=""example"">
                    <thead>
                        <tr>
                            <th></th>

                            <th>Sr. No</th>
                            <th>Route Code</th>
                            <th>Route Trip Code</th>
                            <th>Vehicle No</th>
");
            WriteLiteral(@"                            <th>Buffer Min</th>
                            <th>Total Points</th>
                            <th>Status</th>
                            <th>View On Map</th>
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

<!-- Vertical form modal -->
<div id=""viewonmap"" class=""modal fade"" tabindex=""-1"" data-backdrop=""static"" data-keyboard=""false"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"">Trip Points Information</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""CloseModal()"">&times;</button>
            </div>

          ");
            WriteLiteral(@"  <div class=""modal-body"">
                <div id=""dvIMap"" style=""height: 400px; width: 100%"">
                </div>
            </div>

            <div class=""card-footer d-flex justify-content-between align-items-center bg-info border-top-0"">
                <button type=""button"" class=""btn bg-transparent text-white border-white border-2"" data-dismiss=""modal"" onclick=""CloseModal()"">Close</button>
            </div>
        </div>
    </div>

</div>
<!-- /vertical form modal -->

<style>
    td.details-control {
        background: url('/otherfiles/Light/global_assets/images/details_open.png') no-repeat center center;
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d0759356", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d07510554", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d07511674", async() => {
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
                WriteLiteral("\r\n<script src=\"/otherfiles/Light/global_assets/js/demo_pages/form_layouts.js\"></script>\r\n<script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyDR9w4KTLnl8IWjTgFLHIvHZXLrpJlKi6I\"></script>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d07512998", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4476, "~/js/CommonHelper.js?", 4476, 21, true);
#nullable restore
#line 130 "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\Collection\AllTripPoint.cshtml"
AddHtmlAttributeValue("", 4497, DateTime.Now.Ticks, 4497, 19, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d07514622", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4542, "~/ViewJs/Common/AllGenericFunc.js?", 4542, 34, true);
#nullable restore
#line 131 "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\Collection\AllTripPoint.cshtml"
AddHtmlAttributeValue("", 4576, DateTime.Now.Ticks, 4576, 19, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e280a298a6e8db9e54a95743befc75c39a4687250087353c9d5349fd508d07516259", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4621, "~/ViewJs/Collection/AllTripPointInfo.js?", 4621, 40, true);
#nullable restore
#line 132 "C:\Users\Umamaheswara\Desktop\Hyd_project\Hyd_project\HYDSWM\HYDSWM\Views\Collection\AllTripPoint.cshtml"
AddHtmlAttributeValue("", 4661, DateTime.Now.Ticks, 4661, 19, false);

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
