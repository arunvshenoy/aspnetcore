// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_TransitionsInTagHelperAttributes_DesignTime
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::TestNamespace.PTagHelper __TestNamespace_PTagHelper;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
global::System.Object __typeHelper = "*, TestAssembly";

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
   
    var @class = "container-fluid";
    var @int = 1;

#line default
#line hidden
#nullable disable
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#nullable restore
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 1337;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#nullable restore
#line 8 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
      __o = @class;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 42;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#nullable restore
#line 9 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 42 + @int;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = int;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#nullable restore
#line 11 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = (@int);

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
             __o = @class;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 4 * @(@int + 2);

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
