//HintName: G.Models.PrivateUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Private User
    /// </summary>
    public sealed partial class PrivateUser
    {
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
        /// Example: monalisa octocat
        /// </summary>
        /// <example>monalisa octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Company { get; set; }

        /// <summary>
        /// Example: https://github.com/blog
        /// </summary>
        /// <example>https://github.com/blog</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Blog { get; set; }

        /// <summary>
        /// Example: San Francisco
        /// </summary>
        /// <example>San Francisco</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Location { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        /// <example>octocat@github.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Email { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        /// <example>octocat@github.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_email")]
        public string? NotificationEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hireable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? Hireable { get; set; }

        /// <summary>
        /// Example: There once was...
        /// </summary>
        /// <example>There once was...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Bio { get; set; }

        /// <summary>
        /// Example: monalisa
        /// </summary>
        /// <example>monalisa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicRepos { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_gists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicGists { get; set; }

        /// <summary>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Followers { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("following")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Following { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: 81
        /// </summary>
        /// <example>81</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_gists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PrivateGists { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_private_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPrivateRepos { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_private_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OwnedPrivateRepos { get; set; }

        /// <summary>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DiskUsage { get; set; }

        /// <summary>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Collaborators { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("two_factor_authentication")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TwoFactorAuthentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::G.PrivateUserPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_at")]
        public global::System.DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_plus")]
        public bool? BusinessPlus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ldap_dn")]
        public string? LdapDn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUser" /> class.
        /// </summary>
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
        /// <param name="name">
        /// Example: monalisa octocat
        /// </param>
        /// <param name="company">
        /// Example: GitHub
        /// </param>
        /// <param name="blog">
        /// Example: https://github.com/blog
        /// </param>
        /// <param name="location">
        /// Example: San Francisco
        /// </param>
        /// <param name="email">
        /// Example: octocat@github.com
        /// </param>
        /// <param name="notificationEmail">
        /// Example: octocat@github.com
        /// </param>
        /// <param name="hireable"></param>
        /// <param name="bio">
        /// Example: There once was...
        /// </param>
        /// <param name="twitterUsername">
        /// Example: monalisa
        /// </param>
        /// <param name="publicRepos">
        /// Example: 2
        /// </param>
        /// <param name="publicGists">
        /// Example: 1
        /// </param>
        /// <param name="followers">
        /// Example: 20
        /// </param>
        /// <param name="following">
        /// Example: 0
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="privateGists">
        /// Example: 81
        /// </param>
        /// <param name="totalPrivateRepos">
        /// Example: 100
        /// </param>
        /// <param name="ownedPrivateRepos">
        /// Example: 100
        /// </param>
        /// <param name="diskUsage">
        /// Example: 10000
        /// </param>
        /// <param name="collaborators">
        /// Example: 8
        /// </param>
        /// <param name="twoFactorAuthentication">
        /// Example: true
        /// </param>
        /// <param name="plan"></param>
        /// <param name="suspendedAt"></param>
        /// <param name="businessPlus"></param>
        /// <param name="ldapDn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateUser(
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
            string? company,
            string? blog,
            string? location,
            string? email,
            bool? hireable,
            string? bio,
            int publicRepos,
            int publicGists,
            int followers,
            int following,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int privateGists,
            int totalPrivateRepos,
            int ownedPrivateRepos,
            int diskUsage,
            int collaborators,
            bool twoFactorAuthentication,
            string? notificationEmail,
            string? twitterUsername,
            global::G.PrivateUserPlan? plan,
            global::System.DateTime? suspendedAt,
            bool? businessPlus,
            string? ldapDn)
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
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Company = company ?? throw new global::System.ArgumentNullException(nameof(company));
            this.Blog = blog ?? throw new global::System.ArgumentNullException(nameof(blog));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Hireable = hireable;
            this.Bio = bio ?? throw new global::System.ArgumentNullException(nameof(bio));
            this.PublicRepos = publicRepos;
            this.PublicGists = publicGists;
            this.Followers = followers;
            this.Following = following;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PrivateGists = privateGists;
            this.TotalPrivateRepos = totalPrivateRepos;
            this.OwnedPrivateRepos = ownedPrivateRepos;
            this.DiskUsage = diskUsage;
            this.Collaborators = collaborators;
            this.TwoFactorAuthentication = twoFactorAuthentication;
            this.NotificationEmail = notificationEmail;
            this.TwitterUsername = twitterUsername;
            this.Plan = plan;
            this.SuspendedAt = suspendedAt;
            this.BusinessPlus = businessPlus;
            this.LdapDn = ldapDn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUser" /> class.
        /// </summary>
        public PrivateUser()
        {
        }
    }
}