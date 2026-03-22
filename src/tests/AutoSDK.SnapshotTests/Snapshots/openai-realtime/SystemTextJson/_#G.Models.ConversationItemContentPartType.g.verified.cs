//HintName: G.Models.ConversationItemContentPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content type.
    /// </summary>
    public enum ConversationItemContentPartType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemContentPartType value)
        {
            return value switch
            {
                ConversationItemContentPartType.Audio => "audio",
                ConversationItemContentPartType.InputAudio => "input_audio",
                ConversationItemContentPartType.InputText => "input_text",
                ConversationItemContentPartType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ConversationItemContentPartType.Audio,
                "input_audio" => ConversationItemContentPartType.InputAudio,
                "input_text" => ConversationItemContentPartType.InputText,
                "text" => ConversationItemContentPartType.Text,
                _ => null,
            };
        }
    }
}