//HintName: G.Models.Root.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Root
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurrentUserUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_authorizations_html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurrentUserAuthorizationsHtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorizations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthorizationsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_search_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CodeSearchUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_search_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitSearchUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmailsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emojis_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmojisUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feeds_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FollowersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FollowingUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gists_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GistsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hub_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? HubUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_search_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueSearchUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keys_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeysUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_search_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelSearchUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notifications_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string NotificationsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationRepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationTeamsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_gists_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicGistsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RateLimitUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_search_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositorySearchUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurrentUserRepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starred_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StarredUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starred_gists_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StarredGistsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_search_url")]
        public string? TopicSearchUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_organizations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserOrganizationsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserRepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_search_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserSearchUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Root" /> class.
        /// </summary>
        /// <param name="currentUserUrl"></param>
        /// <param name="currentUserAuthorizationsHtmlUrl"></param>
        /// <param name="authorizationsUrl"></param>
        /// <param name="codeSearchUrl"></param>
        /// <param name="commitSearchUrl"></param>
        /// <param name="emailsUrl"></param>
        /// <param name="emojisUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="feedsUrl"></param>
        /// <param name="followersUrl"></param>
        /// <param name="followingUrl"></param>
        /// <param name="gistsUrl"></param>
        /// <param name="issueSearchUrl"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="keysUrl"></param>
        /// <param name="labelSearchUrl"></param>
        /// <param name="notificationsUrl"></param>
        /// <param name="organizationUrl"></param>
        /// <param name="organizationRepositoriesUrl"></param>
        /// <param name="organizationTeamsUrl"></param>
        /// <param name="publicGistsUrl"></param>
        /// <param name="rateLimitUrl"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="repositorySearchUrl"></param>
        /// <param name="currentUserRepositoriesUrl"></param>
        /// <param name="starredUrl"></param>
        /// <param name="starredGistsUrl"></param>
        /// <param name="topicSearchUrl"></param>
        /// <param name="userUrl"></param>
        /// <param name="userOrganizationsUrl"></param>
        /// <param name="userRepositoriesUrl"></param>
        /// <param name="userSearchUrl"></param>
        public Root(
            string currentUserUrl,
            string currentUserAuthorizationsHtmlUrl,
            string authorizationsUrl,
            string codeSearchUrl,
            string commitSearchUrl,
            string emailsUrl,
            string emojisUrl,
            string eventsUrl,
            string feedsUrl,
            string followersUrl,
            string followingUrl,
            string gistsUrl,
            string issueSearchUrl,
            string issuesUrl,
            string keysUrl,
            string labelSearchUrl,
            string notificationsUrl,
            string organizationUrl,
            string organizationRepositoriesUrl,
            string organizationTeamsUrl,
            string publicGistsUrl,
            string rateLimitUrl,
            string repositoryUrl,
            string repositorySearchUrl,
            string currentUserRepositoriesUrl,
            string starredUrl,
            string starredGistsUrl,
            string userUrl,
            string userOrganizationsUrl,
            string userRepositoriesUrl,
            string userSearchUrl,
            string? topicSearchUrl)
        {
            this.CurrentUserUrl = currentUserUrl ?? throw new global::System.ArgumentNullException(nameof(currentUserUrl));
            this.CurrentUserAuthorizationsHtmlUrl = currentUserAuthorizationsHtmlUrl ?? throw new global::System.ArgumentNullException(nameof(currentUserAuthorizationsHtmlUrl));
            this.AuthorizationsUrl = authorizationsUrl ?? throw new global::System.ArgumentNullException(nameof(authorizationsUrl));
            this.CodeSearchUrl = codeSearchUrl ?? throw new global::System.ArgumentNullException(nameof(codeSearchUrl));
            this.CommitSearchUrl = commitSearchUrl ?? throw new global::System.ArgumentNullException(nameof(commitSearchUrl));
            this.EmailsUrl = emailsUrl ?? throw new global::System.ArgumentNullException(nameof(emailsUrl));
            this.EmojisUrl = emojisUrl ?? throw new global::System.ArgumentNullException(nameof(emojisUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.FeedsUrl = feedsUrl ?? throw new global::System.ArgumentNullException(nameof(feedsUrl));
            this.FollowersUrl = followersUrl ?? throw new global::System.ArgumentNullException(nameof(followersUrl));
            this.FollowingUrl = followingUrl ?? throw new global::System.ArgumentNullException(nameof(followingUrl));
            this.GistsUrl = gistsUrl ?? throw new global::System.ArgumentNullException(nameof(gistsUrl));
            this.IssueSearchUrl = issueSearchUrl ?? throw new global::System.ArgumentNullException(nameof(issueSearchUrl));
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.KeysUrl = keysUrl ?? throw new global::System.ArgumentNullException(nameof(keysUrl));
            this.LabelSearchUrl = labelSearchUrl ?? throw new global::System.ArgumentNullException(nameof(labelSearchUrl));
            this.NotificationsUrl = notificationsUrl ?? throw new global::System.ArgumentNullException(nameof(notificationsUrl));
            this.OrganizationUrl = organizationUrl ?? throw new global::System.ArgumentNullException(nameof(organizationUrl));
            this.OrganizationRepositoriesUrl = organizationRepositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(organizationRepositoriesUrl));
            this.OrganizationTeamsUrl = organizationTeamsUrl ?? throw new global::System.ArgumentNullException(nameof(organizationTeamsUrl));
            this.PublicGistsUrl = publicGistsUrl ?? throw new global::System.ArgumentNullException(nameof(publicGistsUrl));
            this.RateLimitUrl = rateLimitUrl ?? throw new global::System.ArgumentNullException(nameof(rateLimitUrl));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.RepositorySearchUrl = repositorySearchUrl ?? throw new global::System.ArgumentNullException(nameof(repositorySearchUrl));
            this.CurrentUserRepositoriesUrl = currentUserRepositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(currentUserRepositoriesUrl));
            this.StarredUrl = starredUrl ?? throw new global::System.ArgumentNullException(nameof(starredUrl));
            this.StarredGistsUrl = starredGistsUrl ?? throw new global::System.ArgumentNullException(nameof(starredGistsUrl));
            this.UserUrl = userUrl ?? throw new global::System.ArgumentNullException(nameof(userUrl));
            this.UserOrganizationsUrl = userOrganizationsUrl ?? throw new global::System.ArgumentNullException(nameof(userOrganizationsUrl));
            this.UserRepositoriesUrl = userRepositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(userRepositoriesUrl));
            this.UserSearchUrl = userSearchUrl ?? throw new global::System.ArgumentNullException(nameof(userSearchUrl));
            this.TopicSearchUrl = topicSearchUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Root" /> class.
        /// </summary>
        public Root()
        {
        }
    }
}