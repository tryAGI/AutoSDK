//HintName: G.Models.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunwayPreset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "runway-preset" => CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}