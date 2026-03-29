//HintName: G.Models.SpeechmaticsTranscriberNumeralStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This controls how numbers, dates, currencies, and other entities are formatted in the transcription output.<br/>
    /// @default 'written'<br/>
    /// Default Value: written<br/>
    /// Example: spoken
    /// </summary>
    public enum SpeechmaticsTranscriberNumeralStyle
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
    public static class SpeechmaticsTranscriberNumeralStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechmaticsTranscriberNumeralStyle value)
        {
            return value switch
            {
                SpeechmaticsTranscriberNumeralStyle.Spoken => "spoken",
                SpeechmaticsTranscriberNumeralStyle.Written => "written",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechmaticsTranscriberNumeralStyle? ToEnum(string value)
        {
            return value switch
            {
                "spoken" => SpeechmaticsTranscriberNumeralStyle.Spoken,
                "written" => SpeechmaticsTranscriberNumeralStyle.Written,
                _ => null,
            };
        }
    }
}