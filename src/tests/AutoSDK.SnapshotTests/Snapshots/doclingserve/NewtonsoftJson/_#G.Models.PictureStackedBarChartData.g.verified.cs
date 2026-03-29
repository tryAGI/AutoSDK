//HintName: G.Models.PictureStackedBarChartData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents data of a stacked bar chart.<br/>
    /// Attributes:<br/>
    ///     kind (Literal["stacked_bar_chart_data"]): The type of the chart.<br/>
    ///     x_axis_label (str): The label for the x-axis.<br/>
    ///     y_axis_label (str): The label for the y-axis.<br/>
    ///     stacked_bars (list[ChartStackedBar]): A list of stacked bars in the chart.
    /// </summary>
    public sealed partial class PictureStackedBarChartData
    {
        /// <summary>
        /// Default Value: stacked_bar_chart_data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x_axis_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string XAxisLabel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y_axis_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string YAxisLabel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stacked_bars", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChartStackedBar> StackedBars { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureStackedBarChartData" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="xAxisLabel"></param>
        /// <param name="yAxisLabel"></param>
        /// <param name="stackedBars"></param>
        /// <param name="kind">
        /// Default Value: stacked_bar_chart_data
        /// </param>
        public PictureStackedBarChartData(
            string title,
            string xAxisLabel,
            string yAxisLabel,
            global::System.Collections.Generic.IList<global::G.ChartStackedBar> stackedBars,
            string? kind)
        {
            this.Kind = kind;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.XAxisLabel = xAxisLabel ?? throw new global::System.ArgumentNullException(nameof(xAxisLabel));
            this.YAxisLabel = yAxisLabel ?? throw new global::System.ArgumentNullException(nameof(yAxisLabel));
            this.StackedBars = stackedBars ?? throw new global::System.ArgumentNullException(nameof(stackedBars));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureStackedBarChartData" /> class.
        /// </summary>
        public PictureStackedBarChartData()
        {
        }
    }
}