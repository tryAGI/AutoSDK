//HintName: G.Models.ResponseFileSearchCallCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.file_search_call.completed`.
    /// </summary>
    public enum ResponseFileSearchCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFileSearchCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFileSearchCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFileSearchCallCompletedEventType value)
        {
            return value switch
            {
                ResponseFileSearchCallCompletedEventType.ResponseFileSearchCallCompleted => "response.file_search_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFileSearchCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.file_search_call.completed" => ResponseFileSearchCallCompletedEventType.ResponseFileSearchCallCompleted,
                _ => null,
            };
        }
    }
}