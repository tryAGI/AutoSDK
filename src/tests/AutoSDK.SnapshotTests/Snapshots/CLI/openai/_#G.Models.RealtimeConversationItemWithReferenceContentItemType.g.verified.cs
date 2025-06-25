//HintName: G.Models.RealtimeConversationItemWithReferenceContentItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content type (`input_text`, `input_audio`, `item_reference`, `text`).
    /// </summary>
    public enum RealtimeConversationItemWithReferenceContentItemType
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
    public static class RealtimeConversationItemWithReferenceContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemWithReferenceContentItemType value)
        {
            return value switch
            {
                RealtimeConversationItemWithReferenceContentItemType.InputAudio => "input_audio",
                RealtimeConversationItemWithReferenceContentItemType.InputText => "input_text",
                RealtimeConversationItemWithReferenceContentItemType.ItemReference => "item_reference",
                RealtimeConversationItemWithReferenceContentItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemWithReferenceContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => RealtimeConversationItemWithReferenceContentItemType.InputAudio,
                "input_text" => RealtimeConversationItemWithReferenceContentItemType.InputText,
                "item_reference" => RealtimeConversationItemWithReferenceContentItemType.ItemReference,
                "text" => RealtimeConversationItemWithReferenceContentItemType.Text,
                _ => null,
            };
        }
    }
}