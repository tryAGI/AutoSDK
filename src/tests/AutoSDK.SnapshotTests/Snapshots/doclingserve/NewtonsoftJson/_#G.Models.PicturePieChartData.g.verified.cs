//HintName: G.Models.PicturePieChartData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents data of a pie chart.<br/>
    /// Attributes:<br/>
    ///     kind (Literal["pie_chart_data"]): The type of the chart.<br/>
    ///     slices (list[ChartSlice]): A list of slices in the pie chart.
    /// </summary>
    public sealed partial class PicturePieChartData
    {
        /// <summary>
        /// Default Value: pie_chart_data
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
        [global::Newtonsoft.Json.JsonProperty("slices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChartSlice> Slices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PicturePieChartData" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="slices"></param>
        /// <param name="kind">
        /// Default Value: pie_chart_data
        /// </param>
        public PicturePieChartData(
            string title,
            global::System.Collections.Generic.IList<global::G.ChartSlice> slices,
            string? kind)
        {
            this.Kind = kind;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Slices = slices ?? throw new global::System.ArgumentNullException(nameof(slices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PicturePieChartData" /> class.
        /// </summary>
        public PicturePieChartData()
        {
        }
    }
}