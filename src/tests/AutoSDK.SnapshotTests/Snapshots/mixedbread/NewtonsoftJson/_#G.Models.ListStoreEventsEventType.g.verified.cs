//HintName: G.Models.ListStoreEventsEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of event to list
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListStoreEventsEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ingestion")]
        Ingestion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search")]
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListStoreEventsEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListStoreEventsEventType value)
        {
            return value switch
            {
                ListStoreEventsEventType.Ingestion => "ingestion",
                ListStoreEventsEventType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListStoreEventsEventType? ToEnum(string value)
        {
            return value switch
            {
                "ingestion" => ListStoreEventsEventType.Ingestion,
                "search" => ListStoreEventsEventType.Search,
                _ => null,
            };
        }
    }
}