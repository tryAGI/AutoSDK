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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// When the type of the indexed document is `core` the rest of<br/>
        /// the object is expected to follow this schema. This schema allows<br/>
        /// precise specification of document chunks that get directly translated<br/>
        /// to retrieval search results.<br/>
        /// Default Value: core
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Arbitrary object of document level metadata. Properties of this object<br/>
        /// can be used by document filter if defined as a corpus filter attribute.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Parts of the document that make up the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_parts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CoreDocumentPart> DocumentParts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}