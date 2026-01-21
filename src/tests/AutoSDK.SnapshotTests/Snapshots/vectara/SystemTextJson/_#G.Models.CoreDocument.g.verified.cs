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
        /// The document ID must be unique within the corpus.<br/>
        /// Example: my-doc-id
        /// </summary>
        /// <example>my-doc-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the type of the indexed document is `core` the rest of<br/>
        /// the object is expected to follow this schema. This schema allows<br/>
        /// precise specification of document chunks that get directly translated<br/>
        /// to retrieve search results.<br/>
        /// Default Value: core
        /// </summary>
        /// <default>"core"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "core";

        /// <summary>
        /// Arbitrary object of document level metadata. Properties of this object<br/>
        /// can be used by document filters if defined as a corpus filter attribute.<br/>
        /// Example: {"title":"A Nice Document","lang":"eng"}
        /// </summary>
        /// <example>{"title":"A Nice Document","lang":"eng"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The tables that this document contains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::G.Table>? Tables { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDocument" /> class.
        /// </summary>
        /// <param name="id">
        /// The document ID must be unique within the corpus.<br/>
        /// Example: my-doc-id
        /// </param>
        /// <param name="type">
        /// When the type of the indexed document is `core` the rest of<br/>
        /// the object is expected to follow this schema. This schema allows<br/>
        /// precise specification of document chunks that get directly translated<br/>
        /// to retrieve search results.<br/>
        /// Default Value: core
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object of document level metadata. Properties of this object<br/>
        /// can be used by document filters if defined as a corpus filter attribute.<br/>
        /// Example: {"title":"A Nice Document","lang":"eng"}
        /// </param>
        /// <param name="tables">
        /// The tables that this document contains.
        /// </param>
        /// <param name="documentParts">
        /// Parts of the document that make up the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoreDocument(
            string id,
            string type,
            global::System.Collections.Generic.IList<global::G.CoreDocumentPart> documentParts,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.Table>? tables)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DocumentParts = documentParts ?? throw new global::System.ArgumentNullException(nameof(documentParts));
            this.Metadata = metadata;
            this.Tables = tables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDocument" /> class.
        /// </summary>
        public CoreDocument()
        {
        }
    }
}