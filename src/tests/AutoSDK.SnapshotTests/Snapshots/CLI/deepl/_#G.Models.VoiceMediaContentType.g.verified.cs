//HintName: G.Models.VoiceMediaContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The audio format for streaming. Specifies container, codec, and encoding parameters.<br/>
    /// Supported formats include PCM (recommended), OPUS (recommended for low bandwidth), FLAC, MP3, and AAC.<br/>
    /// PCM formats require explicit sample rate. Mono audio only.<br/>
    /// Example: audio/ogg; codecs=opus
    /// </summary>
    public enum VoiceMediaContentType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioAuto,
        /// <summary>
        /// 
        /// </summary>
        AudioFlac,
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg_Codecs_flac,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg_Codecs_opus,
        /// <summary>
        /// 
        /// </summary>
        AudioPcm_Encoding_s16le_Rate_16000,
        /// <summary>
        /// 
        /// </summary>
        AudioPcm_Encoding_s16le_Rate_44100,
        /// <summary>
        /// 
        /// </summary>
        AudioPcm_Encoding_s16le_Rate_48000,
        /// <summary>
        /// 
        /// </summary>
        AudioPcm_Encoding_s16le_Rate_8000,
        /// <summary>
        /// 
        /// </summary>
        AudioWebm,
        /// <summary>
        /// 
        /// </summary>
        AudioWebm_Codecs_opus,
        /// <summary>
        /// 
        /// </summary>
        AudioXMatroska,
        /// <summary>
        /// 
        /// </summary>
        AudioXMatroska_Codecs_aac,
        /// <summary>
        /// 
        /// </summary>
        AudioXMatroska_Codecs_flac,
        /// <summary>
        /// 
        /// </summary>
        AudioXMatroska_Codecs_mp3,
        /// <summary>
        /// 
        /// </summary>
        AudioXMatroska_Codecs_opus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceMediaContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMediaContentType value)
        {
            return value switch
            {
                VoiceMediaContentType.AudioAuto => "audio/auto",
                VoiceMediaContentType.AudioFlac => "audio/flac",
                VoiceMediaContentType.AudioMpeg => "audio/mpeg",
                VoiceMediaContentType.AudioOgg => "audio/ogg",
                VoiceMediaContentType.AudioOgg_Codecs_flac => "audio/ogg; codecs=flac",
                VoiceMediaContentType.AudioOgg_Codecs_opus => "audio/ogg; codecs=opus",
                VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_16000 => "audio/pcm; encoding=s16le; rate=16000",
                VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_44100 => "audio/pcm; encoding=s16le; rate=44100",
                VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_48000 => "audio/pcm; encoding=s16le; rate=48000",
                VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_8000 => "audio/pcm; encoding=s16le; rate=8000",
                VoiceMediaContentType.AudioWebm => "audio/webm",
                VoiceMediaContentType.AudioWebm_Codecs_opus => "audio/webm; codecs=opus",
                VoiceMediaContentType.AudioXMatroska => "audio/x-matroska",
                VoiceMediaContentType.AudioXMatroska_Codecs_aac => "audio/x-matroska; codecs=aac",
                VoiceMediaContentType.AudioXMatroska_Codecs_flac => "audio/x-matroska; codecs=flac",
                VoiceMediaContentType.AudioXMatroska_Codecs_mp3 => "audio/x-matroska; codecs=mp3",
                VoiceMediaContentType.AudioXMatroska_Codecs_opus => "audio/x-matroska; codecs=opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMediaContentType? ToEnum(string value)
        {
            return value switch
            {
                "audio/auto" => VoiceMediaContentType.AudioAuto,
                "audio/flac" => VoiceMediaContentType.AudioFlac,
                "audio/mpeg" => VoiceMediaContentType.AudioMpeg,
                "audio/ogg" => VoiceMediaContentType.AudioOgg,
                "audio/ogg; codecs=flac" => VoiceMediaContentType.AudioOgg_Codecs_flac,
                "audio/ogg; codecs=opus" => VoiceMediaContentType.AudioOgg_Codecs_opus,
                "audio/pcm; encoding=s16le; rate=16000" => VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_16000,
                "audio/pcm; encoding=s16le; rate=44100" => VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_44100,
                "audio/pcm; encoding=s16le; rate=48000" => VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_48000,
                "audio/pcm; encoding=s16le; rate=8000" => VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_8000,
                "audio/webm" => VoiceMediaContentType.AudioWebm,
                "audio/webm; codecs=opus" => VoiceMediaContentType.AudioWebm_Codecs_opus,
                "audio/x-matroska" => VoiceMediaContentType.AudioXMatroska,
                "audio/x-matroska; codecs=aac" => VoiceMediaContentType.AudioXMatroska_Codecs_aac,
                "audio/x-matroska; codecs=flac" => VoiceMediaContentType.AudioXMatroska_Codecs_flac,
                "audio/x-matroska; codecs=mp3" => VoiceMediaContentType.AudioXMatroska_Codecs_mp3,
                "audio/x-matroska; codecs=opus" => VoiceMediaContentType.AudioXMatroska_Codecs_opus,
                _ => null,
            };
        }
    }
}