//HintName: G.Models.FeedLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedLinks
    {
        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeline", Required = global::Newtonsoft.Json.Required.Always)]
        public LinkWithType Timeline { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public LinkWithType User { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_advisories")]
        public LinkWithType? SecurityAdvisories { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user")]
        public LinkWithType? CurrentUser { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_public")]
        public LinkWithType? CurrentUserPublic { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_actor")]
        public LinkWithType? CurrentUserActor { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_organization")]
        public LinkWithType? CurrentUserOrganization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_organizations")]
        public global::System.Collections.Generic.IList<LinkWithType>? CurrentUserOrganizations { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions")]
        public LinkWithType? RepositoryDiscussions { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions_category")]
        public LinkWithType? RepositoryDiscussionsCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}