//HintName: G.Models.ChatResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object returned, which is always `chat.completion` for chat responses.
    /// </summary>
    public enum ChatResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatResponseObject value)
        {
            return value switch
            {
                ChatResponseObject.ChatCompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => ChatResponseObject.ChatCompletion,
                _ => null,
            };
        }
    }
}