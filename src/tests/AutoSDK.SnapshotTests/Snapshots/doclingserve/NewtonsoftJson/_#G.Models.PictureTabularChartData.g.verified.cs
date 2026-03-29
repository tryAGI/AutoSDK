//HintName: G.Models.PictureTabularChartData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base class for picture chart data.<br/>
    /// Attributes:<br/>
    ///     title (str): The title of the chart.<br/>
    ///     chart_data (TableData): Chart data in the table format.
    /// </summary>
    public sealed partial class PictureTabularChartData
    {
        /// <summary>
        /// Default Value: tabular_chart_data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PictureTabularChartData" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="chartData">
        /// BaseTableData.
        /// </param>
        /// <param name="kind">
        /// Default Value: tabular_chart_data
        /// </param>
        public PictureTabularChartData(
            string title,
            global::G.TableData chartData,
            string? kind)
        {
            this.Kind = kind;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ChartData = chartData ?? throw new global::System.ArgumentNullException(nameof(chartData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureTabularChartData" /> class.
        /// </summary>
        public PictureTabularChartData()
        {
        }
    }
}