//HintName: G.Models.VertexServiceAccountAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Google Cloud Vertex AI service account authentication
    /// </summary>
    public sealed partial class VertexServiceAccountAuth
    {
        /// <summary>
        /// Must be "vertex_service_account" for service account auth<br/>
        /// Default Value: vertex_service_account<br/>
        /// Example: vertex_service_account
        /// </summary>
        /// <default>"vertex_service_account"</default>
        /// <example>vertex_service_account</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "vertex_service_account";

        /// <summary>
        /// The service account key JSON<br/>
        /// Example: {"type":"service_account","project_id":"my-project",...}
        /// </summary>
        /// <example>{"type":"service_account","project_id":"my-project",...}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyJson { get; set; }

        /// <summary>
        /// GCP project ID<br/>
        /// Example: my-project-id
        /// </summary>
        /// <example>my-project-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// GCP region for Vertex AI<br/>
        /// Example: us-central1
        /// </summary>
        /// <example>us-central1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexServiceAccountAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "vertex_service_account" for service account auth<br/>
        /// Default Value: vertex_service_account<br/>
        /// Example: vertex_service_account
        /// </param>
        /// <param name="keyJson">
        /// The service account key JSON<br/>
        /// Example: {"type":"service_account","project_id":"my-project",...}
        /// </param>
        /// <param name="project">
        /// GCP project ID<br/>
        /// Example: my-project-id
        /// </param>
        /// <param name="region">
        /// GCP region for Vertex AI<br/>
        /// Example: us-central1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VertexServiceAccountAuth(
            string type,
            string keyJson,
            string project,
            string region)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.KeyJson = keyJson ?? throw new global::System.ArgumentNullException(nameof(keyJson));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexServiceAccountAuth" /> class.
        /// </summary>
        public VertexServiceAccountAuth()
        {
        }
    }
}