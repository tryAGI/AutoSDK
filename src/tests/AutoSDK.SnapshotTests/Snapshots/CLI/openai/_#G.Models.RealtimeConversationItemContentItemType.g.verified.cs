//HintName: G.Models.RealtimeConversationItemContentItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content type (`input_text`, `input_audio`, `item_reference`, `text`).
    /// </summary>
    public enum RealtimeConversationItemContentItemType
    {
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
        ItemReference,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemContentItemType value)
        {
            return value switch
            {
                RealtimeConversationItemContentItemType.InputAudio => "input_audio",
                RealtimeConversationItemContentItemType.InputText => "input_text",
                RealtimeConversationItemContentItemType.ItemReference => "item_reference",
                RealtimeConversationItemContentItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => RealtimeConversationItemContentItemType.InputAudio,
                "input_text" => RealtimeConversationItemContentItemType.InputText,
                "item_reference" => RealtimeConversationItemContentItemType.ItemReference,
                "text" => RealtimeConversationItemContentItemType.Text,
                _ => null,
            };
        }
    }
}