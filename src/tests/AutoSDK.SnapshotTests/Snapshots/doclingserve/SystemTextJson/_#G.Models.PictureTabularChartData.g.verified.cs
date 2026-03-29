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
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

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
        /// Initializes a new instance of the <see cref="PictureTabularChartData" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="chartData">
        /// BaseTableData.
        /// </param>
        /// <param name="kind">
        /// Default Value: tabular_chart_data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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