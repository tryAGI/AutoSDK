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
        public global::G.LinkWithType Timeline { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LinkWithType User { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_advisories")]
        public global::G.LinkWithType? SecurityAdvisories { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user")]
        public global::G.LinkWithType? CurrentUser { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_public")]
        public global::G.LinkWithType? CurrentUserPublic { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_actor")]
        public global::G.LinkWithType? CurrentUserActor { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_organization")]
        public global::G.LinkWithType? CurrentUserOrganization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_organizations")]
        public global::System.Collections.Generic.IList<global::G.LinkWithType>? CurrentUserOrganizations { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions")]
        public global::G.LinkWithType? RepositoryDiscussions { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions_category")]
        public global::G.LinkWithType? RepositoryDiscussionsCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedLinks" /> class.
        /// </summary>
        /// <param name="timeline">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="user">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="securityAdvisories">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUser">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserPublic">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserActor">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserOrganization">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserOrganizations"></param>
        /// <param name="repositoryDiscussions">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="repositoryDiscussionsCategory">
        /// Hypermedia Link with Type
        /// </param>
        public FeedLinks(
            global::G.LinkWithType timeline,
            global::G.LinkWithType user,
            global::G.LinkWithType? securityAdvisories,
            global::G.LinkWithType? currentUser,
            global::G.LinkWithType? currentUserPublic,
            global::G.LinkWithType? currentUserActor,
            global::G.LinkWithType? currentUserOrganization,
            global::System.Collections.Generic.IList<global::G.LinkWithType>? currentUserOrganizations,
            global::G.LinkWithType? repositoryDiscussions,
            global::G.LinkWithType? repositoryDiscussionsCategory)
        {
            this.Timeline = timeline ?? throw new global::System.ArgumentNullException(nameof(timeline));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.SecurityAdvisories = securityAdvisories;
            this.CurrentUser = currentUser;
            this.CurrentUserPublic = currentUserPublic;
            this.CurrentUserActor = currentUserActor;
            this.CurrentUserOrganization = currentUserOrganization;
            this.CurrentUserOrganizations = currentUserOrganizations;
            this.RepositoryDiscussions = repositoryDiscussions;
            this.RepositoryDiscussionsCategory = repositoryDiscussionsCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedLinks" /> class.
        /// </summary>
        public FeedLinks()
        {
        }
    }
}