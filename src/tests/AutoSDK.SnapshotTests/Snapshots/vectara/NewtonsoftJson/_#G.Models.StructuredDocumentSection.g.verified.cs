//HintName: G.Models.StructuredDocumentSection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A logical section within a structured document.<br/>
    /// Example: {"id":1,"title":"Billing Summary","text":"This section summarizes the billing details for Acme Corp for Q1 2025.","metadata":{"section_type":"summary","priority":"high"},"images":[{"id":"image_1","title":"Quarterly Sales Performance","caption":"Sales growth trends for Q1 to Q4 of 2024","description":"A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%","image_data":{"data":"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAADElEQVR4nGP4//8/AAX\u002BAv4N70a4AAAAAElFTkSuQmCC","mime_type":"image/png"}}],"tables":[{"id":"billing_table_1","title":"Invoice Line Items","data":{"headers":[[{"text_value":"Item"},{"text_value":"Quantity"},{"text_value":"Unit Price"},{"text_value":"Total"}]],"rows":[[{"text_value":"Widget A"},{"int_value":5},{"float_value":100.15},{"float_value":500.75}],[{"text_value":"Widget B"},{"int_value":3},{"float_value":250},{"float_value":750}]]},"description":"Details of items billed in the invoice."},{"id":2,"title":"Payment Terms","text":"Payment is due within 30 days from the invoice date.","metadata":{"section_type":"terms"}}]}
    /// </summary>
    public sealed partial class StructuredDocumentSection
    {
        /// <summary>
        /// The section ID. This gets converted to a metadata field automatically.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The section title.<br/>
        /// Example: Billing Summary
        /// </summary>
        /// <example>Billing Summary</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The text of the section.<br/>
        /// Example: This section summarizes the billing details for Acme Corp for Q1 2025.
        /// </summary>
        /// <example>This section summarizes the billing details for Acme Corp for Q1 2025.</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Arbitrary object that becomes document part level metadata on any document part created by this section. Properties of this object can be used by document part level filters if defined as a corpus filter attribute.<br/>
        /// Example: {"section_type":"summary","priority":"high"}
        /// </summary>
        /// <example>{"section_type":"summary","priority":"high"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The tables that this section contains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tables")]
        public global::System.Collections.Generic.IList<global::G.Table>? Tables { get; set; }

        /// <summary>
        /// The images that this section contains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<global::G.Image>? Images { get; set; }

        /// <summary>
        /// The sections that this section contains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sections")]
        public global::System.Collections.Generic.IList<global::G.StructuredDocumentSection>? Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDocumentSection" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the section.<br/>
        /// Example: This section summarizes the billing details for Acme Corp for Q1 2025.
        /// </param>
        /// <param name="id">
        /// The section ID. This gets converted to a metadata field automatically.<br/>
        /// Example: 10
        /// </param>
        /// <param name="title">
        /// The section title.<br/>
        /// Example: Billing Summary
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object that becomes document part level metadata on any document part created by this section. Properties of this object can be used by document part level filters if defined as a corpus filter attribute.<br/>
        /// Example: {"section_type":"summary","priority":"high"}
        /// </param>
        /// <param name="tables">
        /// The tables that this section contains.
        /// </param>
        /// <param name="images">
        /// The images that this section contains.
        /// </param>
        /// <param name="sections">
        /// The sections that this section contains.
        /// </param>
        public StructuredDocumentSection(
            string text,
            int? id,
            string? title,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.Table>? tables,
            global::System.Collections.Generic.IList<global::G.Image>? images,
            global::System.Collections.Generic.IList<global::G.StructuredDocumentSection>? sections)
        {
            this.Id = id;
            this.Title = title;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Metadata = metadata;
            this.Tables = tables;
            this.Images = images;
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