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
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChartSlice> Slices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PicturePieChartData" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="slices"></param>
        /// <param name="kind">
        /// Default Value: pie_chart_data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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