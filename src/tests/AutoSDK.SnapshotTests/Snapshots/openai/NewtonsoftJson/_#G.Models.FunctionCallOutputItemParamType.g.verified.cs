//HintName: G.Models.FunctionCallOutputItemParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the function tool call output. Always `function_call_output`.<br/>
    /// Default Value: function_call_output
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionCallOutputItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call_output")]
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputItemParamType value)
        {
            return value switch
            {
                FunctionCallOutputItemParamType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => FunctionCallOutputItemParamType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}