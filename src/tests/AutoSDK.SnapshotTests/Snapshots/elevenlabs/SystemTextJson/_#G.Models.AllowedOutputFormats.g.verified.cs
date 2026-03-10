//HintName: G.Models.AllowedOutputFormats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AllowedOutputFormats
    {
        /// <summary>
        /// 
        /// </summary>
        Mp32205032,
        /// <summary>
        /// 
        /// </summary>
        Mp32400048,
        /// <summary>
        /// 
        /// </summary>
        Mp34410032,
        /// <summary>
        /// 
        /// </summary>
        Mp34410064,
        /// <summary>
        /// 
        /// </summary>
        Mp34410096,
        /// <summary>
        /// 
        /// </summary>
        Mp344100128,
        /// <summary>
        /// 
        /// </summary>
        Mp344100192,
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
        Pcm32000,
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
        /// <summary>
        /// 
        /// </summary>
        Alaw8000,
        /// <summary>
        /// 
        /// </summary>
        Opus4800032,
        /// <summary>
        /// 
        /// </summary>
        Opus4800064,
        /// <summary>
        /// 
        /// </summary>
        Opus4800096,
        /// <summary>
        /// 
        /// </summary>
        Opus48000128,
        /// <summary>
        /// 
        /// </summary>
        Opus48000192,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllowedOutputFormatsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedOutputFormats value)
        {
            return value switch
            {
                AllowedOutputFormats.Mp32205032 => "mp3_22050_32",
                AllowedOutputFormats.Mp32400048 => "mp3_24000_48",
                AllowedOutputFormats.Mp34410032 => "mp3_44100_32",
                AllowedOutputFormats.Mp34410064 => "mp3_44100_64",
                AllowedOutputFormats.Mp34410096 => "mp3_44100_96",
                AllowedOutputFormats.Mp344100128 => "mp3_44100_128",
                AllowedOutputFormats.Mp344100192 => "mp3_44100_192",
                AllowedOutputFormats.Pcm8000 => "pcm_8000",
                AllowedOutputFormats.Pcm16000 => "pcm_16000",
                AllowedOutputFormats.Pcm22050 => "pcm_22050",
                AllowedOutputFormats.Pcm24000 => "pcm_24000",
                AllowedOutputFormats.Pcm32000 => "pcm_32000",
                AllowedOutputFormats.Pcm44100 => "pcm_44100",
                AllowedOutputFormats.Pcm48000 => "pcm_48000",
                AllowedOutputFormats.Ulaw8000 => "ulaw_8000",
                AllowedOutputFormats.Alaw8000 => "alaw_8000",
                AllowedOutputFormats.Opus4800032 => "opus_48000_32",
                AllowedOutputFormats.Opus4800064 => "opus_48000_64",
                AllowedOutputFormats.Opus4800096 => "opus_48000_96",
                AllowedOutputFormats.Opus48000128 => "opus_48000_128",
                AllowedOutputFormats.Opus48000192 => "opus_48000_192",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedOutputFormats? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => AllowedOutputFormats.Mp32205032,
                "mp3_24000_48" => AllowedOutputFormats.Mp32400048,
                "mp3_44100_32" => AllowedOutputFormats.Mp34410032,
                "mp3_44100_64" => AllowedOutputFormats.Mp34410064,
                "mp3_44100_96" => AllowedOutputFormats.Mp34410096,
                "mp3_44100_128" => AllowedOutputFormats.Mp344100128,
                "mp3_44100_192" => AllowedOutputFormats.Mp344100192,
                "pcm_8000" => AllowedOutputFormats.Pcm8000,
                "pcm_16000" => AllowedOutputFormats.Pcm16000,
                "pcm_22050" => AllowedOutputFormats.Pcm22050,
                "pcm_24000" => AllowedOutputFormats.Pcm24000,
                "pcm_32000" => AllowedOutputFormats.Pcm32000,
                "pcm_44100" => AllowedOutputFormats.Pcm44100,
                "pcm_48000" => AllowedOutputFormats.Pcm48000,
                "ulaw_8000" => AllowedOutputFormats.Ulaw8000,
                "alaw_8000" => AllowedOutputFormats.Alaw8000,
                "opus_48000_32" => AllowedOutputFormats.Opus4800032,
                "opus_48000_64" => AllowedOutputFormats.Opus4800064,
                "opus_48000_96" => AllowedOutputFormats.Opus4800096,
                "opus_48000_128" => AllowedOutputFormats.Opus48000128,
                "opus_48000_192" => AllowedOutputFormats.Opus48000192,
                _ => null,
            };
        }
    }
}