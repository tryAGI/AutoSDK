//HintName: G.Models.BranchRestrictionPolicyAppOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestrictionPolicyAppOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url")]
        public string? ReposUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url")]
        public string? HooksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url")]
        public string? IssuesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_members_url")]
        public string? PublicMembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: ""
        /// </summary>
        /// <example>""</example>
        [global::Newtonsoft.Json.JsonProperty("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// Example: "https://github.com/testorg-ea8ec76d71c3af4b"
        /// </summary>
        /// <example>"https://github.com/testorg-ea8ec76d71c3af4b"</example>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/followers"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/followers"</example>
        [global::Newtonsoft.Json.JsonProperty("followers_url")]
        public string? FollowersUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/following{/other_user}"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/following{/other_user}"</example>
        [global::Newtonsoft.Json.JsonProperty("following_url")]
        public string? FollowingUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/gists{/gist_id}"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/gists{/gist_id}"</example>
        [global::Newtonsoft.Json.JsonProperty("gists_url")]
        public string? GistsUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/starred{/owner}{/repo}"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/starred{/owner}{/repo}"</example>
        [global::Newtonsoft.Json.JsonProperty("starred_url")]
        public string? StarredUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/subscriptions"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/subscriptions"</example>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_url")]
        public string? SubscriptionsUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/orgs"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/orgs"</example>
        [global::Newtonsoft.Json.JsonProperty("organizations_url")]
        public string? OrganizationsUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/received_events"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/received_events"</example>
        [global::Newtonsoft.Json.JsonProperty("received_events_url")]
        public string? ReceivedEventsUrl { get; set; }

        /// <summary>
        /// Example: "Organization"
        /// </summary>
        /// <example>"Organization"</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("site_admin")]
        public bool? SiteAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyAppOwner" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="reposUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="hooksUrl"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="membersUrl"></param>
        /// <param name="publicMembersUrl"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="description"></param>
        /// <param name="gravatarId">
        /// Example: ""
        /// </param>
        /// <param name="htmlUrl">
        /// Example: "https://github.com/testorg-ea8ec76d71c3af4b"
        /// </param>
        /// <param name="followersUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/followers"
        /// </param>
        /// <param name="followingUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/following{/other_user}"
        /// </param>
        /// <param name="gistsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/gists{/gist_id}"
        /// </param>
        /// <param name="starredUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/starred{/owner}{/repo}"
        /// </param>
        /// <param name="subscriptionsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/subscriptions"
        /// </param>
        /// <param name="organizationsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/orgs"
        /// </param>
        /// <param name="receivedEventsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/received_events"
        /// </param>
        /// <param name="type">
        /// Example: "Organization"
        /// </param>
        /// <param name="siteAdmin">
        /// Example: false
        /// </param>
        public BranchRestrictionPolicyAppOwner(
            string? login,
            int? id,
            string? nodeId,
            string? url,
            string? reposUrl,
            string? eventsUrl,
            string? hooksUrl,
            string? issuesUrl,
            string? membersUrl,
            string? publicMembersUrl,
            string? avatarUrl,
            string? description,
            string? gravatarId,
            string? htmlUrl,
            string? followersUrl,
            string? followingUrl,
            string? gistsUrl,
            string? starredUrl,
            string? subscriptionsUrl,
            string? organizationsUrl,
            string? receivedEventsUrl,
            string? type,
            bool? siteAdmin)
        {
            this.Login = login;
            this.Id = id;
            this.NodeId = nodeId;
            this.Url = url;
            this.ReposUrl = reposUrl;
            this.EventsUrl = eventsUrl;
            this.HooksUrl = hooksUrl;
            this.IssuesUrl = issuesUrl;
            this.MembersUrl = membersUrl;
            this.PublicMembersUrl = publicMembersUrl;
            this.AvatarUrl = avatarUrl;
            this.Description = description;
            this.GravatarId = gravatarId;
            this.HtmlUrl = htmlUrl;
            this.FollowersUrl = followersUrl;
            this.FollowingUrl = followingUrl;
            this.GistsUrl = gistsUrl;
            this.StarredUrl = starredUrl;
            this.SubscriptionsUrl = subscriptionsUrl;
            this.OrganizationsUrl = organizationsUrl;
            this.ReceivedEventsUrl = receivedEventsUrl;
            this.Type = type;
            this.SiteAdmin = siteAdmin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyAppOwner" /> class.
        /// </summary>
        public BranchRestrictionPolicyAppOwner()
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
        public static global::G.BranchRestrictionPolicyAppOwner? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BranchRestrictionPolicyAppOwner>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BranchRestrictionPolicyAppOwner?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BranchRestrictionPolicyAppOwner?>(serializer.Deserialize<global::G.BranchRestrictionPolicyAppOwner>(jsonReader));
        }

    }
}