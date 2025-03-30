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
        /// The document ID must be unique within the corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the type of the indexed document is `structured` the rest of<br/>
        /// the object is expected to follow this schema. It allows you to create a document<br/>
        /// that follows normal document conventions. The Vectara platform will then<br/>
        /// create document parts using its internal algorithm.<br/>
        /// Default Value: structured
        /// </summary>
        /// <default>"structured"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "structured";

        /// <summary>
        /// The title of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The description of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The metadata for a document as an arbitrary JSON object. Properties of this object<br/>
        /// can be used by document level filter attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// The subsection of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StructuredDocumentSection> Sections { get; set; }

        /// <summary>
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChunkingStrategyJsonConverter))]
        public global::G.ChunkingStrategy? ChunkingStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDocument" /> class.
        /// </summary>
        /// <param name="id">
        /// The document ID must be unique within the corpus.
        /// </param>
        /// <param name="type">
        /// When the type of the indexed document is `structured` the rest of<br/>
        /// the object is expected to follow this schema. It allows you to create a document<br/>
        /// that follows normal document conventions. The Vectara platform will then<br/>
        /// create document parts using its internal algorithm.<br/>
        /// Default Value: structured
        /// </param>
        /// <param name="title">
        /// The title of the document.
        /// </param>
        /// <param name="description">
        /// The description of the document.
        /// </param>
        /// <param name="metadata">
        /// The metadata for a document as an arbitrary JSON object. Properties of this object<br/>
        /// can be used by document level filter attributes.
        /// </param>
        /// <param name="customDimensions">
        /// The custom dimensions as additional weights.
        /// </param>
        /// <param name="sections">
        /// The subsection of the document.
        /// </param>
        /// <param name="chunkingStrategy">
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredDocument(
            string id,
            string type,
            global::System.Collections.Generic.IList<global::G.StructuredDocumentSection> sections,
            string? title,
            string? description,
            object? metadata,
            global::System.Collections.Generic.Dictionary<string, double>? customDimensions,
            global::G.ChunkingStrategy? chunkingStrategy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Sections = sections ?? throw new global::System.ArgumentNullException(nameof(sections));
            this.Title = title;
            this.Description = description;
            this.Metadata = metadata;
            this.CustomDimensions = customDimensions;
            this.ChunkingStrategy = chunkingStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDocument" /> class.
        /// </summary>
        public StructuredDocument()
        {
        }
    }
}