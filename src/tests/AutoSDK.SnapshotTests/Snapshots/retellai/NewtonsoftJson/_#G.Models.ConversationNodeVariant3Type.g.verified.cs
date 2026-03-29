//HintName: G.Models.ConversationNodeVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationNodeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation")]
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationNodeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationNodeVariant3Type value)
        {
            return value switch
            {
                ConversationNodeVariant3Type.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationNodeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => ConversationNodeVariant3Type.Conversation,
                _ => null,
            };
        }
    }
}