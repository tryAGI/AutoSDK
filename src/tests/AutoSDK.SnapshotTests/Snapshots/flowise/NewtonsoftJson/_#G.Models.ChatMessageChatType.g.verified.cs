//HintName: G.Models.ChatMessageChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: INTERNAL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageChatType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXTERNAL")]
        External,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INTERNAL")]
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageChatType value)
        {
            return value switch
            {
                ChatMessageChatType.External => "EXTERNAL",
                ChatMessageChatType.Internal => "INTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageChatType? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => ChatMessageChatType.External,
                "INTERNAL" => ChatMessageChatType.Internal,
                _ => null,
            };
        }
    }
}