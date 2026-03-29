//HintName: G.Models.ResponseFunctionCallOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the function tool call output. Always `function_call_output`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFunctionCallOutputType
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
    public static class ResponseFunctionCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallOutputType value)
        {
            return value switch
            {
                ResponseFunctionCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => ResponseFunctionCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}