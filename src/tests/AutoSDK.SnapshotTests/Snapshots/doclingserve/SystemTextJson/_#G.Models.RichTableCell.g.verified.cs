//HintName: G.Models.RichTableCell.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RichTableCell.
    /// </summary>
    public sealed partial class RichTableCell
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        public global::G.BoundingBox? Bbox { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_span")]
        public int? RowSpan { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("col_span")]
        public int? ColSpan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_row_offset_idx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartRowOffsetIdx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_row_offset_idx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndRowOffsetIdx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_col_offset_idx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartColOffsetIdx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_col_offset_idx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndColOffsetIdx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_header")]
        public bool? ColumnHeader { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_header")]
        public bool? RowHeader { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_section")]
        public bool? RowSection { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fillable")]
        public bool? Fillable { get; set; }

        /// <summary>
        /// RefItem.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RefItem Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTableCell" /> class.
        /// </summary>
        /// <param name="startRowOffsetIdx"></param>
        /// <param name="endRowOffsetIdx"></param>
        /// <param name="startColOffsetIdx"></param>
        /// <param name="endColOffsetIdx"></param>
        /// <param name="text"></param>
        /// <param name="ref">
        /// RefItem.
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTableCell(
            int startRowOffsetIdx,
            int endRowOffsetIdx,
            int startColOffsetIdx,
            int endColOffsetIdx,
            string text,
            global::G.RefItem @ref,
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
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTableCell" /> class.
        /// </summary>
        public RichTableCell()
        {
        }
    }
}