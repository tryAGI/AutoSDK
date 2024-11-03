//HintName: G.Models.MigrationsStartForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsStartForOrgRequest
    {
        /// <summary>
        /// A list of arrays indicating which repositories should be migrated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Repositories { get; set; } = default!;

        /// <summary>
        /// Indicates whether repositories should be locked (to prevent manipulation) while migrating data.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_repositories")]
        public bool? LockRepositories { get; set; }

        /// <summary>
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_metadata")]
        public bool? ExcludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_git_data")]
        public bool? ExcludeGitData { get; set; }

        /// <summary>
        /// Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_attachments")]
        public bool? ExcludeAttachments { get; set; }

        /// <summary>
        /// Indicates whether releases should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_releases")]
        public bool? ExcludeReleases { get; set; }

        /// <summary>
        /// Indicates whether projects owned by the organization or users should be excluded. from the migration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_owner_projects")]
        public bool? ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_metadata_only")]
        public bool? OrgMetadataOnly { get; set; }

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.MigrationsStartForOrgRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MigrationsStartForOrgRequest>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.MigrationsStartForOrgRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.MigrationsStartForOrgRequest?>(serializer.Deserialize<global::G.MigrationsStartForOrgRequest>(jsonReader));
        }

    }
}