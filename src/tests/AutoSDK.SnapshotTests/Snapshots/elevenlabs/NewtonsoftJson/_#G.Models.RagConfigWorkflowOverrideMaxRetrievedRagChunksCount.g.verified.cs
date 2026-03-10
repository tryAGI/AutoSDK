//HintName: G.Models.RagConfigWorkflowOverrideMaxRetrievedRagChunksCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Maximum number of RAG document chunks to initially retrieve from the vector store. These are then further filtered by vector distance and total length.
    /// </summary>
    public sealed partial class RagConfigWorkflowOverrideMaxRetrievedRagChunksCount
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}