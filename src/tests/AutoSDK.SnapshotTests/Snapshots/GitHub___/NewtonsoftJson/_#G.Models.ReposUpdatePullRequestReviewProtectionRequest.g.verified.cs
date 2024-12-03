//HintName: G.Models.ReposUpdatePullRequestReviewProtectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdatePullRequestReviewProtectionRequest
    {
        /// <summary>
        /// Specify which users, teams, and apps can dismiss pull request reviews. Pass an empty `dismissal_restrictions` object to disable. User and team `dismissal_restrictions` are only available for organization-owned repositories. Omit this parameter for personal repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissal_restrictions")]
        public global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions? DismissalRestrictions { get; set; }

        /// <summary>
        /// Set to `true` if you want to automatically dismiss approving reviews when someone pushes a new commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismiss_stale_reviews")]
        public bool? DismissStaleReviews { get; set; }

        /// <summary>
        /// Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) have reviewed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_code_owner_reviews")]
        public bool? RequireCodeOwnerReviews { get; set; }

        /// <summary>
        /// Specifies the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count")]
        public int? RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it. Default: `false`<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_last_push_approval")]
        public bool? RequireLastPushApproval { get; set; }

        /// <summary>
        /// Allow specific users, teams, or apps to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_pull_request_allowances")]
        public global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances? BypassPullRequestAllowances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequest" /> class.
        /// </summary>
        /// <param name="dismissalRestrictions">
        /// Specify which users, teams, and apps can dismiss pull request reviews. Pass an empty `dismissal_restrictions` object to disable. User and team `dismissal_restrictions` are only available for organization-owned repositories. Omit this parameter for personal repositories.
        /// </param>
        /// <param name="dismissStaleReviews">
        /// Set to `true` if you want to automatically dismiss approving reviews when someone pushes a new commit.
        /// </param>
        /// <param name="requireCodeOwnerReviews">
        /// Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) have reviewed.
        /// </param>
        /// <param name="requiredApprovingReviewCount">
        /// Specifies the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers.
        /// </param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent push must be approved by someone other than the person who pushed it. Default: `false`<br/>
        /// Default Value: false
        /// </param>
        /// <param name="bypassPullRequestAllowances">
        /// Allow specific users, teams, or apps to bypass pull request requirements.
        /// </param>
        public ReposUpdatePullRequestReviewProtectionRequest(
            global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions? dismissalRestrictions,
            bool? dismissStaleReviews,
            bool? requireCodeOwnerReviews,
            int? requiredApprovingReviewCount,
            bool? requireLastPushApproval,
            global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances? bypassPullRequestAllowances)
        {
            this.DismissalRestrictions = dismissalRestrictions;
            this.DismissStaleReviews = dismissStaleReviews;
            this.RequireCodeOwnerReviews = requireCodeOwnerReviews;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
            this.RequireLastPushApproval = requireLastPushApproval;
            this.BypassPullRequestAllowances = bypassPullRequestAllowances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequest" /> class.
        /// </summary>
        public ReposUpdatePullRequestReviewProtectionRequest()
        {
        }
    }
}