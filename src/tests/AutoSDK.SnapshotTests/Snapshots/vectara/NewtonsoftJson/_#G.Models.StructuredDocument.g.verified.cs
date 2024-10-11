//HintName: G.Models.StructuredDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document with layout features.
    /// </summary>
    public sealed partial class StructuredDocument
    {
        /// <summary>
        /// The document ID, must be unique within the corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// When the type of the indexed document is `structured` the rest of<br/>
        /// the object is expected to follow this schema. It allows you to create a document<br/>
        /// that follows normal document conventions. The Vectara platform will then<br/>
        /// create document parts using its internal algorithm.<br/>
        /// Default Value: structured
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The title of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The description of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The metadata for a document as an arbitrary JSON object. Properties of this object<br/>
        /// can be used by document level filter attributes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.StructuredDocumentMetadata? Metadata { get; set; }

        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// The subsection of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StructuredDocumentSection> Sections { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}