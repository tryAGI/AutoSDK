//HintName: G.Models.PullRequestHeadRepoOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestHeadRepoOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("gravatar_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? GravatarId { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("received_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReceivedEventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_admin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SiteAdmin { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestHeadRepoOwner" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="followersUrl"></param>
        /// <param name="followingUrl"></param>
        /// <param name="gistsUrl"></param>
        /// <param name="gravatarId"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="login"></param>
        /// <param name="organizationsUrl"></param>
        /// <param name="receivedEventsUrl"></param>
        /// <param name="reposUrl"></param>
        /// <param name="siteAdmin"></param>
        /// <param name="starredUrl"></param>
        /// <param name="subscriptionsUrl"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        public PullRequestHeadRepoOwner(
            string avatarUrl,
            string eventsUrl,
            string followersUrl,
            string followingUrl,
            string gistsUrl,
            string? gravatarId,
            string htmlUrl,
            int id,
            string nodeId,
            string login,
            string organizationsUrl,
            string receivedEventsUrl,
            string reposUrl,
            bool siteAdmin,
            string starredUrl,
            string subscriptionsUrl,
            string type,
            string url)
        {
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.FollowersUrl = followersUrl ?? throw new global::System.ArgumentNullException(nameof(followersUrl));
            this.FollowingUrl = followingUrl ?? throw new global::System.ArgumentNullException(nameof(followingUrl));
            this.GistsUrl = gistsUrl ?? throw new global::System.ArgumentNullException(nameof(gistsUrl));
            this.GravatarId = gravatarId ?? throw new global::System.ArgumentNullException(nameof(gravatarId));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.OrganizationsUrl = organizationsUrl ?? throw new global::System.ArgumentNullException(nameof(organizationsUrl));
            this.ReceivedEventsUrl = receivedEventsUrl ?? throw new global::System.ArgumentNullException(nameof(receivedEventsUrl));
            this.ReposUrl = reposUrl ?? throw new global::System.ArgumentNullException(nameof(reposUrl));
            this.SiteAdmin = siteAdmin;
            this.StarredUrl = starredUrl ?? throw new global::System.ArgumentNullException(nameof(starredUrl));
            this.SubscriptionsUrl = subscriptionsUrl ?? throw new global::System.ArgumentNullException(nameof(subscriptionsUrl));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestHeadRepoOwner" /> class.
        /// </summary>
        public PullRequestHeadRepoOwner()
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
        public static global::G.PullRequestHeadRepoOwner? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PullRequestHeadRepoOwner>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.PullRequestHeadRepoOwner?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PullRequestHeadRepoOwner?>(serializer.Deserialize<global::G.PullRequestHeadRepoOwner>(jsonReader));
        }

    }
}