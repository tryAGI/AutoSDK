//HintName: G.Models.FallbackSpeechmaticsTranscriberNumeralStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This controls how numbers, dates, currencies, and other entities are formatted in the transcription output.<br/>
    /// @default 'written'<br/>
    /// Default Value: written<br/>
    /// Example: spoken
    /// </summary>
    public enum FallbackSpeechmaticsTranscriberNumeralStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Spoken,
        /// <summary>
        /// 
        /// </summary>
        Written,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSpeechmaticsTranscriberNumeralStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSpeechmaticsTranscriberNumeralStyle value)
        {
            return value switch
            {
                FallbackSpeechmaticsTranscriberNumeralStyle.Spoken => "spoken",
                FallbackSpeechmaticsTranscriberNumeralStyle.Written => "written",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSpeechmaticsTranscriberNumeralStyle? ToEnum(string value)
        {
            return value switch
            {
                "spoken" => FallbackSpeechmaticsTranscriberNumeralStyle.Spoken,
                "written" => FallbackSpeechmaticsTranscriberNumeralStyle.Written,
                _ => null,
            };
        }
    }
}