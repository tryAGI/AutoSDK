//HintName: G.Models.TranscribeSpeechRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operation mode (saaras:v3 only)<br/>
    /// Default Value: transcribe
    /// </summary>
    public enum TranscribeSpeechRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Codemix,
        /// <summary>
        /// 
        /// </summary>
        Transcribe,
        /// <summary>
        /// 
        /// </summary>
        Translate,
        /// <summary>
        /// 
        /// </summary>
        Translit,
        /// <summary>
        /// 
        /// </summary>
        Verbatim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscribeSpeechRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscribeSpeechRequestMode value)
        {
            return value switch
            {
                TranscribeSpeechRequestMode.Codemix => "codemix",
                TranscribeSpeechRequestMode.Transcribe => "transcribe",
                TranscribeSpeechRequestMode.Translate => "translate",
                TranscribeSpeechRequestMode.Translit => "translit",
                TranscribeSpeechRequestMode.Verbatim => "verbatim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscribeSpeechRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "codemix" => TranscribeSpeechRequestMode.Codemix,
                "transcribe" => TranscribeSpeechRequestMode.Transcribe,
                "translate" => TranscribeSpeechRequestMode.Translate,
                "translit" => TranscribeSpeechRequestMode.Translit,
                "verbatim" => TranscribeSpeechRequestMode.Verbatim,
                _ => null,
            };
        }
    }
}