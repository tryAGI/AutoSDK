//HintName: G.Models.ChatCompletionRequestMessageContentPartTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part.
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    public static class ChatCompletionRequestMessageContentPartTextTypeExtensions
    {
        public static string ToValueString(this ChatCompletionRequestMessageContentPartTextType value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestMessageContentPartTextType ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionRequestMessageContentPartTextType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestMessageContentPartTextType ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestMessageContentPartTextType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}