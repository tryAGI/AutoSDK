//HintName: G.Models.LlmConnectionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Adapter-specific configuration. Required for Bedrock (`{"region":"us-east-1"}`), optional for VertexAI (`{"location":"us-central1"}`), not used by other adapters.
    /// </summary>
    public sealed partial class LlmConnectionConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}