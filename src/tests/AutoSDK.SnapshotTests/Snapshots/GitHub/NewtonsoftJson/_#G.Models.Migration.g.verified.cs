//HintName: G.Models.Migration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A migration.
    /// </summary>
    public sealed partial class Migration
    {
        /// <summary>
        /// Example: 79L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Owner { get; set; } = default!;

        /// <summary>
        /// Example: 0b989ba4-242f-11e5-81e1-c7b6966d2516
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Guid { get; set; } = default!;

        /// <summary>
        /// Example: pending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public bool LockRepositories { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeMetadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_git_data", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeGitData { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_attachments", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeAttachments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_releases", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeReleases { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_owner_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeOwnerProjects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_metadata_only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OrgMetadataOnly { get; set; } = default!;

        /// <summary>
        /// The repositories included in the migration. Only returned for export migrations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Repository> Repositories { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/octo-org/migrations/79
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archive_url")]
        public string? ArchiveUrl { get; set; }

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `"repositories"`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Migration" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 79L
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="guid">
        /// Example: 0b989ba4-242f-11e5-81e1-c7b6966d2516
        /// </param>
        /// <param name="state">
        /// Example: pending
        /// </param>
        /// <param name="lockRepositories">
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata"></param>
        /// <param name="excludeGitData"></param>
        /// <param name="excludeAttachments"></param>
        /// <param name="excludeReleases"></param>
        /// <param name="excludeOwnerProjects"></param>
        /// <param name="orgMetadataOnly"></param>
        /// <param name="repositories">
        /// The repositories included in the migration. Only returned for export migrations.
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/octo-org/migrations/79
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="nodeId"></param>
        /// <param name="archiveUrl"></param>
        /// <param name="exclude">
        /// Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `"repositories"`.
        /// </param>
        public Migration(
            long id,
            global::G.NullableSimpleUser? owner,
            string guid,
            string state,
            bool lockRepositories,
            bool excludeMetadata,
            bool excludeGitData,
            bool excludeAttachments,
            bool excludeReleases,
            bool excludeOwnerProjects,
            bool orgMetadataOnly,
            global::System.Collections.Generic.IList<global::G.Repository> repositories,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string nodeId,
            string? archiveUrl,
            global::System.Collections.Generic.IList<string>? exclude)
        {
            this.Id = id;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Guid = guid ?? throw new global::System.ArgumentNullException(nameof(guid));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.LockRepositories = lockRepositories;
            this.ExcludeMetadata = excludeMetadata;
            this.ExcludeGitData = excludeGitData;
            this.ExcludeAttachments = excludeAttachments;
            this.ExcludeReleases = excludeReleases;
            this.ExcludeOwnerProjects = excludeOwnerProjects;
            this.OrgMetadataOnly = orgMetadataOnly;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ArchiveUrl = archiveUrl;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Migration" /> class.
        /// </summary>
        public Migration()
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
        public static global::G.Migration? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Migration>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Migration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Migration?>(serializer.Deserialize<global::G.Migration>(jsonReader));
        }

    }
}