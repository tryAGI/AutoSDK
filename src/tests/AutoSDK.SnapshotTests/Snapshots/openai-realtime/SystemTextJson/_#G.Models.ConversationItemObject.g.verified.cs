//HintName: G.Models.ConversationItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum ConversationItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemObject value)
        {
            return value switch
            {
                ConversationItemObject.RealtimeItem => "realtime.item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.item" => ConversationItemObject.RealtimeItem,
                _ => null,
            };
        }
    }
}