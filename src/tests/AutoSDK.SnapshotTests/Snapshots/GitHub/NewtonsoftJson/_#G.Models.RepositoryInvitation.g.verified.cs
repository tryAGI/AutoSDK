//HintName: G.Models.RepositoryInvitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository invitations let you manage who you collaborate with.
    /// </summary>
    public sealed partial class RepositoryInvitation
    {
        /// <summary>
        /// Unique identifier of the repository invitation.<br/>
        /// Example: 42L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Invitee { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inviter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Inviter { get; set; } = default!;

        /// <summary>
        /// The permission associated with the invitation.<br/>
        /// Example: read
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryInvitationPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Whether or not the invitation has expired
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// URL for the repository invitation<br/>
        /// Example: https://api.github.com/user/repository-invitations/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/invitations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryInvitation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the repository invitation.<br/>
        /// Example: 42L
        /// </param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="invitee">
        /// A GitHub user.
        /// </param>
        /// <param name="inviter">
        /// A GitHub user.
        /// </param>
        /// <param name="permissions">
        /// The permission associated with the invitation.<br/>
        /// Example: read
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="expired">
        /// Whether or not the invitation has expired
        /// </param>
        /// <param name="url">
        /// URL for the repository invitation<br/>
        /// Example: https://api.github.com/user/repository-invitations/1
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/invitations
        /// </param>
        /// <param name="nodeId"></param>
        public RepositoryInvitation(
            long id,
            global::G.MinimalRepository repository,
            global::G.NullableSimpleUser? invitee,
            global::G.NullableSimpleUser? inviter,
            global::G.RepositoryInvitationPermissions permissions,
            global::System.DateTime createdAt,
            string url,
            string htmlUrl,
            string nodeId,
            bool? expired)
        {
            this.Id = id;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Invitee = invitee ?? throw new global::System.ArgumentNullException(nameof(invitee));
            this.Inviter = inviter ?? throw new global::System.ArgumentNullException(nameof(inviter));
            this.Permissions = permissions;
            this.CreatedAt = createdAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryInvitation" /> class.
        /// </summary>
        public RepositoryInvitation()
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
        public static global::G.RepositoryInvitation? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryInvitation>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryInvitation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RepositoryInvitation?>(serializer.Deserialize<global::G.RepositoryInvitation>(jsonReader));
        }

    }
}