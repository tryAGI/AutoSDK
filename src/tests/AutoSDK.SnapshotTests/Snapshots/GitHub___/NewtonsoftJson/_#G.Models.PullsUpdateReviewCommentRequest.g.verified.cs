//HintName: G.Models.PullsUpdateReviewCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsUpdateReviewCommentRequest
    {
        /// <summary>
        /// The text of the reply to the review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateReviewCommentRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The text of the reply to the review comment.
        /// </param>
        public PullsUpdateReviewCommentRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateReviewCommentRequest" /> class.
        /// </summary>
        public PullsUpdateReviewCommentRequest()
        {
        }
    }
}