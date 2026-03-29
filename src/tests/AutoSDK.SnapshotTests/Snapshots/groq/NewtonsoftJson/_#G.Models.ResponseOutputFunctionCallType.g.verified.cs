//HintName: G.Models.ResponseOutputFunctionCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the function call. Always `function_call`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseOutputFunctionCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputFunctionCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputFunctionCallType value)
        {
            return value switch
            {
                ResponseOutputFunctionCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputFunctionCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponseOutputFunctionCallType.FunctionCall,
                _ => null,
            };
        }
    }
}