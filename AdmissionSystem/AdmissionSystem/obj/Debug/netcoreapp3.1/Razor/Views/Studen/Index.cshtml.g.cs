#pragma checksum "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d6fa095f6e83e64d89bdbcb9f1c5b7041fa1fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdmissionSystem.Pages.Studen.Views_Studen_Index), @"mvc.1.0.view", @"/Views/Studen/Index.cshtml")]
namespace AdmissionSystem.Pages.Studen
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
#line 1 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using AdmissionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using AdmissionSystem.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6fa095f6e83e64d89bdbcb9f1c5b7041fa1fb5", @"/Views/Studen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792ef5c687352aadb354ab4da2dda25055305126", @"/Views/_ViewImports.cshtml")]
    public class Views_Studen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdmissionSystem.Model.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d6fa095f6e83e64d89bdbcb9f1c5b7041fa1fb54040", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.high_school_certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Father_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Grandfather_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mother_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Father_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Grandfather_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mother_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nick_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Marital_status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Civil_Registriation_City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Civil_Registrition_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Passport_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Identity_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Full_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Current_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 85 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Home_s_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 88 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Identity_front_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 91 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Identity_back_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 97 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.high_school_certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.First_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Father_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Grandfather_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mother_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.First_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Father_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Grandfather_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mother_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nick_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Marital_status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Civil_Registriation_City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Civil_Registrition_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Passport_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 154 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identity_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 157 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Full_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 160 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 163 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Current_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 166 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 169 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Home_s_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 172 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identity_front_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 175 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identity_back_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 178 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 179 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 180 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 183 "C:\Users\planet\Desktop\Terminate\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdmissionSystem.Model.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
