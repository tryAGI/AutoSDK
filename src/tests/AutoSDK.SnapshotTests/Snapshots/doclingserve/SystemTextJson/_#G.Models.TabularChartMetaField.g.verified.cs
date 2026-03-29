//HintName: G.Models.TabularChartMetaField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tabular chart metadata field.
    /// </summary>
    public sealed partial class TabularChartMetaField
    {
        /// <summary>
        /// The confidence of the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The origin of the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// BaseTableData.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TableData ChartData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TabularChartMetaField" /> class.
        /// </summary>
        /// <param name="chartData">
        /// BaseTableData.
        /// </param>
        /// <param name="confidence">
        /// The confidence of the prediction.
        /// </param>
        /// <param name="createdBy">
        /// The origin of the prediction.
        /// </param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TabularChartMetaField(
            global::G.TableData chartData,
            double? confidence,
            string? createdBy,
            string? title)
        {
            this.Confidence = confidence;
            this.CreatedBy = createdBy;
            this.Title = title;
            this.ChartData = chartData ?? throw new global::System.ArgumentNullException(nameof(chartData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TabularChartMetaField" /> class.
        /// </summary>
        public TabularChartMetaField()
        {
        }
    }
}