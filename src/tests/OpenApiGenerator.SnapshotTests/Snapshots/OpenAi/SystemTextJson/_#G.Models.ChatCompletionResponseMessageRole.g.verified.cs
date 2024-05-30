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

    public static class ChatCompletionResponseMessageRoleExtensions
    {
        public static string ToValueString(this ChatCompletionResponseMessageRole value)
        {
            return value switch
            {
                ChatCompletionResponseMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionResponseMessageRole ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionResponseMessageRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionResponseMessageRole ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionResponseMessageRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}