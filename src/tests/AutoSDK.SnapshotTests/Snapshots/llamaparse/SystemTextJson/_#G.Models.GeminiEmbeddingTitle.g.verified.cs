//HintName: G.Models.GeminiEmbeddingTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Title is only applicable for retrieval_document tasks, and is used to represent a document title. For other tasks, title is invalid.
    /// </summary>
    public sealed partial class GeminiEmbeddingTitle
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}