//HintName: G.Models.TTSRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output audio format.<br/>
    /// Default Value: mp3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TTSRequestFormat
    {
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
    public static class TTSRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSRequestFormat value)
        {
            return value switch
            {
                TTSRequestFormat.Mp3 => "mp3",
                TTSRequestFormat.Opus => "opus",
                TTSRequestFormat.Pcm => "pcm",
                TTSRequestFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => TTSRequestFormat.Mp3,
                "opus" => TTSRequestFormat.Opus,
                "pcm" => TTSRequestFormat.Pcm,
                "wav" => TTSRequestFormat.Wav,
                _ => null,
            };
        }
    }
}