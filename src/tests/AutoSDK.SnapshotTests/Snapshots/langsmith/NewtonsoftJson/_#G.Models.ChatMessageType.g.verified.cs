//HintName: G.Models.ChatMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: chat
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageType value)
        {
            return value switch
            {
                ChatMessageType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ChatMessageType.Chat,
                _ => null,
            };
        }
    }
}