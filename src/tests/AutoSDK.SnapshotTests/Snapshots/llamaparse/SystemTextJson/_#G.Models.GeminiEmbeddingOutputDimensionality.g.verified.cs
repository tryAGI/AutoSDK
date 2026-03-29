//HintName: G.Models.GeminiEmbeddingOutputDimensionality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional reduced dimension for output embeddings. Supported by models/text-embedding-004 and newer (e.g. gemini-embedding-001). Not supported by models/embedding-001.
    /// </summary>
    public sealed partial class GeminiEmbeddingOutputDimensionality
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}