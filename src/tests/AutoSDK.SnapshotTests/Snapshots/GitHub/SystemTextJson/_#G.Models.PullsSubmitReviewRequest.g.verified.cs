//HintName: G.Models.PullsSubmitReviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsSubmitReviewRequest
    {
        /// <summary>
        /// The body text of the pull request review
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullsSubmitReviewRequestEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullsSubmitReviewRequestEvent Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsSubmitReviewRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The body text of the pull request review
        /// </param>
        /// <param name="event">
        /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PullsSubmitReviewRequest(
            global::G.PullsSubmitReviewRequestEvent @event,
            string? body)
        {
            this.Event = @event;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsSubmitReviewRequest" /> class.
        /// </summary>
        public PullsSubmitReviewRequest()
        {
        }
    }
}