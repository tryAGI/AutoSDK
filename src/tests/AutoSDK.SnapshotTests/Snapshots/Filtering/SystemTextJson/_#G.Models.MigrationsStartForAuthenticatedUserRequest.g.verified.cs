//HintName: G.Models.MigrationsStartForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsStartForAuthenticatedUserRequest
    {
        /// <summary>
        /// Lock the repositories being migrated at the start of the migration<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_repositories")]
        public bool? LockRepositories { get; set; }

        /// <summary>
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_metadata")]
        public bool? ExcludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_git_data")]
        public bool? ExcludeGitData { get; set; }

        /// <summary>
        /// Do not include attachments in the migration<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_attachments")]
        public bool? ExcludeAttachments { get; set; }

        /// <summary>
        /// Do not include releases in the migration<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_releases")]
        public bool? ExcludeReleases { get; set; }

        /// <summary>
        /// Indicates whether projects owned by the organization or users should be excluded.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_owner_projects")]
        public bool? ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_metadata_only")]
        public bool? OrgMetadataOnly { get; set; } = false;

        /// <summary>
        /// Exclude attributes from the API response to improve performance<br/>
        /// Example: [repositories]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<global::G.MigrationsStartForAuthenticatedUserRequestExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.MigrationsStartForAuthenticatedUserRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.MigrationsStartForAuthenticatedUserRequest),
                jsonSerializerContext) as global::G.MigrationsStartForAuthenticatedUserRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MigrationsStartForAuthenticatedUserRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.MigrationsStartForAuthenticatedUserRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}