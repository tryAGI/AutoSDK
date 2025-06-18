//HintName: G.Models.ResponseCodeInterpreterCallCodeDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call_code.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseCodeInterpreterCallCodeDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call_code.delta")]
        ResponseCodeInterpreterCallCodeDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCodeInterpreterCallCodeDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCodeInterpreterCallCodeDeltaEventType value)
        {
            return value switch
            {
                ResponseCodeInterpreterCallCodeDeltaEventType.ResponseCodeInterpreterCallCodeDelta => "response.code_interpreter_call_code.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCodeInterpreterCallCodeDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call_code.delta" => ResponseCodeInterpreterCallCodeDeltaEventType.ResponseCodeInterpreterCallCodeDelta,
                _ => null,
            };
        }
    }
}