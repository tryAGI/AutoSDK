//HintName: G.Models.WebhookInstallationTargetRenamedAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInstallationTargetRenamedAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_at")]
        public string? ArchivedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public object? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers")]
        public int? Followers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers_url")]
        public string? FollowersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following")]
        public int? Following { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following_url")]
        public string? FollowingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gists_url")]
        public string? GistsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_organization_projects")]
        public bool? HasOrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_repository_projects")]
        public bool? HasRepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url")]
        public string? HooksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url")]
        public string? IssuesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations_url")]
        public string? OrganizationsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_gists")]
        public int? PublicGists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_members_url")]
        public string? PublicMembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_repos")]
        public int? PublicRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("received_events_url")]
        public string? ReceivedEventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url")]
        public string? ReposUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_admin")]
        public bool? SiteAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starred_url")]
        public string? StarredUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_url")]
        public string? SubscriptionsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website_url")]
        public object? WebsiteUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationTargetRenamedAccount" /> class.
        /// </summary>
        /// <param name="archivedAt"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="followers"></param>
        /// <param name="followersUrl"></param>
        /// <param name="following"></param>
        /// <param name="followingUrl"></param>
        /// <param name="gistsUrl"></param>
        /// <param name="gravatarId"></param>
        /// <param name="hasOrganizationProjects"></param>
        /// <param name="hasRepositoryProjects"></param>
        /// <param name="hooksUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="isVerified"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="login"></param>
        /// <param name="membersUrl"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="organizationsUrl"></param>
        /// <param name="publicGists"></param>
        /// <param name="publicMembersUrl"></param>
        /// <param name="publicRepos"></param>
        /// <param name="receivedEventsUrl"></param>
        /// <param name="reposUrl"></param>
        /// <param name="siteAdmin"></param>
        /// <param name="slug"></param>
        /// <param name="starredUrl"></param>
        /// <param name="subscriptionsUrl"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="websiteUrl"></param>
        public WebhookInstallationTargetRenamedAccount(
            string avatarUrl,
            string htmlUrl,
            int id,
            string nodeId,
            string? archivedAt,
            string? createdAt,
            object? description,
            string? eventsUrl,
            int? followers,
            string? followersUrl,
            int? following,
            string? followingUrl,
            string? gistsUrl,
            string? gravatarId,
            bool? hasOrganizationProjects,
            bool? hasRepositoryProjects,
            string? hooksUrl,
            bool? isVerified,
            string? issuesUrl,
            string? login,
            string? membersUrl,
            string? name,
            string? organizationsUrl,
            int? publicGists,
            string? publicMembersUrl,
            int? publicRepos,
            string? receivedEventsUrl,
            string? reposUrl,
            bool? siteAdmin,
            string? slug,
            string? starredUrl,
            string? subscriptionsUrl,
            string? type,
            string? updatedAt,
            string? url,
            object? websiteUrl)
        {
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ArchivedAt = archivedAt;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.EventsUrl = eventsUrl;
            this.Followers = followers;
            this.FollowersUrl = followersUrl;
            this.Following = following;
            this.FollowingUrl = followingUrl;
            this.GistsUrl = gistsUrl;
            this.GravatarId = gravatarId;
            this.HasOrganizationProjects = hasOrganizationProjects;
            this.HasRepositoryProjects = hasRepositoryProjects;
            this.HooksUrl = hooksUrl;
            this.IsVerified = isVerified;
            this.IssuesUrl = issuesUrl;
            this.Login = login;
            this.MembersUrl = membersUrl;
            this.Name = name;
            this.OrganizationsUrl = organizationsUrl;
            this.PublicGists = publicGists;
            this.PublicMembersUrl = publicMembersUrl;
            this.PublicRepos = publicRepos;
            this.ReceivedEventsUrl = receivedEventsUrl;
            this.ReposUrl = reposUrl;
            this.SiteAdmin = siteAdmin;
            this.Slug = slug;
            this.StarredUrl = starredUrl;
            this.SubscriptionsUrl = subscriptionsUrl;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.WebsiteUrl = websiteUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationTargetRenamedAccount" /> class.
        /// </summary>
        public WebhookInstallationTargetRenamedAccount()
        {
        }
    }
}