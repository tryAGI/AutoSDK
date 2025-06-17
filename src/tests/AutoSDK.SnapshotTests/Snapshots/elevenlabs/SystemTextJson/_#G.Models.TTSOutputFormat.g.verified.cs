//HintName: G.Models.TTSOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm8000,
        /// <summary>
        /// 
        /// </summary>
        Pcm16000,
        /// <summary>
        /// 
        /// </summary>
        Pcm22050,
        /// <summary>
        /// 
        /// </summary>
        Pcm24000,
        /// <summary>
        /// 
        /// </summary>
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        Pcm48000,
        /// <summary>
        /// 
        /// </summary>
        Ulaw8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSOutputFormat value)
        {
            return value switch
            {
                TTSOutputFormat.Pcm8000 => "pcm_8000",
                TTSOutputFormat.Pcm16000 => "pcm_16000",
                TTSOutputFormat.Pcm22050 => "pcm_22050",
                TTSOutputFormat.Pcm24000 => "pcm_24000",
                TTSOutputFormat.Pcm44100 => "pcm_44100",
                TTSOutputFormat.Pcm48000 => "pcm_48000",
                TTSOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_8000" => TTSOutputFormat.Pcm8000,
                "pcm_16000" => TTSOutputFormat.Pcm16000,
                "pcm_22050" => TTSOutputFormat.Pcm22050,
                "pcm_24000" => TTSOutputFormat.Pcm24000,
                "pcm_44100" => TTSOutputFormat.Pcm44100,
                "pcm_48000" => TTSOutputFormat.Pcm48000,
                "ulaw_8000" => TTSOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}