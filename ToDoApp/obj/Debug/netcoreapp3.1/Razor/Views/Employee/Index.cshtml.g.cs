#pragma checksum "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9fb9b8f0093c619db5db79b11cbe17640c6046f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9fb9b8f0093c619db5db79b11cbe17640c6046f", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb3bc7601ce7e26bda3c02a3c58280a89594878", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeTaskViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "e.Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<h2>---Employees---</h2>\n");
#nullable restore
#line 4 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
 foreach (Employee e in Model.Employees)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 6 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
Write(e.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 7 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
Write(e.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
#nullable restore
#line 7 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
                //<a asp-action="Delete" asp-controller="Employee" asp-route-id="@e.Id"> <button>Remove From Employee </button> </a>

 //<button type="button" asp-action="Delete" asp-controller="Employee" asp-route-id="@e.Id">Delete Employee</button>




#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9fb9b8f0093c619db5db79b11cbe17640c6046f5957", async() => {
                WriteLiteral("<p>Delete this entry</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
                                                   WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 13 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9fb9b8f0093c619db5db79b11cbe17640c6046f8758", async() => {
                WriteLiteral("<p>Update</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n<p>-----------------------------</p>\n<h2>Tasks</h2>\n");
#nullable restore
#line 20 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
 foreach (ToDo t in Model.ToDos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 22 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 22 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\Employee\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeTaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
