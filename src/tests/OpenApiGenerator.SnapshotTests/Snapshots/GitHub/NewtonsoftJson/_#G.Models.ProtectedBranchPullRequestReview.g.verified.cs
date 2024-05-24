//HintName: G.Models.ProtectedBranchPullRequestReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Protected Branch Pull Request Review
    /// </summary>
    public sealed partial class ProtectedBranchPullRequestReview
    {
        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/dismissal_restrictions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissal_restrictions")]
        public ProtectedBranchPullRequestReviewDismissalRestrictions? DismissalRestrictions { get; set; }

        /// <summary>
        /// Allow specific users, teams, or apps to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_pull_request_allowances")]
        public ProtectedBranchPullRequestReviewBypassPullRequestAllowances? BypassPullRequestAllowances { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismiss_stale_reviews", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DismissStaleReviews { get; set; } = default!;

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_code_owner_reviews", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireCodeOwnerReviews { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count")]
        public int RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it.
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_last_push_approval")]
        public bool RequireLastPushApproval { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}