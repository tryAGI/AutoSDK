//HintName: G.Models.ChatCompletionRequestMessageContentPartAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part. Always `input_audio`.
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentPartAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartAudioType value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => ChatCompletionRequestMessageContentPartAudioType.InputAudio,
                _ => null,
            };
        }
    }
}