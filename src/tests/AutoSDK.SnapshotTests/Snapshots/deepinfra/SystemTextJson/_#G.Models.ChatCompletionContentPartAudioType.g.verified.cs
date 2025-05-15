//HintName: G.Models.ChatCompletionContentPartAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionContentPartAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartAudioType value)
        {
            return value switch
            {
                ChatCompletionContentPartAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => ChatCompletionContentPartAudioType.InputAudio,
                _ => null,
            };
        }
    }
}