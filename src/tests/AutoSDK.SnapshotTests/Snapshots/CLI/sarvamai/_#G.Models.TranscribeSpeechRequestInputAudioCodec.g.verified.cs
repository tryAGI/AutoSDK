//HintName: G.Models.TranscribeSpeechRequestInputAudioCodec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required for PCM format files
    /// </summary>
    public enum TranscribeSpeechRequestInputAudioCodec
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
    public static class TranscribeSpeechRequestInputAudioCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscribeSpeechRequestInputAudioCodec value)
        {
            return value switch
            {
                TranscribeSpeechRequestInputAudioCodec.Aac => "aac",
                TranscribeSpeechRequestInputAudioCodec.Aiff => "aiff",
                TranscribeSpeechRequestInputAudioCodec.Amr => "amr",
                TranscribeSpeechRequestInputAudioCodec.Flac => "flac",
                TranscribeSpeechRequestInputAudioCodec.Mp3 => "mp3",
                TranscribeSpeechRequestInputAudioCodec.Mp4 => "mp4",
                TranscribeSpeechRequestInputAudioCodec.Mpeg => "mpeg",
                TranscribeSpeechRequestInputAudioCodec.Mpeg3 => "mpeg3",
                TranscribeSpeechRequestInputAudioCodec.Ogg => "ogg",
                TranscribeSpeechRequestInputAudioCodec.Opus => "opus",
                TranscribeSpeechRequestInputAudioCodec.PcmL16 => "pcm_l16",
                TranscribeSpeechRequestInputAudioCodec.PcmRaw => "pcm_raw",
                TranscribeSpeechRequestInputAudioCodec.PcmS16le => "pcm_s16le",
                TranscribeSpeechRequestInputAudioCodec.Wav => "wav",
                TranscribeSpeechRequestInputAudioCodec.Wave => "wave",
                TranscribeSpeechRequestInputAudioCodec.Webm => "webm",
                TranscribeSpeechRequestInputAudioCodec.XAac => "x-aac",
                TranscribeSpeechRequestInputAudioCodec.XAiff => "x-aiff",
                TranscribeSpeechRequestInputAudioCodec.XFlac => "x-flac",
                TranscribeSpeechRequestInputAudioCodec.XM4a => "x-m4a",
                TranscribeSpeechRequestInputAudioCodec.XMp3 => "x-mp3",
                TranscribeSpeechRequestInputAudioCodec.XMpeg3 => "x-mpeg-3",
                TranscribeSpeechRequestInputAudioCodec.XMsWma => "x-ms-wma",
                TranscribeSpeechRequestInputAudioCodec.XWav => "x-wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscribeSpeechRequestInputAudioCodec? ToEnum(string value)
        {
            return value switch
            {
                "aac" => TranscribeSpeechRequestInputAudioCodec.Aac,
                "aiff" => TranscribeSpeechRequestInputAudioCodec.Aiff,
                "amr" => TranscribeSpeechRequestInputAudioCodec.Amr,
                "flac" => TranscribeSpeechRequestInputAudioCodec.Flac,
                "mp3" => TranscribeSpeechRequestInputAudioCodec.Mp3,
                "mp4" => TranscribeSpeechRequestInputAudioCodec.Mp4,
                "mpeg" => TranscribeSpeechRequestInputAudioCodec.Mpeg,
                "mpeg3" => TranscribeSpeechRequestInputAudioCodec.Mpeg3,
                "ogg" => TranscribeSpeechRequestInputAudioCodec.Ogg,
                "opus" => TranscribeSpeechRequestInputAudioCodec.Opus,
                "pcm_l16" => TranscribeSpeechRequestInputAudioCodec.PcmL16,
                "pcm_raw" => TranscribeSpeechRequestInputAudioCodec.PcmRaw,
                "pcm_s16le" => TranscribeSpeechRequestInputAudioCodec.PcmS16le,
                "wav" => TranscribeSpeechRequestInputAudioCodec.Wav,
                "wave" => TranscribeSpeechRequestInputAudioCodec.Wave,
                "webm" => TranscribeSpeechRequestInputAudioCodec.Webm,
                "x-aac" => TranscribeSpeechRequestInputAudioCodec.XAac,
                "x-aiff" => TranscribeSpeechRequestInputAudioCodec.XAiff,
                "x-flac" => TranscribeSpeechRequestInputAudioCodec.XFlac,
                "x-m4a" => TranscribeSpeechRequestInputAudioCodec.XM4a,
                "x-mp3" => TranscribeSpeechRequestInputAudioCodec.XMp3,
                "x-mpeg-3" => TranscribeSpeechRequestInputAudioCodec.XMpeg3,
                "x-ms-wma" => TranscribeSpeechRequestInputAudioCodec.XMsWma,
                "x-wav" => TranscribeSpeechRequestInputAudioCodec.XWav,
                _ => null,
            };
        }
    }
}