//HintName: G.Models.GraphCell.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphCell.
    /// </summary>
    public sealed partial class GraphCell
    {
        /// <summary>
        /// GraphCellLabel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GraphCellLabelJsonConverter))]
        public global::G.GraphCellLabel Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cell_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int CellId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orig", Required = global::Newtonsoft.Json.Required.Always)]
        public string Orig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prov")]
        public global::G.ProvenanceItem? Prov { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_ref")]
        public global::G.RefItem? ItemRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphCell" /> class.
        /// </summary>
        /// <param name="label">
        /// GraphCellLabel.
        /// </param>
        /// <param name="cellId"></param>
        /// <param name="text"></param>
        /// <param name="orig"></param>
        /// <param name="prov"></param>
        /// <param name="itemRef"></param>
        public GraphCell(
            global::G.GraphCellLabel label,
            int cellId,
            string text,
            string orig,
            global::G.ProvenanceItem? prov,
            global::G.RefItem? itemRef)
        {
            this.Label = label;
            this.CellId = cellId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Orig = orig ?? throw new global::System.ArgumentNullException(nameof(orig));
            this.Prov = prov;
            this.ItemRef = itemRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphCell" /> class.
        /// </summary>
        public GraphCell()
        {
        }
    }
}