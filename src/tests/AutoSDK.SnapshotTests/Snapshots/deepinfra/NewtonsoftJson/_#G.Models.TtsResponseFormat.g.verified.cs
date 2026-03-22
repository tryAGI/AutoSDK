//HintName: G.Models.TtsResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.<br/>
    /// Default Value: wav
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TtsResponseFormat
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="opus")]
        Opus,
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
    public static class TtsResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsResponseFormat value)
        {
            return value switch
            {
                TtsResponseFormat.Flac => "flac",
                TtsResponseFormat.Mp3 => "mp3",
                TtsResponseFormat.Opus => "opus",
                TtsResponseFormat.Pcm => "pcm",
                TtsResponseFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => TtsResponseFormat.Flac,
                "mp3" => TtsResponseFormat.Mp3,
                "opus" => TtsResponseFormat.Opus,
                "pcm" => TtsResponseFormat.Pcm,
                "wav" => TtsResponseFormat.Wav,
                _ => null,
            };
        }
    }
}