//HintName: G.Models.ProvenanceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provenance information for elements extracted from a textual document.<br/>
    /// A `ProvenanceItem` object acts as a lightweight pointer back into the original<br/>
    /// document for an extracted element. It applies to documents with an explicity<br/>
    /// or implicit layout, such as PDF, HTML, docx, or pptx.
    /// </summary>
    public sealed partial class ProvenanceItem
    {
        /// <summary>
        /// Page number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_no")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNo { get; set; }

        /// <summary>
        /// Bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BoundingBox Bbox { get; set; }

        /// <summary>
        /// Character span (0-indexed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charspan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Charspan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceItem" /> class.
        /// </summary>
        /// <param name="pageNo">
        /// Page number
        /// </param>
        /// <param name="bbox">
        /// Bounding box
        /// </param>
        /// <param name="charspan">
        /// Character span (0-indexed)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvenanceItem(
            int pageNo,
            global::G.BoundingBox bbox,
            global::System.Collections.Generic.IList<int> charspan)
        {
            this.PageNo = pageNo;
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Charspan = charspan ?? throw new global::System.ArgumentNullException(nameof(charspan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceItem" /> class.
        /// </summary>
        public ProvenanceItem()
        {
        }
    }
}