//HintName: G.Models.CreateChatCompletionRequestAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
    /// `opus`, or `pcm16`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flac")]
        Flac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus")]
        Opus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm16")]
        Pcm16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestAudioFormat value)
        {
            return value switch
            {
                CreateChatCompletionRequestAudioFormat.Wav => "wav",
                CreateChatCompletionRequestAudioFormat.Mp3 => "mp3",
                CreateChatCompletionRequestAudioFormat.Flac => "flac",
                CreateChatCompletionRequestAudioFormat.Opus => "opus",
                CreateChatCompletionRequestAudioFormat.Pcm16 => "pcm16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "wav" => CreateChatCompletionRequestAudioFormat.Wav,
                "mp3" => CreateChatCompletionRequestAudioFormat.Mp3,
                "flac" => CreateChatCompletionRequestAudioFormat.Flac,
                "opus" => CreateChatCompletionRequestAudioFormat.Opus,
                "pcm16" => CreateChatCompletionRequestAudioFormat.Pcm16,
                _ => null,
            };
        }
    }
}