//HintName: G.Models.AllowedOutputFormats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AllowedOutputFormats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alaw_8000")]
        Alaw8000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_22050_32")]
        Mp32205032,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_24000_48")]
        Mp32400048,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_44100_128")]
        Mp344100128,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_44100_192")]
        Mp344100192,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_44100_32")]
        Mp34410032,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_44100_64")]
        Mp34410064,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_44100_96")]
        Mp34410096,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus_48000_128")]
        Opus48000128,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus_48000_192")]
        Opus48000192,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus_48000_32")]
        Opus4800032,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus_48000_64")]
        Opus4800064,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus_48000_96")]
        Opus4800096,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_16000")]
        Pcm16000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_22050")]
        Pcm22050,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_24000")]
        Pcm24000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_32000")]
        Pcm32000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_44100")]
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_48000")]
        Pcm48000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_8000")]
        Pcm8000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ulaw_8000")]
        Ulaw8000,
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
                AllowedOutputFormats.Alaw8000 => "alaw_8000",
                AllowedOutputFormats.Mp32205032 => "mp3_22050_32",
                AllowedOutputFormats.Mp32400048 => "mp3_24000_48",
                AllowedOutputFormats.Mp344100128 => "mp3_44100_128",
                AllowedOutputFormats.Mp344100192 => "mp3_44100_192",
                AllowedOutputFormats.Mp34410032 => "mp3_44100_32",
                AllowedOutputFormats.Mp34410064 => "mp3_44100_64",
                AllowedOutputFormats.Mp34410096 => "mp3_44100_96",
                AllowedOutputFormats.Opus48000128 => "opus_48000_128",
                AllowedOutputFormats.Opus48000192 => "opus_48000_192",
                AllowedOutputFormats.Opus4800032 => "opus_48000_32",
                AllowedOutputFormats.Opus4800064 => "opus_48000_64",
                AllowedOutputFormats.Opus4800096 => "opus_48000_96",
                AllowedOutputFormats.Pcm16000 => "pcm_16000",
                AllowedOutputFormats.Pcm22050 => "pcm_22050",
                AllowedOutputFormats.Pcm24000 => "pcm_24000",
                AllowedOutputFormats.Pcm32000 => "pcm_32000",
                AllowedOutputFormats.Pcm44100 => "pcm_44100",
                AllowedOutputFormats.Pcm48000 => "pcm_48000",
                AllowedOutputFormats.Pcm8000 => "pcm_8000",
                AllowedOutputFormats.Ulaw8000 => "ulaw_8000",
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
                "alaw_8000" => AllowedOutputFormats.Alaw8000,
                "mp3_22050_32" => AllowedOutputFormats.Mp32205032,
                "mp3_24000_48" => AllowedOutputFormats.Mp32400048,
                "mp3_44100_128" => AllowedOutputFormats.Mp344100128,
                "mp3_44100_192" => AllowedOutputFormats.Mp344100192,
                "mp3_44100_32" => AllowedOutputFormats.Mp34410032,
                "mp3_44100_64" => AllowedOutputFormats.Mp34410064,
                "mp3_44100_96" => AllowedOutputFormats.Mp34410096,
                "opus_48000_128" => AllowedOutputFormats.Opus48000128,
                "opus_48000_192" => AllowedOutputFormats.Opus48000192,
                "opus_48000_32" => AllowedOutputFormats.Opus4800032,
                "opus_48000_64" => AllowedOutputFormats.Opus4800064,
                "opus_48000_96" => AllowedOutputFormats.Opus4800096,
                "pcm_16000" => AllowedOutputFormats.Pcm16000,
                "pcm_22050" => AllowedOutputFormats.Pcm22050,
                "pcm_24000" => AllowedOutputFormats.Pcm24000,
                "pcm_32000" => AllowedOutputFormats.Pcm32000,
                "pcm_44100" => AllowedOutputFormats.Pcm44100,
                "pcm_48000" => AllowedOutputFormats.Pcm48000,
                "pcm_8000" => AllowedOutputFormats.Pcm8000,
                "ulaw_8000" => AllowedOutputFormats.Ulaw8000,
                _ => null,
            };
        }
    }
}