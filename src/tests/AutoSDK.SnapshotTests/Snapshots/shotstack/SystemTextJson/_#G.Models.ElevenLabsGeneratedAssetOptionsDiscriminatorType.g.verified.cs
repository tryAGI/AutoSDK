//HintName: G.Models.ElevenLabsGeneratedAssetOptionsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ElevenLabsGeneratedAssetOptionsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsGeneratedAssetOptionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsGeneratedAssetOptionsDiscriminatorType value)
        {
            return value switch
            {
                ElevenLabsGeneratedAssetOptionsDiscriminatorType.TextToSpeech => "text-to-speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsGeneratedAssetOptionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-speech" => ElevenLabsGeneratedAssetOptionsDiscriminatorType.TextToSpeech,
                _ => null,
            };
        }
    }
}