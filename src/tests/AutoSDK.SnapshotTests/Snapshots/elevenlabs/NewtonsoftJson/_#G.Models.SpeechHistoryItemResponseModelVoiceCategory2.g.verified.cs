//HintName: G.Models.SpeechHistoryItemResponseModelVoiceCategory2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechHistoryItemResponseModelVoiceCategory2
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
    public static class SpeechHistoryItemResponseModelVoiceCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechHistoryItemResponseModelVoiceCategory2 value)
        {
            return value switch
            {
                SpeechHistoryItemResponseModelVoiceCategory2.Premade => "premade",
                SpeechHistoryItemResponseModelVoiceCategory2.Cloned => "cloned",
                SpeechHistoryItemResponseModelVoiceCategory2.Generated => "generated",
                SpeechHistoryItemResponseModelVoiceCategory2.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechHistoryItemResponseModelVoiceCategory2? ToEnum(string value)
        {
            return value switch
            {
                "premade" => SpeechHistoryItemResponseModelVoiceCategory2.Premade,
                "cloned" => SpeechHistoryItemResponseModelVoiceCategory2.Cloned,
                "generated" => SpeechHistoryItemResponseModelVoiceCategory2.Generated,
                "professional" => SpeechHistoryItemResponseModelVoiceCategory2.Professional,
                _ => null,
            };
        }
    }
}