//HintName: G.Models.VertexAIConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VertexAIConfiguration
    {
        /// <summary>
        /// Vertex AI authentication type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VertexAIConfigurationVertexAuthType VertexAuthType { get; set; }

        /// <summary>
        /// GCP region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VertexRegion { get; set; }

        /// <summary>
        /// GCP project ID (required for basic auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_project_id")]
        public string? VertexProjectId { get; set; }

        /// <summary>
        /// Service account JSON (required for serviceAccount auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_service_account_json")]
        public object? VertexServiceAccountJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAIConfiguration" /> class.
        /// </summary>
        /// <param name="vertexAuthType">
        /// Vertex AI authentication type
        /// </param>
        /// <param name="vertexRegion">
        /// GCP region
        /// </param>
        /// <param name="vertexProjectId">
        /// GCP project ID (required for basic auth)
        /// </param>
        /// <param name="vertexServiceAccountJson">
        /// Service account JSON (required for serviceAccount auth)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VertexAIConfiguration(
            global::G.VertexAIConfigurationVertexAuthType vertexAuthType,
            string vertexRegion,
            string? vertexProjectId,
            object? vertexServiceAccountJson)
        {
            this.VertexAuthType = vertexAuthType;
            this.VertexRegion = vertexRegion ?? throw new global::System.ArgumentNullException(nameof(vertexRegion));
            this.VertexProjectId = vertexProjectId;
            this.VertexServiceAccountJson = vertexServiceAccountJson;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAIConfiguration" /> class.
        /// </summary>
        public VertexAIConfiguration()
        {
        }
    }
}