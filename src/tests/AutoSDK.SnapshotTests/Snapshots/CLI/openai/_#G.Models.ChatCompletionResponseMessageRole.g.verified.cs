//HintName: G.Models.ChatCompletionResponseMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the author of this message.
    /// </summary>
    public enum ChatCompletionResponseMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionResponseMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionResponseMessageRole value)
        {
            return value switch
            {
                ChatCompletionResponseMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionResponseMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionResponseMessageRole.Assistant,
                _ => null,
            };
        }
    }
}