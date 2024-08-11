//HintName: G.Models.PullsCreateReviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsCreateReviewRequest
    {
        /// <summary>
        /// The SHA of the commit that needs a review. Not using the latest commit SHA may render your review comment outdated if a subsequent commit modifies the line you specify as the `position`. Defaults to the most recent commit in the pull request when you do not specify a value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        /// **Required** when using `REQUEST_CHANGES` or `COMMENT` for the `event` parameter. The body text of the pull request review.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls/reviews#submit-a-review-for-a-pull-request) when you are ready.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.PullsCreateReviewRequestEvent? Event { get; set; }

        /// <summary>
        /// Use the following table to specify the location, destination, and contents of the draft review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public global::System.Collections.Generic.IList<global::G.PullsCreateReviewRequestComment>? Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}