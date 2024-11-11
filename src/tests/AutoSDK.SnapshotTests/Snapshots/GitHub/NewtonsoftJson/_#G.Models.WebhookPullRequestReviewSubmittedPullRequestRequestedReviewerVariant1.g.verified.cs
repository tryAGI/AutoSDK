//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers_url")]
        public string? FollowersUrl { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations_url")]
        public string? OrganizationsUrl { get; set; }

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
        public global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="deleted"></param>
        /// <param name="email"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="followersUrl"></param>
        /// <param name="followingUrl"></param>
        /// <param name="gistsUrl"></param>
        /// <param name="gravatarId"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="organizationsUrl"></param>
        /// <param name="receivedEventsUrl"></param>
        /// <param name="reposUrl"></param>
        /// <param name="siteAdmin"></param>
        /// <param name="starredUrl"></param>
        /// <param name="subscriptionsUrl"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        public WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1(
            int id,
            string login,
            string? avatarUrl,
            bool? deleted,
            string? email,
            string? eventsUrl,
            string? followersUrl,
            string? followingUrl,
            string? gistsUrl,
            string? gravatarId,
            string? htmlUrl,
            string? name,
            string? nodeId,
            string? organizationsUrl,
            string? receivedEventsUrl,
            string? reposUrl,
            bool? siteAdmin,
            string? starredUrl,
            string? subscriptionsUrl,
            global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type? type,
            string? url)
        {
            this.Id = id;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.AvatarUrl = avatarUrl;
            this.Deleted = deleted;
            this.Email = email;
            this.EventsUrl = eventsUrl;
            this.FollowersUrl = followersUrl;
            this.FollowingUrl = followingUrl;
            this.GistsUrl = gistsUrl;
            this.GravatarId = gravatarId;
            this.HtmlUrl = htmlUrl;
            this.Name = name;
            this.NodeId = nodeId;
            this.OrganizationsUrl = organizationsUrl;
            this.ReceivedEventsUrl = receivedEventsUrl;
            this.ReposUrl = reposUrl;
            this.SiteAdmin = siteAdmin;
            this.StarredUrl = starredUrl;
            this.SubscriptionsUrl = subscriptionsUrl;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1" /> class.
        /// </summary>
        public WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1()
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
        public static global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1?>(serializer.Deserialize<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1>(jsonReader));
        }

    }
}