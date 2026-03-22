//HintName: G.Models.CreateChatCompletionRequestVariant2AudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
    /// `opus`, or `pcm16`.
    /// </summary>
    public enum CreateChatCompletionRequestVariant2AudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
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
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
        /// <summary>
        /// 
        /// </summary>
        Wav,
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
                CreateChatCompletionRequestVariant2AudioFormat.Aac => "aac",
                CreateChatCompletionRequestVariant2AudioFormat.Flac => "flac",
                CreateChatCompletionRequestVariant2AudioFormat.Mp3 => "mp3",
                CreateChatCompletionRequestVariant2AudioFormat.Opus => "opus",
                CreateChatCompletionRequestVariant2AudioFormat.Pcm16 => "pcm16",
                CreateChatCompletionRequestVariant2AudioFormat.Wav => "wav",
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
                "aac" => CreateChatCompletionRequestVariant2AudioFormat.Aac,
                "flac" => CreateChatCompletionRequestVariant2AudioFormat.Flac,
                "mp3" => CreateChatCompletionRequestVariant2AudioFormat.Mp3,
                "opus" => CreateChatCompletionRequestVariant2AudioFormat.Opus,
                "pcm16" => CreateChatCompletionRequestVariant2AudioFormat.Pcm16,
                "wav" => CreateChatCompletionRequestVariant2AudioFormat.Wav,
                _ => null,
            };
        }
    }
}