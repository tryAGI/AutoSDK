//HintName: G.Models.TextToSpeechFullWithTimestampsOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM and WAV formats with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    public enum TextToSpeechFullWithTimestampsOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw8000,
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
        Mp344100128,
        /// <summary>
        /// 
        /// </summary>
        Mp344100192,
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
        Opus48000128,
        /// <summary>
        /// 
        /// </summary>
        Opus48000192,
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
        Pcm8000,
        /// <summary>
        /// 
        /// </summary>
        Ulaw8000,
        /// <summary>
        /// 
        /// </summary>
        Wav16000,
        /// <summary>
        /// 
        /// </summary>
        Wav22050,
        /// <summary>
        /// 
        /// </summary>
        Wav24000,
        /// <summary>
        /// 
        /// </summary>
        Wav32000,
        /// <summary>
        /// 
        /// </summary>
        Wav44100,
        /// <summary>
        /// 
        /// </summary>
        Wav48000,
        /// <summary>
        /// 
        /// </summary>
        Wav8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechFullWithTimestampsOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechFullWithTimestampsOutputFormat value)
        {
            return value switch
            {
                TextToSpeechFullWithTimestampsOutputFormat.Alaw8000 => "alaw_8000",
                TextToSpeechFullWithTimestampsOutputFormat.Mp32205032 => "mp3_22050_32",
                TextToSpeechFullWithTimestampsOutputFormat.Mp32400048 => "mp3_24000_48",
                TextToSpeechFullWithTimestampsOutputFormat.Mp344100128 => "mp3_44100_128",
                TextToSpeechFullWithTimestampsOutputFormat.Mp344100192 => "mp3_44100_192",
                TextToSpeechFullWithTimestampsOutputFormat.Mp34410032 => "mp3_44100_32",
                TextToSpeechFullWithTimestampsOutputFormat.Mp34410064 => "mp3_44100_64",
                TextToSpeechFullWithTimestampsOutputFormat.Mp34410096 => "mp3_44100_96",
                TextToSpeechFullWithTimestampsOutputFormat.Opus48000128 => "opus_48000_128",
                TextToSpeechFullWithTimestampsOutputFormat.Opus48000192 => "opus_48000_192",
                TextToSpeechFullWithTimestampsOutputFormat.Opus4800032 => "opus_48000_32",
                TextToSpeechFullWithTimestampsOutputFormat.Opus4800064 => "opus_48000_64",
                TextToSpeechFullWithTimestampsOutputFormat.Opus4800096 => "opus_48000_96",
                TextToSpeechFullWithTimestampsOutputFormat.Pcm16000 => "pcm_16000",
                TextToSpeechFullWithTimestampsOutputFormat.Pcm22050 => "pcm_22050",
                TextToSpeechFullWithTimestampsOutputFormat.Pcm24000 => "pcm_24000",
                TextToSpeechFullWithTimestampsOutputFormat.Pcm32000 => "pcm_32000",
                TextToSpeechFullWithTimestampsOutputFormat.Pcm44100 => "pcm_44100",
                TextToSpeechFullWithTimestampsOutputFormat.Pcm48000 => "pcm_48000",
                TextToSpeechFullWithTimestampsOutputFormat.Pcm8000 => "pcm_8000",
                TextToSpeechFullWithTimestampsOutputFormat.Ulaw8000 => "ulaw_8000",
                TextToSpeechFullWithTimestampsOutputFormat.Wav16000 => "wav_16000",
                TextToSpeechFullWithTimestampsOutputFormat.Wav22050 => "wav_22050",
                TextToSpeechFullWithTimestampsOutputFormat.Wav24000 => "wav_24000",
                TextToSpeechFullWithTimestampsOutputFormat.Wav32000 => "wav_32000",
                TextToSpeechFullWithTimestampsOutputFormat.Wav44100 => "wav_44100",
                TextToSpeechFullWithTimestampsOutputFormat.Wav48000 => "wav_48000",
                TextToSpeechFullWithTimestampsOutputFormat.Wav8000 => "wav_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechFullWithTimestampsOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw_8000" => TextToSpeechFullWithTimestampsOutputFormat.Alaw8000,
                "mp3_22050_32" => TextToSpeechFullWithTimestampsOutputFormat.Mp32205032,
                "mp3_24000_48" => TextToSpeechFullWithTimestampsOutputFormat.Mp32400048,
                "mp3_44100_128" => TextToSpeechFullWithTimestampsOutputFormat.Mp344100128,
                "mp3_44100_192" => TextToSpeechFullWithTimestampsOutputFormat.Mp344100192,
                "mp3_44100_32" => TextToSpeechFullWithTimestampsOutputFormat.Mp34410032,
                "mp3_44100_64" => TextToSpeechFullWithTimestampsOutputFormat.Mp34410064,
                "mp3_44100_96" => TextToSpeechFullWithTimestampsOutputFormat.Mp34410096,
                "opus_48000_128" => TextToSpeechFullWithTimestampsOutputFormat.Opus48000128,
                "opus_48000_192" => TextToSpeechFullWithTimestampsOutputFormat.Opus48000192,
                "opus_48000_32" => TextToSpeechFullWithTimestampsOutputFormat.Opus4800032,
                "opus_48000_64" => TextToSpeechFullWithTimestampsOutputFormat.Opus4800064,
                "opus_48000_96" => TextToSpeechFullWithTimestampsOutputFormat.Opus4800096,
                "pcm_16000" => TextToSpeechFullWithTimestampsOutputFormat.Pcm16000,
                "pcm_22050" => TextToSpeechFullWithTimestampsOutputFormat.Pcm22050,
                "pcm_24000" => TextToSpeechFullWithTimestampsOutputFormat.Pcm24000,
                "pcm_32000" => TextToSpeechFullWithTimestampsOutputFormat.Pcm32000,
                "pcm_44100" => TextToSpeechFullWithTimestampsOutputFormat.Pcm44100,
                "pcm_48000" => TextToSpeechFullWithTimestampsOutputFormat.Pcm48000,
                "pcm_8000" => TextToSpeechFullWithTimestampsOutputFormat.Pcm8000,
                "ulaw_8000" => TextToSpeechFullWithTimestampsOutputFormat.Ulaw8000,
                "wav_16000" => TextToSpeechFullWithTimestampsOutputFormat.Wav16000,
                "wav_22050" => TextToSpeechFullWithTimestampsOutputFormat.Wav22050,
                "wav_24000" => TextToSpeechFullWithTimestampsOutputFormat.Wav24000,
                "wav_32000" => TextToSpeechFullWithTimestampsOutputFormat.Wav32000,
                "wav_44100" => TextToSpeechFullWithTimestampsOutputFormat.Wav44100,
                "wav_48000" => TextToSpeechFullWithTimestampsOutputFormat.Wav48000,
                "wav_8000" => TextToSpeechFullWithTimestampsOutputFormat.Wav8000,
                _ => null,
            };
        }
    }
}