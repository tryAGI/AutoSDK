//HintName: G.Models.TableCell.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TableCell.
    /// </summary>
    public sealed partial class TableCell
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bbox")]
        public global::G.BoundingBox? Bbox { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row_span")]
        public int? RowSpan { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("col_span")]
        public int? ColSpan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_row_offset_idx", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartRowOffsetIdx { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_row_offset_idx", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndRowOffsetIdx { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_col_offset_idx", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartColOffsetIdx { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_col_offset_idx", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndColOffsetIdx { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_header")]
        public bool? ColumnHeader { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row_header")]
        public bool? RowHeader { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row_section")]
        public bool? RowSection { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fillable")]
        public bool? Fillable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCell" /> class.
        /// </summary>
        /// <param name="startRowOffsetIdx"></param>
        /// <param name="endRowOffsetIdx"></param>
        /// <param name="startColOffsetIdx"></param>
        /// <param name="endColOffsetIdx"></param>
        /// <param name="text"></param>
        /// <param name="bbox"></param>
        /// <param name="rowSpan">
        /// Default Value: 1
        /// </param>
        /// <param name="colSpan">
        /// Default Value: 1
        /// </param>
        /// <param name="columnHeader">
        /// Default Value: false
        /// </param>
        /// <param name="rowHeader">
        /// Default Value: false
        /// </param>
        /// <param name="rowSection">
        /// Default Value: false
        /// </param>
        /// <param name="fillable">
        /// Default Value: false
        /// </param>
        public TableCell(
            int startRowOffsetIdx,
            int endRowOffsetIdx,
            int startColOffsetIdx,
            int endColOffsetIdx,
            string text,
            global::G.BoundingBox? bbox,
            int? rowSpan,
            int? colSpan,
            bool? columnHeader,
            bool? rowHeader,
            bool? rowSection,
            bool? fillable)
        {
            this.Bbox = bbox;
            this.RowSpan = rowSpan;
            this.ColSpan = colSpan;
            this.StartRowOffsetIdx = startRowOffsetIdx;
            this.EndRowOffsetIdx = endRowOffsetIdx;
            this.StartColOffsetIdx = startColOffsetIdx;
            this.EndColOffsetIdx = endColOffsetIdx;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ColumnHeader = columnHeader;
            this.RowHeader = rowHeader;
            this.RowSection = rowSection;
            this.Fillable = fillable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCell" /> class.
        /// </summary>
        public TableCell()
        {
        }
    }
}