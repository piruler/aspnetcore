// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            {
                __Blazor.Test.TestComponent.TypeInference.CreateGrid_0_CaptureParameters(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
               Array.Empty<DateTime>()

#line default
#line hidden
#nullable disable
                , out var __typeInferenceArg_0___arg0);
                __Blazor.Test.TestComponent.TypeInference.CreateGrid_0(__builder, 0, 1, __typeInferenceArg_0___arg0, 2, (__builder2) => {
                    {
                        __Blazor.Test.TestComponent.TypeInference.CreateColumn_1_CaptureParameters(__typeInferenceArg_0___arg0, out var __typeInferenceArg_1___syntheticArg0);
                        __Blazor.Test.TestComponent.TypeInference.CreateColumn_1(__builder2, 3, __typeInferenceArg_1___syntheticArg0, 4, (context) => (__builder3) => {
                            __builder3.AddContent(5, 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                  context.Year

#line default
#line hidden
#nullable disable
                            );
                        }
                        );
                        __typeInferenceArg_1___syntheticArg0 = default;
                    }
                }
                );
                __typeInferenceArg_0___arg0 = default;
            }
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Test.Grid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }

        public static void CreateGrid_0_CaptureParameters<TItem>(global::System.Collections.Generic.IEnumerable<TItem> __arg0, out global::System.Collections.Generic.IEnumerable<TItem> __arg0_out)
        {
            __arg0_out = __arg0;
        }
        public static void CreateColumn_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, System.Collections.Generic.IEnumerable<TItem> __syntheticArg0, int __seq0, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg0)
        {
        __builder.OpenComponent<global::Test.Column<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ChildContent", __arg0);
        __builder.CloseComponent();
        }

        public static void CreateColumn_1_CaptureParameters<TItem>(System.Collections.Generic.IEnumerable<TItem> __syntheticArg0, out System.Collections.Generic.IEnumerable<TItem> __syntheticArg0_out)
        {
            __syntheticArg0_out = __syntheticArg0;
        }
    }
}
#pragma warning restore 1591
