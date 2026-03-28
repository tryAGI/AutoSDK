//HintName: G.Models.PublicUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Public User
    /// </summary>
    public sealed partial class PublicUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("starred_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StarredUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("received_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReceivedEventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_admin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SiteAdmin { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_email")]
        public string? NotificationEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hireable")]
        public bool? Hireable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_gists", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicGists { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers", Required = global::Newtonsoft.Json.Required.Always)]
        public int Followers { get; set; } = default!;

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.PublicUserPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suspended_at")]
        public global::System.DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("private_gists")]
        public int? PrivateGists { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("total_private_repos")]
        public int? TotalPrivateRepos { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("owned_private_repos")]
        public int? OwnedPrivateRepos { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("disk_usage")]
        public int? DiskUsage { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("collaborators")]
        public int? Collaborators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUser" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="followersUrl"></param>
        /// <param name="followingUrl"></param>
        /// <param name="gistsUrl"></param>
        /// <param name="starredUrl"></param>
        /// <param name="subscriptionsUrl"></param>
        /// <param name="organizationsUrl"></param>
        /// <param name="reposUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="receivedEventsUrl"></param>
        /// <param name="type"></param>
        /// <param name="siteAdmin"></param>
        /// <param name="publicRepos"></param>
        /// <param name="publicGists"></param>
        /// <param name="followers"></param>
        /// <param name="following"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="gravatarId"></param>
        /// <param name="name"></param>
        /// <param name="company"></param>
        /// <param name="blog"></param>
        /// <param name="location"></param>
        /// <param name="email"></param>
        /// <param name="notificationEmail"></param>
        /// <param name="hireable"></param>
        /// <param name="bio"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="plan"></param>
        /// <param name="suspendedAt"></param>
        /// <param name="privateGists">
        /// Example: 1
        /// </param>
        /// <param name="totalPrivateRepos">
        /// Example: 2
        /// </param>
        /// <param name="ownedPrivateRepos">
        /// Example: 2
        /// </param>
        /// <param name="diskUsage">
        /// Example: 1
        /// </param>
        /// <param name="collaborators">
        /// Example: 3
        /// </param>
        public PublicUser(
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
            global::G.PublicUserPlan? plan,
            global::System.DateTime? suspendedAt,
            int? privateGists,
            int? totalPrivateRepos,
            int? ownedPrivateRepos,
            int? diskUsage,
            int? collaborators)
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
            this.Plan = plan;
            this.SuspendedAt = suspendedAt;
            this.PrivateGists = privateGists;
            this.TotalPrivateRepos = totalPrivateRepos;
            this.OwnedPrivateRepos = ownedPrivateRepos;
            this.DiskUsage = diskUsage;
            this.Collaborators = collaborators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUser" /> class.
        /// </summary>
        public PublicUser()
        {
        }
    }
}