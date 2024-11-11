//HintName: G.Models.StructuredDocumentSection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A logical section within a structured document.
    /// </summary>
    public sealed partial class StructuredDocumentSection
    {
        /// <summary>
        /// The section ID. This gets converted to a metadata field automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The section title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The text of the section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Arbitrary object that becomes document part level metadata on any document part created <br/>
        /// by this section. Properties of this object can be used by document part level <br/>
        /// filters if defined as a corpus filter attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The sections that this section contains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        public global::System.Collections.Generic.IList<global::G.StructuredDocumentSection>? Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDocumentSection" /> class.
        /// </summary>
        /// <param name="id">
        /// The section ID. This gets converted to a metadata field automatically.
        /// </param>
        /// <param name="title">
        /// The section title.
        /// </param>
        /// <param name="text">
        /// The text of the section.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object that becomes document part level metadata on any document part created <br/>
        /// by this section. Properties of this object can be used by document part level <br/>
        /// filters if defined as a corpus filter attribute.
        /// </param>
        /// <param name="sections">
        /// The sections that this section contains.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StructuredDocumentSection(
            string text,
            int? id,
            string? title,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.StructuredDocumentSection>? sections)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Id = id;
            this.Title = title;
            this.Metadata = metadata;
            this.Sections = sections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDocumentSection" /> class.
        /// </summary>
        public StructuredDocumentSection()
        {
        }
    }
}