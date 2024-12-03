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
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        /// <example>MDEwOkNoZWNrU3VpdGU1</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the artifact.<br/>
        /// Example: AdventureWorks.Framework
        /// </summary>
        /// <example>AdventureWorks.Framework</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The size in bytes of the artifact.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::Newtonsoft.Json.JsonProperty("size_in_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int SizeInBytes { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/artifacts/5</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5/zip
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/artifacts/5/zip</example>
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
    }
}