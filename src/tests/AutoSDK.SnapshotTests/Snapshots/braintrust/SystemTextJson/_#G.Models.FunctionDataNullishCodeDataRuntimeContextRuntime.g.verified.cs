//HintName: G.Models.FunctionDataNullishCodeDataRuntimeContextRuntime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataNullishCodeDataRuntimeContextRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        Browser,
        /// <summary>
        /// 
        /// </summary>
        Node,
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        Quickjs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishCodeDataRuntimeContextRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishCodeDataRuntimeContextRuntime value)
        {
            return value switch
            {
                FunctionDataNullishCodeDataRuntimeContextRuntime.Browser => "browser",
                FunctionDataNullishCodeDataRuntimeContextRuntime.Node => "node",
                FunctionDataNullishCodeDataRuntimeContextRuntime.Python => "python",
                FunctionDataNullishCodeDataRuntimeContextRuntime.Quickjs => "quickjs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishCodeDataRuntimeContextRuntime? ToEnum(string value)
        {
            return value switch
            {
                "browser" => FunctionDataNullishCodeDataRuntimeContextRuntime.Browser,
                "node" => FunctionDataNullishCodeDataRuntimeContextRuntime.Node,
                "python" => FunctionDataNullishCodeDataRuntimeContextRuntime.Python,
                "quickjs" => FunctionDataNullishCodeDataRuntimeContextRuntime.Quickjs,
                _ => null,
            };
        }
    }
}