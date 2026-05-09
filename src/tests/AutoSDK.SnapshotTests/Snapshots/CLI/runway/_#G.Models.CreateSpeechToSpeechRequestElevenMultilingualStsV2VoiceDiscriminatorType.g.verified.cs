//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunwayPreset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "runway-preset" => CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}