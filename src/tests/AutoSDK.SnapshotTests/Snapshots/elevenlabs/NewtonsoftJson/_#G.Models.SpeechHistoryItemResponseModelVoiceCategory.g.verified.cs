//HintName: G.Models.SpeechHistoryItemResponseModelVoiceCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of the voice. Either 'premade', 'cloned', 'generated' or 'professional'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechHistoryItemResponseModelVoiceCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premade")]
        Premade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloned")]
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated")]
        Generated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="professional")]
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
                SpeechHistoryItemResponseModelVoiceCategory.Premade => "premade",
                SpeechHistoryItemResponseModelVoiceCategory.Cloned => "cloned",
                SpeechHistoryItemResponseModelVoiceCategory.Generated => "generated",
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
                "premade" => SpeechHistoryItemResponseModelVoiceCategory.Premade,
                "cloned" => SpeechHistoryItemResponseModelVoiceCategory.Cloned,
                "generated" => SpeechHistoryItemResponseModelVoiceCategory.Generated,
                "professional" => SpeechHistoryItemResponseModelVoiceCategory.Professional,
                _ => null,
            };
        }
    }
}