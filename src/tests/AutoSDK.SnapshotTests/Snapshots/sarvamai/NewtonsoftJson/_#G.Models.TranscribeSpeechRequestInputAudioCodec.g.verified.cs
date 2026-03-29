//HintName: G.Models.TranscribeSpeechRequestInputAudioCodec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required for PCM format files
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscribeSpeechRequestInputAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aac")]
        Aac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aiff")]
        Aiff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amr")]
        Amr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flac")]
        Flac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mpeg")]
        Mpeg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mpeg3")]
        Mpeg3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ogg")]
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus")]
        Opus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_l16")]
        PcmL16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_raw")]
        PcmRaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_s16le")]
        PcmS16le,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wave")]
        Wave,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webm")]
        Webm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-aac")]
        XAac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-aiff")]
        XAiff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-flac")]
        XFlac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-m4a")]
        XM4a,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-mp3")]
        XMp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-mpeg-3")]
        XMpeg3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-ms-wma")]
        XMsWma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="x-wav")]
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