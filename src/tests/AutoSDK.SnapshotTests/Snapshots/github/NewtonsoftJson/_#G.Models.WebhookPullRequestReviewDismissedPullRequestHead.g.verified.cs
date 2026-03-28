//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestHead.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewDismissedPullRequestHead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// A git repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo")]
        public global::G.WebhookPullRequestReviewDismissedPullRequestHeadRepo? Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.WebhookPullRequestReviewDismissedPullRequestHeadUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewDismissedPullRequestHead" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="repo">
        /// A git repository
        /// </param>
        /// <param name="user"></param>
        public WebhookPullRequestReviewDismissedPullRequestHead(
            string label,
            string @ref,
            string sha,
            global::G.WebhookPullRequestReviewDismissedPullRequestHeadRepo? repo,
            global::G.WebhookPullRequestReviewDismissedPullRequestHeadUser? user)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repo = repo;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewDismissedPullRequestHead" /> class.
        /// </summary>
        public WebhookPullRequestReviewDismissedPullRequestHead()
        {
        }
    }
}