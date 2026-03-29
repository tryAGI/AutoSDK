//HintName: G.Models.ResponseFileSearchCallSearchingEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.file_search_call.searching`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFileSearchCallSearchingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.file_search_call.searching")]
        ResponseFileSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFileSearchCallSearchingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFileSearchCallSearchingEventType value)
        {
            return value switch
            {
                ResponseFileSearchCallSearchingEventType.ResponseFileSearchCallSearching => "response.file_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFileSearchCallSearchingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.file_search_call.searching" => ResponseFileSearchCallSearchingEventType.ResponseFileSearchCallSearching,
                _ => null,
            };
        }
    }
}