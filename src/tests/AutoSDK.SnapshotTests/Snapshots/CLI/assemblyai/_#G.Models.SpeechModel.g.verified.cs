//HintName: G.Models.SpeechModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The speech model to use for the transcription.
    /// </summary>
    public enum SpeechModel
    {
        /// <summary>
        /// The best model optimized for accuracy.
        /// </summary>
        Best,
        /// <summary>
        /// A lightweight, lower cost model for a wide range of languages.
        /// </summary>
        Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechModel value)
        {
            return value switch
            {
                SpeechModel.Best => "best",
                SpeechModel.Nano => "nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechModel? ToEnum(string value)
        {
            return value switch
            {
                "best" => SpeechModel.Best,
                "nano" => SpeechModel.Nano,
                _ => null,
            };
        }
    }
}