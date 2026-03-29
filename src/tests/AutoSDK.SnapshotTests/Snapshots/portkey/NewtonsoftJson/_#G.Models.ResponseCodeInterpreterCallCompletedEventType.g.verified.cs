//HintName: G.Models.ResponseCodeInterpreterCallCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call.completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseCodeInterpreterCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.completed")]
        ResponseCodeInterpreterCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCodeInterpreterCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCodeInterpreterCallCompletedEventType value)
        {
            return value switch
            {
                ResponseCodeInterpreterCallCompletedEventType.ResponseCodeInterpreterCallCompleted => "response.code_interpreter_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCodeInterpreterCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.completed" => ResponseCodeInterpreterCallCompletedEventType.ResponseCodeInterpreterCallCompleted,
                _ => null,
            };
        }
    }
}