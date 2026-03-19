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
        InputText,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Audio,
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
                ConversationItemContentPartType.InputText => "input_text",
                ConversationItemContentPartType.InputAudio => "input_audio",
                ConversationItemContentPartType.Text => "text",
                ConversationItemContentPartType.Audio => "audio",
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
                "input_text" => ConversationItemContentPartType.InputText,
                "input_audio" => ConversationItemContentPartType.InputAudio,
                "text" => ConversationItemContentPartType.Text,
                "audio" => ConversationItemContentPartType.Audio,
                _ => null,
            };
        }
    }
}