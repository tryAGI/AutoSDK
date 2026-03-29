//HintName: G.Models.FunctionDataCodeDataRuntimeContextRuntime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDataCodeDataRuntimeContextRuntime
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
    public static class FunctionDataCodeDataRuntimeContextRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataCodeDataRuntimeContextRuntime value)
        {
            return value switch
            {
                FunctionDataCodeDataRuntimeContextRuntime.Browser => "browser",
                FunctionDataCodeDataRuntimeContextRuntime.Node => "node",
                FunctionDataCodeDataRuntimeContextRuntime.Python => "python",
                FunctionDataCodeDataRuntimeContextRuntime.Quickjs => "quickjs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataCodeDataRuntimeContextRuntime? ToEnum(string value)
        {
            return value switch
            {
                "browser" => FunctionDataCodeDataRuntimeContextRuntime.Browser,
                "node" => FunctionDataCodeDataRuntimeContextRuntime.Node,
                "python" => FunctionDataCodeDataRuntimeContextRuntime.Python,
                "quickjs" => FunctionDataCodeDataRuntimeContextRuntime.Quickjs,
                _ => null,
            };
        }
    }
}