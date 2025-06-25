//HintName: G.Models.RealtimeServerEventResponseFunctionCallArgumentsDoneType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.function_call_arguments.done`.
    /// </summary>
    public enum RealtimeServerEventResponseFunctionCallArgumentsDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseFunctionCallArgumentsDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseFunctionCallArgumentsDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseFunctionCallArgumentsDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => RealtimeServerEventResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}