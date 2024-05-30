//HintName: G.Models.CreateSpeechRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.
    /// <br/>Default Value: mp3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSpeechRequestResponseFormat
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
        [global::System.Runtime.Serialization.EnumMember(Value="aac")]
        Aac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flac")]
        Flac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm")]
        Pcm,
    }

    public static class CreateSpeechRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateSpeechRequestResponseFormat value)
        {
            return value switch
            {
                CreateSpeechRequestResponseFormat.Mp3 => "mp3",
                CreateSpeechRequestResponseFormat.Opus => "opus",
                CreateSpeechRequestResponseFormat.Aac => "aac",
                CreateSpeechRequestResponseFormat.Flac => "flac",
                CreateSpeechRequestResponseFormat.Wav => "wav",
                CreateSpeechRequestResponseFormat.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateSpeechRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateSpeechRequestResponseFormat.Mp3,
                "opus" => CreateSpeechRequestResponseFormat.Opus,
                "aac" => CreateSpeechRequestResponseFormat.Aac,
                "flac" => CreateSpeechRequestResponseFormat.Flac,
                "wav" => CreateSpeechRequestResponseFormat.Wav,
                "pcm" => CreateSpeechRequestResponseFormat.Pcm,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateSpeechRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateSpeechRequestResponseFormat.Mp3,
                1 => CreateSpeechRequestResponseFormat.Opus,
                2 => CreateSpeechRequestResponseFormat.Aac,
                3 => CreateSpeechRequestResponseFormat.Flac,
                4 => CreateSpeechRequestResponseFormat.Wav,
                5 => CreateSpeechRequestResponseFormat.Pcm,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}