//HintName: G.Models.ResponseFunctionCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the function call. Always `function_call`.
    /// </summary>
    public enum ResponseFunctionCallType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFunctionCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallType value)
        {
            return value switch
            {
                ResponseFunctionCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponseFunctionCallType.FunctionCall,
                _ => null,
            };
        }
    }
}