//HintName: G.Models.RerankResponseResultDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If `return_documents` is set as `false` this will return none, if `true` it will return the documents passed in
    /// </summary>
    public sealed partial class RerankResponseResultDocument
    {
        /// <summary>
        /// The text of the document to rerank
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}