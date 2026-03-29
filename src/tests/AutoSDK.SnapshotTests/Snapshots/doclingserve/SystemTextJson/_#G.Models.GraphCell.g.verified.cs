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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphCellLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraphCellLabel Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CellId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Orig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prov")]
        public global::G.ProvenanceItem? Prov { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_ref")]
        public global::G.RefItem? ItemRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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