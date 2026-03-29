//HintName: G.Models.FunctionIdInlineCodeInlineContextRuntime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionIdInlineCodeInlineContextRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="browser")]
        Browser,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="node")]
        Node,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="python")]
        Python,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="quickjs")]
        Quickjs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionIdInlineCodeInlineContextRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionIdInlineCodeInlineContextRuntime value)
        {
            return value switch
            {
                FunctionIdInlineCodeInlineContextRuntime.Browser => "browser",
                FunctionIdInlineCodeInlineContextRuntime.Node => "node",
                FunctionIdInlineCodeInlineContextRuntime.Python => "python",
                FunctionIdInlineCodeInlineContextRuntime.Quickjs => "quickjs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionIdInlineCodeInlineContextRuntime? ToEnum(string value)
        {
            return value switch
            {
                "browser" => FunctionIdInlineCodeInlineContextRuntime.Browser,
                "node" => FunctionIdInlineCodeInlineContextRuntime.Node,
                "python" => FunctionIdInlineCodeInlineContextRuntime.Python,
                "quickjs" => FunctionIdInlineCodeInlineContextRuntime.Quickjs,
                _ => null,
            };
        }
    }
}