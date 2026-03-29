//HintName: G.Models.UpsertLlmConnectionRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Adapter-specific configuration. Validation rules: - **Bedrock**: Required. Must be `{"region": "&lt;aws-region&gt;"}` (e.g., `{"region":"us-east-1"}`) - **VertexAI**: Optional. If provided, must be `{"location": "&lt;gcp-location&gt;"}` (e.g., `{"location":"us-central1"}`) - **Other adapters**: Not supported. Omit this field or set to null.
    /// </summary>
    public sealed partial class UpsertLlmConnectionRequestConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}