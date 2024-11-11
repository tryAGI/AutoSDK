//HintName: G.Models.Artifact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An artifact
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the artifact.<br/>
        /// Example: AdventureWorks.Framework
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The size in bytes of the artifact.<br/>
        /// Example: 12345
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_in_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int SizeInBytes { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5/zip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archive_download_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArchiveDownloadUrl { get; set; } = default!;

        /// <summary>
        /// Whether or not the artifact has expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Expired { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ExpiresAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_run")]
        public global::G.ArtifactWorkflowRun? WorkflowRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 5
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </param>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: AdventureWorks.Framework
        /// </param>
        /// <param name="sizeInBytes">
        /// The size in bytes of the artifact.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5
        /// </param>
        /// <param name="archiveDownloadUrl">
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5/zip
        /// </param>
        /// <param name="expired">
        /// Whether or not the artifact has expired.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="workflowRun"></param>
        public Artifact(
            int id,
            string nodeId,
            string name,
            int sizeInBytes,
            string url,
            string archiveDownloadUrl,
            bool expired,
            global::System.DateTime? createdAt,
            global::System.DateTime? expiresAt,
            global::System.DateTime? updatedAt,
            global::G.ArtifactWorkflowRun? workflowRun)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SizeInBytes = sizeInBytes;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ArchiveDownloadUrl = archiveDownloadUrl ?? throw new global::System.ArgumentNullException(nameof(archiveDownloadUrl));
            this.Expired = expired;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.UpdatedAt = updatedAt;
            this.WorkflowRun = workflowRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
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
        public static global::G.Artifact? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Artifact>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Artifact?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Artifact?>(serializer.Deserialize<global::G.Artifact>(jsonReader));
        }

    }
}