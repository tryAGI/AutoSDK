//HintName: G.Models.NullableSimpleUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub user.
    /// </summary>
    public sealed partial class NullableSimpleUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDQ6VXNlcjE=
        /// </summary>
        /// <example>MDQ6VXNlcjE=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        /// <example>https://github.com/images/error/octocat_happy.gif</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Example: 41d064eb2195891e12d0413f63227ea7
        /// </summary>
        /// <example>41d064eb2195891e12d0413f63227ea7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gravatar_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? GravatarId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat
        /// </summary>
        /// <example>https://api.github.com/users/octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        /// <example>https://github.com/octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/followers
        /// </summary>
        /// <example>https://api.github.com/users/octocat/followers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FollowersUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/following{/other_user}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/following{/other_user}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("following_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FollowingUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/gists{/gist_id}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/gists{/gist_id}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gists_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GistsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/starred{/owner}{/repo}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/starred{/owner}{/repo}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StarredUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/subscriptions
        /// </summary>
        /// <example>https://api.github.com/users/octocat/subscriptions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/orgs
        /// </summary>
        /// <example>https://api.github.com/users/octocat/orgs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/repos
        /// </summary>
        /// <example>https://api.github.com/users/octocat/repos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReposUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/events{/privacy}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/events{/privacy}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat/received_events
        /// </summary>
        /// <example>https://api.github.com/users/octocat/received_events</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReceivedEventsUrl { get; set; }

        /// <summary>
        /// Example: User
        /// </summary>
        /// <example>User</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SiteAdmin { get; set; }

        /// <summary>
        /// Example: "2020-07-09T00:17:55Z"
        /// </summary>
        /// <example>"2020-07-09T00:17:55Z"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred_at")]
        public string? StarredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableSimpleUser" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="login">
        /// Example: octocat
        /// </param>
        /// <param name="id">
        /// Example: 1L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6VXNlcjE=
        /// </param>
        /// <param name="avatarUrl">
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </param>
        /// <param name="gravatarId">
        /// Example: 41d064eb2195891e12d0413f63227ea7
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/users/octocat
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat
        /// </param>
        /// <param name="followersUrl">
        /// Example: https://api.github.com/users/octocat/followers
        /// </param>
        /// <param name="followingUrl">
        /// Example: https://api.github.com/users/octocat/following{/other_user}
        /// </param>
        /// <param name="gistsUrl">
        /// Example: https://api.github.com/users/octocat/gists{/gist_id}
        /// </param>
        /// <param name="starredUrl">
        /// Example: https://api.github.com/users/octocat/starred{/owner}{/repo}
        /// </param>
        /// <param name="subscriptionsUrl">
        /// Example: https://api.github.com/users/octocat/subscriptions
        /// </param>
        /// <param name="organizationsUrl">
        /// Example: https://api.github.com/users/octocat/orgs
        /// </param>
        /// <param name="reposUrl">
        /// Example: https://api.github.com/users/octocat/repos
        /// </param>
        /// <param name="eventsUrl">
        /// Example: https://api.github.com/users/octocat/events{/privacy}
        /// </param>
        /// <param name="receivedEventsUrl">
        /// Example: https://api.github.com/users/octocat/received_events
        /// </param>
        /// <param name="type">
        /// Example: User
        /// </param>
        /// <param name="siteAdmin"></param>
        /// <param name="starredAt">
        /// Example: "2020-07-09T00:17:55Z"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NullableSimpleUser(
            string login,
            long id,
            string nodeId,
            string avatarUrl,
            string? gravatarId,
            string url,
            string htmlUrl,
            string followersUrl,
            string followingUrl,
            string gistsUrl,
            string starredUrl,
            string subscriptionsUrl,
            string organizationsUrl,
            string reposUrl,
            string eventsUrl,
            string receivedEventsUrl,
            string type,
            bool siteAdmin,
            string? name,
            string? email,
            string? starredAt)
        {
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.GravatarId = gravatarId ?? throw new global::System.ArgumentNullException(nameof(gravatarId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.FollowersUrl = followersUrl ?? throw new global::System.ArgumentNullException(nameof(followersUrl));
            this.FollowingUrl = followingUrl ?? throw new global::System.ArgumentNullException(nameof(followingUrl));
            this.GistsUrl = gistsUrl ?? throw new global::System.ArgumentNullException(nameof(gistsUrl));
            this.StarredUrl = starredUrl ?? throw new global::System.ArgumentNullException(nameof(starredUrl));
            this.SubscriptionsUrl = subscriptionsUrl ?? throw new global::System.ArgumentNullException(nameof(subscriptionsUrl));
            this.OrganizationsUrl = organizationsUrl ?? throw new global::System.ArgumentNullException(nameof(organizationsUrl));
            this.ReposUrl = reposUrl ?? throw new global::System.ArgumentNullException(nameof(reposUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.ReceivedEventsUrl = receivedEventsUrl ?? throw new global::System.ArgumentNullException(nameof(receivedEventsUrl));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SiteAdmin = siteAdmin;
            this.Name = name;
            this.Email = email;
            this.StarredAt = starredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableSimpleUser" /> class.
        /// </summary>
        public NullableSimpleUser()
        {
        }
    }
}