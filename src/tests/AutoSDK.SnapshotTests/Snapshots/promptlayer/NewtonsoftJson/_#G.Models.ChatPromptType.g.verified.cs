//HintName: G.Models.ChatPromptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: chat
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatPromptType
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
    public static class ChatPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatPromptType value)
        {
            return value switch
            {
                ChatPromptType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatPromptType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ChatPromptType.Chat,
                _ => null,
            };
        }
    }
}