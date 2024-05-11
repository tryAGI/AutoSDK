//HintName: G.Models.CreateCompletionResponseChoicesFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
    /// `length` if the maximum number of tokens specified in the request was reached,
    /// or `content_filter` if content was omitted due to a flag from our content filters.
    /// </summary>
    public abstract class CreateCompletionResponseChoicesFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Stop = "stop";
        /// <summary>
        /// 
        /// </summary>
        public const string Length = "length";
        /// <summary>
        /// 
        /// </summary>
        public const string ContentFilter = "content_filter";
    }
}