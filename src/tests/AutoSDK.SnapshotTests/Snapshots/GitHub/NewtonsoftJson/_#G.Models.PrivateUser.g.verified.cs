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
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Example: 1L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDQ6VXNlcjE=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// Example: 41d064eb2195891e12d0413f63227ea7
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gravatar_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? GravatarId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/followers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FollowersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/following{/other_user}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FollowingUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/gists{/gist_id}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gists_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GistsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/starred{/owner}{/repo}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starred_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StarredUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/subscriptions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/orgs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/repos
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/events{/privacy}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/users/octocat/received_events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("received_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReceivedEventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: User
        /// </summary>
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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Example: GitHub
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Company { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/blog
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blog", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Blog { get; set; } = default!;

        /// <summary>
        /// Example: San Francisco
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Location { get; set; } = default!;

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Email { get; set; } = default!;

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_email")]
        public string? NotificationEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hireable", Required = global::Newtonsoft.Json.Required.Always)]
        public bool? Hireable { get; set; } = default!;

        /// <summary>
        /// Example: There once was...
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bio", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Bio { get; set; } = default!;

        /// <summary>
        /// Example: monalisa
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicRepos { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_gists", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicGists { get; set; } = default!;

        /// <summary>
        /// Example: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers", Required = global::Newtonsoft.Json.Required.Always)]
        public int Followers { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following", Required = global::Newtonsoft.Json.Required.Always)]
        public int Following { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 81
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_gists", Required = global::Newtonsoft.Json.Required.Always)]
        public int PrivateGists { get; set; } = default!;

        /// <summary>
        /// Example: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_private_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalPrivateRepos { get; set; } = default!;

        /// <summary>
        /// Example: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_private_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int OwnedPrivateRepos { get; set; } = default!;

        /// <summary>
        /// Example: 10000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disk_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public int DiskUsage { get; set; } = default!;

        /// <summary>
        /// Example: 8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborators", Required = global::Newtonsoft.Json.Required.Always)]
        public int Collaborators { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PrivateUser? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PrivateUser>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PrivateUser?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PrivateUser?>(serializer.Deserialize<global::G.PrivateUser>(jsonReader));
        }

    }
}