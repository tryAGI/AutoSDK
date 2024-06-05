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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCompletionResponseChoicesFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCompletionResponseChoicesFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateCompletionResponseChoicesFinishReason.Stop,
                "length" => CreateCompletionResponseChoicesFinishReason.Length,
                "content_filter" => CreateCompletionResponseChoicesFinishReason.ContentFilter,
                _ => null,
            };
        }
    }
}