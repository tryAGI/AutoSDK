//HintName: G.Models.WebhookPullRequestLockedPullRequestRequestedTeam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class WebhookPullRequestLockedPullRequestRequestedTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Description of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        /// Name of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public global::G.WebhookPullRequestLockedPullRequestRequestedTeamParent? Parent { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public string? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public global::G.WebhookPullRequestLockedPullRequestRequestedTeamPrivacy? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url")]
        public string? RepositoriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// URL for the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestRequestedTeam" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="description">
        /// Description of the team
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the team
        /// </param>
        /// <param name="membersUrl"></param>
        /// <param name="name">
        /// Name of the team
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="parent"></param>
        /// <param name="permission">
        /// Permission that the team will have for its repositories
        /// </param>
        /// <param name="privacy"></param>
        /// <param name="repositoriesUrl"></param>
        /// <param name="slug"></param>
        /// <param name="url">
        /// URL for the team
        /// </param>
        public WebhookPullRequestLockedPullRequestRequestedTeam(
            int id,
            string name,
            bool? deleted,
            string? description,
            string? htmlUrl,
            string? membersUrl,
            string? nodeId,
            global::G.WebhookPullRequestLockedPullRequestRequestedTeamParent? parent,
            string? permission,
            global::G.WebhookPullRequestLockedPullRequestRequestedTeamPrivacy? privacy,
            string? repositoriesUrl,
            string? slug,
            string? url)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Deleted = deleted;
            this.Description = description;
            this.HtmlUrl = htmlUrl;
            this.MembersUrl = membersUrl;
            this.NodeId = nodeId;
            this.Parent = parent;
            this.Permission = permission;
            this.Privacy = privacy;
            this.RepositoriesUrl = repositoriesUrl;
            this.Slug = slug;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestRequestedTeam" /> class.
        /// </summary>
        public WebhookPullRequestLockedPullRequestRequestedTeam()
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
        public static global::G.WebhookPullRequestLockedPullRequestRequestedTeam? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPullRequestLockedPullRequestRequestedTeam>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestLockedPullRequestRequestedTeam?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestLockedPullRequestRequestedTeam?>(serializer.Deserialize<global::G.WebhookPullRequestLockedPullRequestRequestedTeam>(jsonReader));
        }

    }
}