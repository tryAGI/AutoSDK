//HintName: G.Models.ResponseCodeInterpreterCallInterpretingEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call.interpreting`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseCodeInterpreterCallInterpretingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.interpreting")]
        ResponseCodeInterpreterCallInterpreting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCodeInterpreterCallInterpretingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCodeInterpreterCallInterpretingEventType value)
        {
            return value switch
            {
                ResponseCodeInterpreterCallInterpretingEventType.ResponseCodeInterpreterCallInterpreting => "response.code_interpreter_call.interpreting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCodeInterpreterCallInterpretingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.interpreting" => ResponseCodeInterpreterCallInterpretingEventType.ResponseCodeInterpreterCallInterpreting,
                _ => null,
            };
        }
    }
}