//HintName: G.Models.ProtectedBranchRequiredPullRequestReviews.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchRequiredPullRequestReviews
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismiss_stale_reviews")]
        public bool DismissStaleReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_code_owner_reviews")]
        public bool RequireCodeOwnerReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_approving_review_count")]
        public int RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_last_push_approval")]
        public bool RequireLastPushApproval { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissal_restrictions")]
        public ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions? DismissalRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_pull_request_allowances")]
        public ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances? BypassPullRequestAllowances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}