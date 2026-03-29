//HintName: G.Models.ChatContentAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatContentAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentAudioType value)
        {
            return value switch
            {
                ChatContentAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => ChatContentAudioType.InputAudio,
                _ => null,
            };
        }
    }
}