//HintName: G.Models.TextToSpeechFullOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM and WAV formats with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    public enum TextToSpeechFullOutputFormat
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
    public static class TextToSpeechFullOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechFullOutputFormat value)
        {
            return value switch
            {
                TextToSpeechFullOutputFormat.Alaw8000 => "alaw_8000",
                TextToSpeechFullOutputFormat.Mp32205032 => "mp3_22050_32",
                TextToSpeechFullOutputFormat.Mp32400048 => "mp3_24000_48",
                TextToSpeechFullOutputFormat.Mp344100128 => "mp3_44100_128",
                TextToSpeechFullOutputFormat.Mp344100192 => "mp3_44100_192",
                TextToSpeechFullOutputFormat.Mp34410032 => "mp3_44100_32",
                TextToSpeechFullOutputFormat.Mp34410064 => "mp3_44100_64",
                TextToSpeechFullOutputFormat.Mp34410096 => "mp3_44100_96",
                TextToSpeechFullOutputFormat.Opus48000128 => "opus_48000_128",
                TextToSpeechFullOutputFormat.Opus48000192 => "opus_48000_192",
                TextToSpeechFullOutputFormat.Opus4800032 => "opus_48000_32",
                TextToSpeechFullOutputFormat.Opus4800064 => "opus_48000_64",
                TextToSpeechFullOutputFormat.Opus4800096 => "opus_48000_96",
                TextToSpeechFullOutputFormat.Pcm16000 => "pcm_16000",
                TextToSpeechFullOutputFormat.Pcm22050 => "pcm_22050",
                TextToSpeechFullOutputFormat.Pcm24000 => "pcm_24000",
                TextToSpeechFullOutputFormat.Pcm32000 => "pcm_32000",
                TextToSpeechFullOutputFormat.Pcm44100 => "pcm_44100",
                TextToSpeechFullOutputFormat.Pcm48000 => "pcm_48000",
                TextToSpeechFullOutputFormat.Pcm8000 => "pcm_8000",
                TextToSpeechFullOutputFormat.Ulaw8000 => "ulaw_8000",
                TextToSpeechFullOutputFormat.Wav16000 => "wav_16000",
                TextToSpeechFullOutputFormat.Wav22050 => "wav_22050",
                TextToSpeechFullOutputFormat.Wav24000 => "wav_24000",
                TextToSpeechFullOutputFormat.Wav32000 => "wav_32000",
                TextToSpeechFullOutputFormat.Wav44100 => "wav_44100",
                TextToSpeechFullOutputFormat.Wav48000 => "wav_48000",
                TextToSpeechFullOutputFormat.Wav8000 => "wav_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechFullOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw_8000" => TextToSpeechFullOutputFormat.Alaw8000,
                "mp3_22050_32" => TextToSpeechFullOutputFormat.Mp32205032,
                "mp3_24000_48" => TextToSpeechFullOutputFormat.Mp32400048,
                "mp3_44100_128" => TextToSpeechFullOutputFormat.Mp344100128,
                "mp3_44100_192" => TextToSpeechFullOutputFormat.Mp344100192,
                "mp3_44100_32" => TextToSpeechFullOutputFormat.Mp34410032,
                "mp3_44100_64" => TextToSpeechFullOutputFormat.Mp34410064,
                "mp3_44100_96" => TextToSpeechFullOutputFormat.Mp34410096,
                "opus_48000_128" => TextToSpeechFullOutputFormat.Opus48000128,
                "opus_48000_192" => TextToSpeechFullOutputFormat.Opus48000192,
                "opus_48000_32" => TextToSpeechFullOutputFormat.Opus4800032,
                "opus_48000_64" => TextToSpeechFullOutputFormat.Opus4800064,
                "opus_48000_96" => TextToSpeechFullOutputFormat.Opus4800096,
                "pcm_16000" => TextToSpeechFullOutputFormat.Pcm16000,
                "pcm_22050" => TextToSpeechFullOutputFormat.Pcm22050,
                "pcm_24000" => TextToSpeechFullOutputFormat.Pcm24000,
                "pcm_32000" => TextToSpeechFullOutputFormat.Pcm32000,
                "pcm_44100" => TextToSpeechFullOutputFormat.Pcm44100,
                "pcm_48000" => TextToSpeechFullOutputFormat.Pcm48000,
                "pcm_8000" => TextToSpeechFullOutputFormat.Pcm8000,
                "ulaw_8000" => TextToSpeechFullOutputFormat.Ulaw8000,
                "wav_16000" => TextToSpeechFullOutputFormat.Wav16000,
                "wav_22050" => TextToSpeechFullOutputFormat.Wav22050,
                "wav_24000" => TextToSpeechFullOutputFormat.Wav24000,
                "wav_32000" => TextToSpeechFullOutputFormat.Wav32000,
                "wav_44100" => TextToSpeechFullOutputFormat.Wav44100,
                "wav_48000" => TextToSpeechFullOutputFormat.Wav48000,
                "wav_8000" => TextToSpeechFullOutputFormat.Wav8000,
                _ => null,
            };
        }
    }
}