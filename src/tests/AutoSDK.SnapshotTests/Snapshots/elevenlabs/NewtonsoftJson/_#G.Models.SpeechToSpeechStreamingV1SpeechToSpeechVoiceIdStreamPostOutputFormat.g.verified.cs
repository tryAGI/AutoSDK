//HintName: G.Models.SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3_22050_32")]
        Mp32205032,
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
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_8000")]
        Pcm8000,
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
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_44100")]
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ulaw_8000")]
        Ulaw8000,
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
        [global::System.Runtime.Serialization.EnumMember(Value="opus_48000_128")]
        Opus48000128,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus_48000_192")]
        Opus48000192,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat value)
        {
            return value switch
            {
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp32205032 => "mp3_22050_32",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp34410032 => "mp3_44100_32",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp34410064 => "mp3_44100_64",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp34410096 => "mp3_44100_96",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp344100128 => "mp3_44100_128",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp344100192 => "mp3_44100_192",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm8000 => "pcm_8000",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm16000 => "pcm_16000",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm22050 => "pcm_22050",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm24000 => "pcm_24000",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm44100 => "pcm_44100",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Ulaw8000 => "ulaw_8000",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus4800032 => "opus_48000_32",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus4800064 => "opus_48000_64",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus4800096 => "opus_48000_96",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus48000128 => "opus_48000_128",
                SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus48000192 => "opus_48000_192",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp32205032,
                "mp3_44100_32" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp34410032,
                "mp3_44100_64" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp34410064,
                "mp3_44100_96" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp34410096,
                "mp3_44100_128" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp344100128,
                "mp3_44100_192" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Mp344100192,
                "pcm_8000" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm8000,
                "pcm_16000" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm16000,
                "pcm_22050" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm22050,
                "pcm_24000" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm24000,
                "pcm_44100" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Pcm44100,
                "ulaw_8000" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Ulaw8000,
                "opus_48000_32" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus4800032,
                "opus_48000_64" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus4800064,
                "opus_48000_96" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus4800096,
                "opus_48000_128" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus48000128,
                "opus_48000_192" => SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormat.Opus48000192,
                _ => null,
            };
        }
    }
}