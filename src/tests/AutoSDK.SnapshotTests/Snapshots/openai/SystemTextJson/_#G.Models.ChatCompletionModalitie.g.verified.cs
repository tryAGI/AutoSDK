//HintName: G.Models.ChatCompletionModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionModalitie
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionModalitie value)
        {
            return value switch
            {
                ChatCompletionModalitie.Audio => "audio",
                ChatCompletionModalitie.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ChatCompletionModalitie.Audio,
                "text" => ChatCompletionModalitie.Text,
                _ => null,
            };
        }
    }
}