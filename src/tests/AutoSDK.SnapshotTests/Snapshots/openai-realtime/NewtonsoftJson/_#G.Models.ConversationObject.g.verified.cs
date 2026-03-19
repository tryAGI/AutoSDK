//HintName: G.Models.ConversationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="realtime.conversation")]
        RealtimeConversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationObject value)
        {
            return value switch
            {
                ConversationObject.RealtimeConversation => "realtime.conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.conversation" => ConversationObject.RealtimeConversation,
                _ => null,
            };
        }
    }
}