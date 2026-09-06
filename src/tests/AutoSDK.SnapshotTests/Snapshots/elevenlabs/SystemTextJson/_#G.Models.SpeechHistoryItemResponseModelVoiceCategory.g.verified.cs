//HintName: G.Models.SpeechHistoryItemResponseModelVoiceCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechHistoryItemResponseModelVoiceCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Premade,
        /// <summary>
        /// 
        /// </summary>
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechHistoryItemResponseModelVoiceCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechHistoryItemResponseModelVoiceCategory value)
        {
            return value switch
            {
                SpeechHistoryItemResponseModelVoiceCategory.Cloned => "cloned",
                SpeechHistoryItemResponseModelVoiceCategory.Generated => "generated",
                SpeechHistoryItemResponseModelVoiceCategory.Premade => "premade",
                SpeechHistoryItemResponseModelVoiceCategory.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechHistoryItemResponseModelVoiceCategory? ToEnum(string value)
        {
            return value switch
            {
                "cloned" => SpeechHistoryItemResponseModelVoiceCategory.Cloned,
                "generated" => SpeechHistoryItemResponseModelVoiceCategory.Generated,
                "premade" => SpeechHistoryItemResponseModelVoiceCategory.Premade,
                "professional" => SpeechHistoryItemResponseModelVoiceCategory.Professional,
                _ => null,
            };
        }
    }
}