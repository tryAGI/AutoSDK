//HintName: G.Models.GridChartExportVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GridChartExportVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnLabels")]
        public global::System.Collections.Generic.IList<string>? ColumnLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowLabels")]
        public global::System.Collections.Generic.IList<string>? RowLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCount")]
        public float? MaxCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colorByTotal")]
        public bool? ColorByTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridChartExportVO" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="columnLabels"></param>
        /// <param name="rowLabels"></param>
        /// <param name="rows"></param>
        /// <param name="maxCount"></param>
        /// <param name="colorByTotal"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GridChartExportVO(
            string? title,
            global::System.Collections.Generic.IList<string>? columnLabels,
            global::System.Collections.Generic.IList<string>? rowLabels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? rows,
            float? maxCount,
            bool? colorByTotal)
        {
            this.Title = title;
            this.ColumnLabels = columnLabels;
            this.RowLabels = rowLabels;
            this.Rows = rows;
            this.MaxCount = maxCount;
            this.ColorByTotal = colorByTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridChartExportVO" /> class.
        /// </summary>
        public GridChartExportVO()
        {
        }
    }
}