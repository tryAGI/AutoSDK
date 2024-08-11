//HintName: G.Models.CreateCompletionResponseChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
    /// `length` if the maximum number of tokens specified in the request was reached,<br/>
    /// or `content_filter` if content was omitted due to a flag from our content filters.
    /// </summary>
    public enum CreateCompletionResponseChoiceFinishReason
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
    public static class CreateCompletionResponseChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCompletionResponseChoiceFinishReason value)
        {
            return value switch
            {
                CreateCompletionResponseChoiceFinishReason.Stop => "stop",
                CreateCompletionResponseChoiceFinishReason.Length => "length",
                CreateCompletionResponseChoiceFinishReason.ContentFilter => "content_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCompletionResponseChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateCompletionResponseChoiceFinishReason.Stop,
                "length" => CreateCompletionResponseChoiceFinishReason.Length,
                "content_filter" => CreateCompletionResponseChoiceFinishReason.ContentFilter,
                _ => null,
            };
        }
    }
}