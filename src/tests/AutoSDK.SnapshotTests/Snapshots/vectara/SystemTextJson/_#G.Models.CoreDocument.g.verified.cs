//HintName: G.Models.CoreDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The document structure that most closely corresponds to Vectara's internal document data model.
    /// </summary>
    public sealed partial class CoreDocument
    {
        /// <summary>
        /// The document ID, must be unique within the corpus.<br/>
        /// Example: my-doc-id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the type of the indexed document is `core` the rest of<br/>
        /// the object is expected to follow this schema. This schema allows<br/>
        /// precise specification of document chunks that get directly translated<br/>
        /// to retrieval search results.<br/>
        /// Default Value: core
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Arbitrary object of document level metadata. Properties of this object<br/>
        /// can be used by document filter if defined as a corpus filter attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.CoreDocumentMetadata? Metadata { get; set; }

        /// <summary>
        /// Parts of the document that make up the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CoreDocumentPart> DocumentParts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}