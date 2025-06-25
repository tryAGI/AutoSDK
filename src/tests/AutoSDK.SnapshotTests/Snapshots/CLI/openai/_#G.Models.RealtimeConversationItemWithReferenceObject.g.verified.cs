//HintName: G.Models.RealtimeConversationItemWithReferenceObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier for the API object being returned - always `realtime.item`.
    /// </summary>
    public enum RealtimeConversationItemWithReferenceObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemWithReferenceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemWithReferenceObject value)
        {
            return value switch
            {
                RealtimeConversationItemWithReferenceObject.RealtimeItem => "realtime.item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemWithReferenceObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.item" => RealtimeConversationItemWithReferenceObject.RealtimeItem,
                _ => null,
            };
        }
    }
}