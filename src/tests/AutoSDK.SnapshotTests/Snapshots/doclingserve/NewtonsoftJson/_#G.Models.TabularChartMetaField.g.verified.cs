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
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The origin of the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// BaseTableData.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chart_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TableData ChartData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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