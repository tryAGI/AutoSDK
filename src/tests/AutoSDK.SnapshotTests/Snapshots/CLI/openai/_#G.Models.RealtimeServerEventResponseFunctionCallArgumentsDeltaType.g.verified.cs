//HintName: G.Models.RealtimeServerEventResponseFunctionCallArgumentsDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.function_call_arguments.delta`.
    /// </summary>
    public enum RealtimeServerEventResponseFunctionCallArgumentsDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseFunctionCallArgumentsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseFunctionCallArgumentsDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseFunctionCallArgumentsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => RealtimeServerEventResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}