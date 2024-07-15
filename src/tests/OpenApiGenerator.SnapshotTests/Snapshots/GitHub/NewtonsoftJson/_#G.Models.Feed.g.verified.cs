//HintName: G.Models.Feed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feed
    /// </summary>
    public sealed partial class Feed
    {
        /// <summary>
        /// Example: https://github.com/timeline
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeline_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TimelineUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/{user}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_public_url")]
        public string? CurrentUserPublicUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat.private?token=abc123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_url")]
        public string? CurrentUserUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat.private.actor?token=abc123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_actor_url")]
        public string? CurrentUserActorUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat-org
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_organization_url")]
        public string? CurrentUserOrganizationUrl { get; set; }

        /// <summary>
        /// Example: [https://github.com/organizations/github/octocat.private.atom?token=abc123]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_organization_urls")]
        public global::System.Collections.Generic.IList<string?>? CurrentUserOrganizationUrls { get; set; }

        /// <summary>
        /// Example: https://github.com/security-advisories
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_advisories_url")]
        public string? SecurityAdvisoriesUrl { get; set; }

        /// <summary>
        /// A feed of discussions for a given repository.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions_url")]
        public string? RepositoryDiscussionsUrl { get; set; }

        /// <summary>
        /// A feed of discussions for a given repository and category.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions/categories/{category}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions_category_url")]
        public string? RepositoryDiscussionsCategoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FeedLinks Links { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}