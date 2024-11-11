//HintName: G.Models.PullsCreateReplyForReviewCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsCreateReplyForReviewCommentRequest
    {
        /// <summary>
        /// The text of the review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsCreateReplyForReviewCommentRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The text of the review comment.
        /// </param>
        public PullsCreateReplyForReviewCommentRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsCreateReplyForReviewCommentRequest" /> class.
        /// </summary>
        public PullsCreateReplyForReviewCommentRequest()
        {
        }
    }
}