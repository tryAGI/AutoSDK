//HintName: G.Models.RealtimeConversationItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier for the API object being returned - always `realtime.item`.
    /// </summary>
    public enum RealtimeConversationItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemObject value)
        {
            return value switch
            {
                RealtimeConversationItemObject.RealtimeItem => "realtime.item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.item" => RealtimeConversationItemObject.RealtimeItem,
                _ => null,
            };
        }
    }
}