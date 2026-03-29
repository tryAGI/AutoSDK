//HintName: G.Models.PublicAudioSpeechRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 音频编码格式，wav / pcm / ogg_opus / mp3，默认为 mp3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublicAudioSpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ogg_opus")]
        OggOpus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm")]
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAudioSpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAudioSpeechRequestResponseFormat value)
        {
            return value switch
            {
                PublicAudioSpeechRequestResponseFormat.Mp3 => "mp3",
                PublicAudioSpeechRequestResponseFormat.OggOpus => "ogg_opus",
                PublicAudioSpeechRequestResponseFormat.Pcm => "pcm",
                PublicAudioSpeechRequestResponseFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAudioSpeechRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => PublicAudioSpeechRequestResponseFormat.Mp3,
                "ogg_opus" => PublicAudioSpeechRequestResponseFormat.OggOpus,
                "pcm" => PublicAudioSpeechRequestResponseFormat.Pcm,
                "wav" => PublicAudioSpeechRequestResponseFormat.Wav,
                _ => null,
            };
        }
    }
}