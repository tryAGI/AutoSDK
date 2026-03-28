//HintName: G.Models.WebhookPullRequestLockedPullRequestHead.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestLockedPullRequestHead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// A git repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo")]
        public global::G.WebhookPullRequestLockedPullRequestHeadRepo? Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.WebhookPullRequestLockedPullRequestHeadUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestHead" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="label"></param>
        /// <param name="repo">
        /// A git repository
        /// </param>
        /// <param name="user"></param>
        public WebhookPullRequestLockedPullRequestHead(
            string @ref,
            string sha,
            string? label,
            global::G.WebhookPullRequestLockedPullRequestHeadRepo? repo,
            global::G.WebhookPullRequestLockedPullRequestHeadUser? user)
        {
            this.Label = label;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repo = repo;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestHead" /> class.
        /// </summary>
        public WebhookPullRequestLockedPullRequestHead()
        {
        }
    }
}