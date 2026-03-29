//HintName: G.Models.ResponseWebSearchCallInProgressEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.web_search_call.in_progress`.
    /// </summary>
    public enum ResponseWebSearchCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseWebSearchCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseWebSearchCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebSearchCallInProgressEventType value)
        {
            return value switch
            {
                ResponseWebSearchCallInProgressEventType.ResponseWebSearchCallInProgress => "response.web_search_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebSearchCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.in_progress" => ResponseWebSearchCallInProgressEventType.ResponseWebSearchCallInProgress,
                _ => null,
            };
        }
    }
}