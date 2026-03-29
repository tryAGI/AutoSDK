//HintName: G.Models.ResponseWebSearchCallCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.web_search_call.completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseWebSearchCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.web_search_call.completed")]
        ResponseWebSearchCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseWebSearchCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebSearchCallCompletedEventType value)
        {
            return value switch
            {
                ResponseWebSearchCallCompletedEventType.ResponseWebSearchCallCompleted => "response.web_search_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebSearchCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.completed" => ResponseWebSearchCallCompletedEventType.ResponseWebSearchCallCompleted,
                _ => null,
            };
        }
    }
}