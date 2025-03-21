//HintName: G.Models.ResponseCodeInterpreterCallInProgressEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call.in_progress`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseCodeInterpreterCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.in_progress")]
        ResponseCodeInterpreterCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCodeInterpreterCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCodeInterpreterCallInProgressEventType value)
        {
            return value switch
            {
                ResponseCodeInterpreterCallInProgressEventType.ResponseCodeInterpreterCallInProgress => "response.code_interpreter_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCodeInterpreterCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.in_progress" => ResponseCodeInterpreterCallInProgressEventType.ResponseCodeInterpreterCallInProgress,
                _ => null,
            };
        }
    }
}