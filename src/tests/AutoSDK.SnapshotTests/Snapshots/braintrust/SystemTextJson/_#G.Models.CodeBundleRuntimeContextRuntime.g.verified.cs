//HintName: G.Models.CodeBundleRuntimeContextRuntime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeBundleRuntimeContextRuntime
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
    public static class CodeBundleRuntimeContextRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleRuntimeContextRuntime value)
        {
            return value switch
            {
                CodeBundleRuntimeContextRuntime.Browser => "browser",
                CodeBundleRuntimeContextRuntime.Node => "node",
                CodeBundleRuntimeContextRuntime.Python => "python",
                CodeBundleRuntimeContextRuntime.Quickjs => "quickjs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleRuntimeContextRuntime? ToEnum(string value)
        {
            return value switch
            {
                "browser" => CodeBundleRuntimeContextRuntime.Browser,
                "node" => CodeBundleRuntimeContextRuntime.Node,
                "python" => CodeBundleRuntimeContextRuntime.Python,
                "quickjs" => CodeBundleRuntimeContextRuntime.Quickjs,
                _ => null,
            };
        }
    }
}