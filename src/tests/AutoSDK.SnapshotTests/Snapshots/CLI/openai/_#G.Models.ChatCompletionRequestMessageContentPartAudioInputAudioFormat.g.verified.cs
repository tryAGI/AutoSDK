//HintName: G.Models.ChatCompletionRequestMessageContentPartAudioInputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the encoded audio data. Currently supports "wav" and "mp3".
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartAudioInputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentPartAudioInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartAudioInputAudioFormat value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Wav => "wav",
                ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Mp3 => "mp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartAudioInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "wav" => ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Wav,
                "mp3" => ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Mp3,
                _ => null,
            };
        }
    }
}