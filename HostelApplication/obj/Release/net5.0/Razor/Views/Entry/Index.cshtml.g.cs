#pragma checksum "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d383ad05ee6ae7a7119f1dea5dfbf73b7cb8ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entry_Index), @"mvc.1.0.view", @"/Views/Entry/Index.cshtml")]
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
#line 1 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\_ViewImports.cshtml"
using HostelApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\_ViewImports.cshtml"
using HostelApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d383ad05ee6ae7a7119f1dea5dfbf73b7cb8ba", @"/Views/Entry/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e34cb83ea3ec2e2116bd92a08035c68a4429f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Entry_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HostelApplication.Models.Entry>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Entry/Create/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary lg-c-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Entry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
  
    ViewData["Title"] = "Entry Page";
    Layout = "~/Views/Shared/LayoutNew.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<div class=\"col-6\">\r\n    <h2 class=\"text-info\" style=\"font-size:35px\">Entry List</h2>\r\n</div>\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d383ad05ee6ae7a7119f1dea5dfbf73b7cb8ba6502", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>Create New Entry");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"form-border\" style=\"margin-top:40px;\">\r\n");
#nullable restore
#line 23 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped table-hover\" id=\"jayb1\">\r\n            <thead style=\"background-color: azure; font-size: 35px;\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EntryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MatricNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 41 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OtherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 44 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Registry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                     <th>\r\n                        ");
#nullable restore
#line 47 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bursary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 50 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Faculty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 53 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 56 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.StudentLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                     <th>\r\n                        ");
#nullable restore
#line 59 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 62 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SessionofAdmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 65 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 68 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Updated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody style=\"font-size: 35px;\">\r\n");
#nullable restore
#line 75 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                 foreach (var item in Model)
                {
                    var Id = item.EntryId;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 80 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EntryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 83 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MatricNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 86 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OtherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 95 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Registry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                         <td>\r\n                            ");
#nullable restore
#line 98 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Bursary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 101 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Faculty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 104 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 107 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                         <td>\r\n                            ");
#nullable restore
#line 110 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 113 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SessionofAdmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 117 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 120 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Updated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                        <td class=\"text-center\">\r\n                            <div class=\"w-75 btn-group\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d383ad05ee6ae7a7119f1dea5dfbf73b7cb8ba19205", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>&nbspEdit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                                                            WriteLiteral(item.EntryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d383ad05ee6ae7a7119f1dea5dfbf73b7cb8ba21745", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\"></i>&nbspDelete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                                                            WriteLiteral(item.EntryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n\r\n                        </td>\r\n\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 136 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 139 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <center> <p><b>No items is created</b></p></center>\r\n");
#nullable restore
#line 143 "C:\Users\KAZEEM\source\repos\HostelApplication\HostelApplication\Views\Entry\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script>
    $(document).ready(function () {
        $(""#jayb1"").DataTable({
            dom: 'Bfrtip',
            buttons: [
                'excel', 'pdf', 'print'
            ]
        });

        $(""#dialog-form"").dialog({
            modal: true
        });

    });

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HostelApplication.Models.Entry>> Html { get; private set; }
    }
}
#pragma warning restore 1591
