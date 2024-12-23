﻿//HintName: G.Models.RepositoryRulePullRequestParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulePullRequestParameters
    {
        /// <summary>
        /// New, reviewable commits pushed will dismiss previous pull request review approvals.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismiss_stale_reviews_on_push", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DismissStaleReviewsOnPush { get; set; } = default!;

        /// <summary>
        /// Require an approving review in pull requests that modify files that have a designated code owner.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_code_owner_review", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireCodeOwnerReview { get; set; } = default!;

        /// <summary>
        /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_last_push_approval", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireLastPushApproval { get; set; } = default!;

        /// <summary>
        /// The number of approving reviews that are required before a pull request can be merged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequiredApprovingReviewCount { get; set; } = default!;

        /// <summary>
        /// All conversations on code must be resolved before a pull request can be merged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_review_thread_resolution", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequiredReviewThreadResolution { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulePullRequestParameters" /> class.
        /// </summary>
        /// <param name="dismissStaleReviewsOnPush">
        /// New, reviewable commits pushed will dismiss previous pull request review approvals.
        /// </param>
        /// <param name="requireCodeOwnerReview">
        /// Require an approving review in pull requests that modify files that have a designated code owner.
        /// </param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it.
        /// </param>
        /// <param name="requiredApprovingReviewCount">
        /// The number of approving reviews that are required before a pull request can be merged.
        /// </param>
        /// <param name="requiredReviewThreadResolution">
        /// All conversations on code must be resolved before a pull request can be merged.
        /// </param>
        public RepositoryRulePullRequestParameters(
            bool dismissStaleReviewsOnPush,
            bool requireCodeOwnerReview,
            bool requireLastPushApproval,
            int requiredApprovingReviewCount,
            bool requiredReviewThreadResolution)
        {
            this.DismissStaleReviewsOnPush = dismissStaleReviewsOnPush;
            this.RequireCodeOwnerReview = requireCodeOwnerReview;
            this.RequireLastPushApproval = requireLastPushApproval;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
            this.RequiredReviewThreadResolution = requiredReviewThreadResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulePullRequestParameters" /> class.
        /// </summary>
        public RepositoryRulePullRequestParameters()
        {
        }
    }
}