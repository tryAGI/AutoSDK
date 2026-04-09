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
        [global::Newtonsoft.Json.JsonProperty("page_no", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageNo { get; set; } = default!;

        /// <summary>
        /// Bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bbox", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BoundingBox Bbox { get; set; } = default!;

        /// <summary>
        /// Character span (0-indexed)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charspan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Charspan { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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