//HintName: G.Models.CreateChatCompletionRequestVariant2AudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
    /// `opus`, or `pcm16`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestVariant2AudioFormat
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
    public static class CreateChatCompletionRequestVariant2AudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestVariant2AudioFormat value)
        {
            return value switch
            {
                CreateChatCompletionRequestVariant2AudioFormat.Wav => "wav",
                CreateChatCompletionRequestVariant2AudioFormat.Mp3 => "mp3",
                CreateChatCompletionRequestVariant2AudioFormat.Flac => "flac",
                CreateChatCompletionRequestVariant2AudioFormat.Opus => "opus",
                CreateChatCompletionRequestVariant2AudioFormat.Pcm16 => "pcm16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestVariant2AudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "wav" => CreateChatCompletionRequestVariant2AudioFormat.Wav,
                "mp3" => CreateChatCompletionRequestVariant2AudioFormat.Mp3,
                "flac" => CreateChatCompletionRequestVariant2AudioFormat.Flac,
                "opus" => CreateChatCompletionRequestVariant2AudioFormat.Opus,
                "pcm16" => CreateChatCompletionRequestVariant2AudioFormat.Pcm16,
                _ => null,
            };
        }
    }
}