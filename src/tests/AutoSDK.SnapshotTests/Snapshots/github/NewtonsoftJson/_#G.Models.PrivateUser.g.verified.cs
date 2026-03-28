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
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDQ6VXNlcjE=
        /// </summary>
        /// <example>MDQ6VXNlcjE=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        /// <example>https://github.com/images/error/octocat_happy.gif</example>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// Example: 41d064eb2195891e12d0413f63227ea7
        /// </summary>
        /// <example>41d064eb2195891e12d0413f63227ea7</example>
        [global::Newtonsoft.Json.JsonProperty("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/users/octocat
        /// </summary>
        /// <example>https://api.github.com/users/octocat</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        /// <example>https://github.com/octocat</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/followers
        /// </summary>
        /// <example>https://api.github.com/users/octocat/followers</example>
        [global::Newtonsoft.Json.JsonProperty("followers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FollowersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/following{/other_user}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/following{/other_user}</example>
        [global::Newtonsoft.Json.JsonProperty("following_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FollowingUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/gists{/gist_id}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/gists{/gist_id}</example>
        [global::Newtonsoft.Json.JsonProperty("gists_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GistsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/starred{/owner}{/repo}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/starred{/owner}{/repo}</example>
        [global::Newtonsoft.Json.JsonProperty("starred_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StarredUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/subscriptions
        /// </summary>
        /// <example>https://api.github.com/users/octocat/subscriptions</example>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/orgs
        /// </summary>
        /// <example>https://api.github.com/users/octocat/orgs</example>
        [global::Newtonsoft.Json.JsonProperty("organizations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/repos
        /// </summary>
        /// <example>https://api.github.com/users/octocat/repos</example>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/events{/privacy}
        /// </summary>
        /// <example>https://api.github.com/users/octocat/events{/privacy}</example>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/received_events
        /// </summary>
        /// <example>https://api.github.com/users/octocat/received_events</example>
        [global::Newtonsoft.Json.JsonProperty("received_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReceivedEventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: User
        /// </summary>
        /// <example>User</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_admin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SiteAdmin { get; set; } = default!;

        /// <summary>
        /// Example: monalisa octocat
        /// </summary>
        /// <example>monalisa octocat</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Example: https://github.com/blog
        /// </summary>
        /// <example>https://github.com/blog</example>
        [global::Newtonsoft.Json.JsonProperty("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// Example: San Francisco
        /// </summary>
        /// <example>San Francisco</example>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        /// <example>octocat@github.com</example>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        /// <example>octocat@github.com</example>
        [global::Newtonsoft.Json.JsonProperty("notification_email")]
        public string? NotificationEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hireable")]
        public bool? Hireable { get; set; }

        /// <summary>
        /// Example: There once was...
        /// </summary>
        /// <example>There once was...</example>
        [global::Newtonsoft.Json.JsonProperty("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// Example: monalisa
        /// </summary>
        /// <example>monalisa</example>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("public_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicRepos { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("public_gists", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicGists { get; set; } = default!;

        /// <summary>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::Newtonsoft.Json.JsonProperty("followers", Required = global::Newtonsoft.Json.Required.Always)]
        public int Followers { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("following", Required = global::Newtonsoft.Json.Required.Always)]
        public int Following { get; set; } = default!;

        /// <summary>
        /// Example: 2008-01-14T04:33:35Z
        /// </summary>
        /// <example>2008-01-14T04:33:35Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2008-01-14T04:33:35Z
        /// </summary>
        /// <example>2008-01-14T04:33:35Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 81
        /// </summary>
        /// <example>81</example>
        [global::Newtonsoft.Json.JsonProperty("private_gists", Required = global::Newtonsoft.Json.Required.Always)]
        public int PrivateGists { get; set; } = default!;

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("total_private_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalPrivateRepos { get; set; } = default!;

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("owned_private_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int OwnedPrivateRepos { get; set; } = default!;

        /// <summary>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::Newtonsoft.Json.JsonProperty("disk_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public int DiskUsage { get; set; } = default!;

        /// <summary>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::Newtonsoft.Json.JsonProperty("collaborators", Required = global::Newtonsoft.Json.Required.Always)]
        public int Collaborators { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("two_factor_authentication", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TwoFactorAuthentication { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.PrivateUserPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suspended_at")]
        public global::System.DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("business_plus")]
        public bool? BusinessPlus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ldap_dn")]
        public string? LdapDn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUser" /> class.
        /// </summary>
        /// <param name="login">
        /// Example: octocat
        /// </param>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6VXNlcjE=
        /// </param>
        /// <param name="avatarUrl">
        /// Example: https://github.com/images/error/octocat_happy.gif
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
        /// <param name="createdAt">
        /// Example: 2008-01-14T04:33:35Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2008-01-14T04:33:35Z
        /// </param>
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
        /// <param name="gravatarId">
        /// Example: 41d064eb2195891e12d0413f63227ea7
        /// </param>
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
        /// <param name="plan"></param>
        /// <param name="suspendedAt"></param>
        /// <param name="businessPlus"></param>
        /// <param name="ldapDn"></param>
        public PrivateUser(
            string login,
            long id,
            string nodeId,
            string avatarUrl,
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
            string? gravatarId,
            string? name,
            string? company,
            string? blog,
            string? location,
            string? email,
            string? notificationEmail,
            bool? hireable,
            string? bio,
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
            this.GravatarId = gravatarId;
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
            this.Company = company;
            this.Blog = blog;
            this.Location = location;
            this.Email = email;
            this.NotificationEmail = notificationEmail;
            this.Hireable = hireable;
            this.Bio = bio;
            this.TwitterUsername = twitterUsername;
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