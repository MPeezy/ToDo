#pragma checksum "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19271b004eefa0b1fef822a3f60b0343844448fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_AssignTask), @"mvc.1.0.view", @"/Views/ToDo/AssignTask.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19271b004eefa0b1fef822a3f60b0343844448fe", @"/Views/ToDo/AssignTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb3bc7601ce7e26bda3c02a3c58280a89594878", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_AssignTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeTaskViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Task Assignment Form</h2>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19271b004eefa0b1fef822a3f60b0343844448fe3932", async() => {
                WriteLiteral("\n    <p>Select an Employee</p>\n    <select name=\"employeeId\">\n");
#nullable restore
#line 6 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
         foreach (Employee e in Model.Employees)
        {

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19271b004eefa0b1fef822a3f60b0343844448fe4553", async() => {
#nullable restore
#line 8 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
                 Write(e.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
   WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\n\n    <br />\n    <p>Select a Task to assign the Employee</p>\n\n    <select name=\"toDoId\">\n");
#nullable restore
#line 16 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
         foreach (ToDo t in Model.ToDos)
        {

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19271b004eefa0b1fef822a3f60b0343844448fe7198", async() => {
#nullable restore
#line 18 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
                 Write(t.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
   WriteLiteral(t.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 19 "C:\Users\MPatton5\OneDrive - Knex\Downloads\DevBuildOct2021-main (13)\DevBuildOct2021-main\Week 11 - More on Dapper\ToDoApp\ToDoApp\Views\ToDo\AssignTask.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\n\n\n");
                WriteLiteral("\n\n\n\n");
                WriteLiteral("\n\n\n\n    <input type=\"submit\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
