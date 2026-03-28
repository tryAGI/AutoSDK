//HintName: G.Models.CoreDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The document structure that most closely corresponds to Vectara's internal document data model.<br/>
    /// Example: {"id":"invoice-001","type":"core","metadata":{"doc_type":"invoice","industry":"manufacturing"},"tables":[{"id":"billing_table_1","title":"Customer Billing Info","description":"Monthly billing for top manufacturing clients","data":{"headers":[[{"text_value":"Customer Name"},{"text_value":"Balance"},{"text_value":"Account Created"}]],"rows":[[{"text_value":"Acme Corp"},{"float_value":10230.25},{"text_value":"2023-01-15"}],[{"text_value":"Beta Industries"},{"float_value":8750},{"text_value":"2022-11-03"}],[{"text_value":"Zeta Manufacturing"},{"float_value":13499.99},{"text_value":"2023-06-30"}]]}}],"images":[{"id":"image_1","title":"Quarterly Sales Performance","caption":"Sales growth trends for Q1 to Q4 of 2024","description":"A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%","image_data":{"data":"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAADElEQVR4nGP4//8/AAX\u002BAv4N70a4AAAAAElFTkSuQmCC","mime_type":"image/jpeg"}}],"document_parts":[{"text":"This invoice includes customer billing history for Q1.","metadata":{"quarter":1,"year":2023}}],"storage_usage":{"bytes_used":1024,"metadata_bytes_used":256},"extraction_usage":{"table_extraction_used":1}}
    /// </summary>
    public sealed partial class CoreDocument
    {
        /// <summary>
        /// The document ID must be unique within the corpus.<br/>
        /// Example: Invoice-403
        /// </summary>
        /// <example>Invoice-403</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the type of the indexed document is `core` the rest of the object is expected to follow this schema. This schema allows precise specification of document chunks that get directly translated to retrieve search results.<br/>
        /// Default Value: core
        /// </summary>
        /// <default>"core"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "core";

        /// <summary>
        /// Arbitrary object of document level metadata. Properties of this object can be used by document filters if defined as a corpus filter attribute.<br/>
        /// Example: {"title":"Customer Billing Information","lang":"eng"}
        /// </summary>
        /// <example>{"title":"Customer Billing Information","lang":"eng"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The tables that this document contains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::G.Table>? Tables { get; set; }

        /// <summary>
        /// The images that this document contains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::G.Image>? Images { get; set; }

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
        /// Example: Invoice-403
        /// </param>
        /// <param name="type">
        /// When the type of the indexed document is `core` the rest of the object is expected to follow this schema. This schema allows precise specification of document chunks that get directly translated to retrieve search results.<br/>
        /// Default Value: core
        /// </param>
        /// <param name="documentParts">
        /// Parts of the document that make up the document.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object of document level metadata. Properties of this object can be used by document filters if defined as a corpus filter attribute.<br/>
        /// Example: {"title":"Customer Billing Information","lang":"eng"}
        /// </param>
        /// <param name="tables">
        /// The tables that this document contains.
        /// </param>
        /// <param name="images">
        /// The images that this document contains.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoreDocument(
            string id,
            string type,
            global::System.Collections.Generic.IList<global::G.CoreDocumentPart> documentParts,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.Table>? tables,
            global::System.Collections.Generic.IList<global::G.Image>? images)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Metadata = metadata;
            this.Tables = tables;
            this.Images = images;
            this.DocumentParts = documentParts ?? throw new global::System.ArgumentNullException(nameof(documentParts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDocument" /> class.
        /// </summary>
        public CoreDocument()
        {
        }
    }
}