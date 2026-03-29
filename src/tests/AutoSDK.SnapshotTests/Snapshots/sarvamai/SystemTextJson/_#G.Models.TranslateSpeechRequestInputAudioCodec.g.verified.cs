//HintName: G.Models.TranslateSpeechRequestInputAudioCodec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required for PCM format files
    /// </summary>
    public enum TranslateSpeechRequestInputAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
        /// <summary>
        /// 
        /// </summary>
        Aiff,
        /// <summary>
        /// 
        /// </summary>
        Amr,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        Mpeg,
        /// <summary>
        /// 
        /// </summary>
        Mpeg3,
        /// <summary>
        /// 
        /// </summary>
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        PcmL16,
        /// <summary>
        /// 
        /// </summary>
        PcmRaw,
        /// <summary>
        /// 
        /// </summary>
        PcmS16le,
        /// <summary>
        /// 
        /// </summary>
        Wav,
        /// <summary>
        /// 
        /// </summary>
        Wave,
        /// <summary>
        /// 
        /// </summary>
        Webm,
        /// <summary>
        /// 
        /// </summary>
        XAac,
        /// <summary>
        /// 
        /// </summary>
        XAiff,
        /// <summary>
        /// 
        /// </summary>
        XFlac,
        /// <summary>
        /// 
        /// </summary>
        XM4a,
        /// <summary>
        /// 
        /// </summary>
        XMp3,
        /// <summary>
        /// 
        /// </summary>
        XMpeg3,
        /// <summary>
        /// 
        /// </summary>
        XMsWma,
        /// <summary>
        /// 
        /// </summary>
        XWav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateSpeechRequestInputAudioCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateSpeechRequestInputAudioCodec value)
        {
            return value switch
            {
                TranslateSpeechRequestInputAudioCodec.Aac => "aac",
                TranslateSpeechRequestInputAudioCodec.Aiff => "aiff",
                TranslateSpeechRequestInputAudioCodec.Amr => "amr",
                TranslateSpeechRequestInputAudioCodec.Flac => "flac",
                TranslateSpeechRequestInputAudioCodec.Mp3 => "mp3",
                TranslateSpeechRequestInputAudioCodec.Mp4 => "mp4",
                TranslateSpeechRequestInputAudioCodec.Mpeg => "mpeg",
                TranslateSpeechRequestInputAudioCodec.Mpeg3 => "mpeg3",
                TranslateSpeechRequestInputAudioCodec.Ogg => "ogg",
                TranslateSpeechRequestInputAudioCodec.Opus => "opus",
                TranslateSpeechRequestInputAudioCodec.PcmL16 => "pcm_l16",
                TranslateSpeechRequestInputAudioCodec.PcmRaw => "pcm_raw",
                TranslateSpeechRequestInputAudioCodec.PcmS16le => "pcm_s16le",
                TranslateSpeechRequestInputAudioCodec.Wav => "wav",
                TranslateSpeechRequestInputAudioCodec.Wave => "wave",
                TranslateSpeechRequestInputAudioCodec.Webm => "webm",
                TranslateSpeechRequestInputAudioCodec.XAac => "x-aac",
                TranslateSpeechRequestInputAudioCodec.XAiff => "x-aiff",
                TranslateSpeechRequestInputAudioCodec.XFlac => "x-flac",
                TranslateSpeechRequestInputAudioCodec.XM4a => "x-m4a",
                TranslateSpeechRequestInputAudioCodec.XMp3 => "x-mp3",
                TranslateSpeechRequestInputAudioCodec.XMpeg3 => "x-mpeg-3",
                TranslateSpeechRequestInputAudioCodec.XMsWma => "x-ms-wma",
                TranslateSpeechRequestInputAudioCodec.XWav => "x-wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateSpeechRequestInputAudioCodec? ToEnum(string value)
        {
            return value switch
            {
                "aac" => TranslateSpeechRequestInputAudioCodec.Aac,
                "aiff" => TranslateSpeechRequestInputAudioCodec.Aiff,
                "amr" => TranslateSpeechRequestInputAudioCodec.Amr,
                "flac" => TranslateSpeechRequestInputAudioCodec.Flac,
                "mp3" => TranslateSpeechRequestInputAudioCodec.Mp3,
                "mp4" => TranslateSpeechRequestInputAudioCodec.Mp4,
                "mpeg" => TranslateSpeechRequestInputAudioCodec.Mpeg,
                "mpeg3" => TranslateSpeechRequestInputAudioCodec.Mpeg3,
                "ogg" => TranslateSpeechRequestInputAudioCodec.Ogg,
                "opus" => TranslateSpeechRequestInputAudioCodec.Opus,
                "pcm_l16" => TranslateSpeechRequestInputAudioCodec.PcmL16,
                "pcm_raw" => TranslateSpeechRequestInputAudioCodec.PcmRaw,
                "pcm_s16le" => TranslateSpeechRequestInputAudioCodec.PcmS16le,
                "wav" => TranslateSpeechRequestInputAudioCodec.Wav,
                "wave" => TranslateSpeechRequestInputAudioCodec.Wave,
                "webm" => TranslateSpeechRequestInputAudioCodec.Webm,
                "x-aac" => TranslateSpeechRequestInputAudioCodec.XAac,
                "x-aiff" => TranslateSpeechRequestInputAudioCodec.XAiff,
                "x-flac" => TranslateSpeechRequestInputAudioCodec.XFlac,
                "x-m4a" => TranslateSpeechRequestInputAudioCodec.XM4a,
                "x-mp3" => TranslateSpeechRequestInputAudioCodec.XMp3,
                "x-mpeg-3" => TranslateSpeechRequestInputAudioCodec.XMpeg3,
                "x-ms-wma" => TranslateSpeechRequestInputAudioCodec.XMsWma,
                "x-wav" => TranslateSpeechRequestInputAudioCodec.XWav,
                _ => null,
            };
        }
    }
}