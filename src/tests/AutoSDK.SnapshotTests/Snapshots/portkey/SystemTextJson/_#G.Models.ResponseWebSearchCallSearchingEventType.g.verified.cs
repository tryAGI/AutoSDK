//HintName: G.Models.ResponseWebSearchCallSearchingEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.web_search_call.searching`.
    /// </summary>
    public enum ResponseWebSearchCallSearchingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseWebSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseWebSearchCallSearchingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebSearchCallSearchingEventType value)
        {
            return value switch
            {
                ResponseWebSearchCallSearchingEventType.ResponseWebSearchCallSearching => "response.web_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebSearchCallSearchingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.searching" => ResponseWebSearchCallSearchingEventType.ResponseWebSearchCallSearching,
                _ => null,
            };
        }
    }
}