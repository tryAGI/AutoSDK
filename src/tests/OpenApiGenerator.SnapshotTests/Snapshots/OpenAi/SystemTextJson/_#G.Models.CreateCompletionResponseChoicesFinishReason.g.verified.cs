//HintName: G.Models.CreateCompletionResponseChoicesFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
    /// `length` if the maximum number of tokens specified in the request was reached,
    /// or `content_filter` if content was omitted due to a flag from our content filters.
    /// </summary>
    public enum CreateCompletionResponseChoicesFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
    }

    public static class CreateCompletionResponseChoicesFinishReasonExtensions
    {
        public static string ToValueString(this CreateCompletionResponseChoicesFinishReason value)
        {
            return value switch
            {
                CreateCompletionResponseChoicesFinishReason.Stop => "stop",
                CreateCompletionResponseChoicesFinishReason.Length => "length",
                CreateCompletionResponseChoicesFinishReason.ContentFilter => "content_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateCompletionResponseChoicesFinishReason ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateCompletionResponseChoicesFinishReason.Stop,
                "length" => CreateCompletionResponseChoicesFinishReason.Length,
                "content_filter" => CreateCompletionResponseChoicesFinishReason.ContentFilter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateCompletionResponseChoicesFinishReason ToEnum(int value)
        {
            return value switch
            {
                0 => CreateCompletionResponseChoicesFinishReason.Stop,
                1 => CreateCompletionResponseChoicesFinishReason.Length,
                2 => CreateCompletionResponseChoicesFinishReason.ContentFilter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}