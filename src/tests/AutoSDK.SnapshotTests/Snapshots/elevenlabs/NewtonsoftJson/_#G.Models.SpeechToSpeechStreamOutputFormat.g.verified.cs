//HintName: G.Models.SpeechToSpeechStreamOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechToSpeechStreamOutputFormat
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
    public static class SpeechToSpeechStreamOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToSpeechStreamOutputFormat value)
        {
            return value switch
            {
                SpeechToSpeechStreamOutputFormat.Alaw8000 => "alaw_8000",
                SpeechToSpeechStreamOutputFormat.Mp32205032 => "mp3_22050_32",
                SpeechToSpeechStreamOutputFormat.Mp32400048 => "mp3_24000_48",
                SpeechToSpeechStreamOutputFormat.Mp344100128 => "mp3_44100_128",
                SpeechToSpeechStreamOutputFormat.Mp344100192 => "mp3_44100_192",
                SpeechToSpeechStreamOutputFormat.Mp34410032 => "mp3_44100_32",
                SpeechToSpeechStreamOutputFormat.Mp34410064 => "mp3_44100_64",
                SpeechToSpeechStreamOutputFormat.Mp34410096 => "mp3_44100_96",
                SpeechToSpeechStreamOutputFormat.Opus48000128 => "opus_48000_128",
                SpeechToSpeechStreamOutputFormat.Opus48000192 => "opus_48000_192",
                SpeechToSpeechStreamOutputFormat.Opus4800032 => "opus_48000_32",
                SpeechToSpeechStreamOutputFormat.Opus4800064 => "opus_48000_64",
                SpeechToSpeechStreamOutputFormat.Opus4800096 => "opus_48000_96",
                SpeechToSpeechStreamOutputFormat.Pcm16000 => "pcm_16000",
                SpeechToSpeechStreamOutputFormat.Pcm22050 => "pcm_22050",
                SpeechToSpeechStreamOutputFormat.Pcm24000 => "pcm_24000",
                SpeechToSpeechStreamOutputFormat.Pcm32000 => "pcm_32000",
                SpeechToSpeechStreamOutputFormat.Pcm44100 => "pcm_44100",
                SpeechToSpeechStreamOutputFormat.Pcm48000 => "pcm_48000",
                SpeechToSpeechStreamOutputFormat.Pcm8000 => "pcm_8000",
                SpeechToSpeechStreamOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToSpeechStreamOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw_8000" => SpeechToSpeechStreamOutputFormat.Alaw8000,
                "mp3_22050_32" => SpeechToSpeechStreamOutputFormat.Mp32205032,
                "mp3_24000_48" => SpeechToSpeechStreamOutputFormat.Mp32400048,
                "mp3_44100_128" => SpeechToSpeechStreamOutputFormat.Mp344100128,
                "mp3_44100_192" => SpeechToSpeechStreamOutputFormat.Mp344100192,
                "mp3_44100_32" => SpeechToSpeechStreamOutputFormat.Mp34410032,
                "mp3_44100_64" => SpeechToSpeechStreamOutputFormat.Mp34410064,
                "mp3_44100_96" => SpeechToSpeechStreamOutputFormat.Mp34410096,
                "opus_48000_128" => SpeechToSpeechStreamOutputFormat.Opus48000128,
                "opus_48000_192" => SpeechToSpeechStreamOutputFormat.Opus48000192,
                "opus_48000_32" => SpeechToSpeechStreamOutputFormat.Opus4800032,
                "opus_48000_64" => SpeechToSpeechStreamOutputFormat.Opus4800064,
                "opus_48000_96" => SpeechToSpeechStreamOutputFormat.Opus4800096,
                "pcm_16000" => SpeechToSpeechStreamOutputFormat.Pcm16000,
                "pcm_22050" => SpeechToSpeechStreamOutputFormat.Pcm22050,
                "pcm_24000" => SpeechToSpeechStreamOutputFormat.Pcm24000,
                "pcm_32000" => SpeechToSpeechStreamOutputFormat.Pcm32000,
                "pcm_44100" => SpeechToSpeechStreamOutputFormat.Pcm44100,
                "pcm_48000" => SpeechToSpeechStreamOutputFormat.Pcm48000,
                "pcm_8000" => SpeechToSpeechStreamOutputFormat.Pcm8000,
                "ulaw_8000" => SpeechToSpeechStreamOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}