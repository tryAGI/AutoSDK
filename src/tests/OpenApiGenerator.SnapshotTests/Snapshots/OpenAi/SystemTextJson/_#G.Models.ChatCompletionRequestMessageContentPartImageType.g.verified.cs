//HintName: G.Models.ChatCompletionRequestMessageContentPartImageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part.
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartImageType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    public static class ChatCompletionRequestMessageContentPartImageTypeExtensions
    {
        public static string ToValueString(this ChatCompletionRequestMessageContentPartImageType value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartImageType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestMessageContentPartImageType ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatCompletionRequestMessageContentPartImageType.ImageUrl,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestMessageContentPartImageType ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestMessageContentPartImageType.ImageUrl,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}