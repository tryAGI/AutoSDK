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
        public bool? DismissStaleReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_code_owner_reviews")]
        public bool? RequireCodeOwnerReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_approving_review_count")]
        public int? RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_last_push_approval")]
        public bool? RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissal_restrictions")]
        public global::G.ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions? DismissalRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_pull_request_allowances")]
        public global::G.ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances? BypassPullRequestAllowances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviews" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dismissStaleReviews"></param>
        /// <param name="requireCodeOwnerReviews"></param>
        /// <param name="requiredApprovingReviewCount"></param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent push must be approved by someone other than the person who pushed it.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dismissalRestrictions"></param>
        /// <param name="bypassPullRequestAllowances"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProtectedBranchRequiredPullRequestReviews(
            string url,
            bool? dismissStaleReviews,
            bool? requireCodeOwnerReviews,
            int? requiredApprovingReviewCount,
            bool? requireLastPushApproval,
            global::G.ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions? dismissalRestrictions,
            global::G.ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances? bypassPullRequestAllowances)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.DismissStaleReviews = dismissStaleReviews;
            this.RequireCodeOwnerReviews = requireCodeOwnerReviews;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
            this.RequireLastPushApproval = requireLastPushApproval;
            this.DismissalRestrictions = dismissalRestrictions;
            this.BypassPullRequestAllowances = bypassPullRequestAllowances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviews" /> class.
        /// </summary>
        public ProtectedBranchRequiredPullRequestReviews()
        {
        }
    }
}