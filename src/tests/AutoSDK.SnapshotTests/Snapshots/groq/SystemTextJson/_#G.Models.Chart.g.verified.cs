//HintName: G.Models.Chart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chart
    {
        /// <summary>
        /// The type of chart
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChartType Type { get; set; }

        /// <summary>
        /// The title of the chart
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The label for the x-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_label")]
        public string? XLabel { get; set; }

        /// <summary>
        /// The label for the y-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_label")]
        public string? YLabel { get; set; }

        /// <summary>
        /// The unit for the x-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_unit")]
        public string? XUnit { get; set; }

        /// <summary>
        /// The unit for the y-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_unit")]
        public string? YUnit { get; set; }

        /// <summary>
        /// The tick values for the x-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_ticks")]
        public global::System.Collections.Generic.IList<double>? XTicks { get; set; }

        /// <summary>
        /// The tick values for the y-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_ticks")]
        public global::System.Collections.Generic.IList<double>? YTicks { get; set; }

        /// <summary>
        /// The labels for the x-axis ticks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_tick_labels")]
        public global::System.Collections.Generic.IList<string>? XTickLabels { get; set; }

        /// <summary>
        /// The labels for the y-axis ticks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_tick_labels")]
        public global::System.Collections.Generic.IList<string>? YTickLabels { get; set; }

        /// <summary>
        /// The scale type for the x-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_scale")]
        public string? XScale { get; set; }

        /// <summary>
        /// The scale type for the y-axis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_scale")]
        public string? YScale { get; set; }

        /// <summary>
        /// The chart elements (data series, points, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChartElement> Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of chart
        /// </param>
        /// <param name="elements">
        /// The chart elements (data series, points, etc.)
        /// </param>
        /// <param name="title">
        /// The title of the chart
        /// </param>
        /// <param name="xLabel">
        /// The label for the x-axis
        /// </param>
        /// <param name="yLabel">
        /// The label for the y-axis
        /// </param>
        /// <param name="xUnit">
        /// The unit for the x-axis
        /// </param>
        /// <param name="yUnit">
        /// The unit for the y-axis
        /// </param>
        /// <param name="xTicks">
        /// The tick values for the x-axis
        /// </param>
        /// <param name="yTicks">
        /// The tick values for the y-axis
        /// </param>
        /// <param name="xTickLabels">
        /// The labels for the x-axis ticks
        /// </param>
        /// <param name="yTickLabels">
        /// The labels for the y-axis ticks
        /// </param>
        /// <param name="xScale">
        /// The scale type for the x-axis
        /// </param>
        /// <param name="yScale">
        /// The scale type for the y-axis
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Chart(
            global::G.ChartType type,
            global::System.Collections.Generic.IList<global::G.ChartElement> elements,
            string? title,
            string? xLabel,
            string? yLabel,
            string? xUnit,
            string? yUnit,
            global::System.Collections.Generic.IList<double>? xTicks,
            global::System.Collections.Generic.IList<double>? yTicks,
            global::System.Collections.Generic.IList<string>? xTickLabels,
            global::System.Collections.Generic.IList<string>? yTickLabels,
            string? xScale,
            string? yScale)
        {
            this.Type = type;
            this.Title = title;
            this.XLabel = xLabel;
            this.YLabel = yLabel;
            this.XUnit = xUnit;
            this.YUnit = yUnit;
            this.XTicks = xTicks;
            this.YTicks = yTicks;
            this.XTickLabels = xTickLabels;
            this.YTickLabels = yTickLabels;
            this.XScale = xScale;
            this.YScale = yScale;
            this.Elements = elements ?? throw new global::System.ArgumentNullException(nameof(elements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart" /> class.
        /// </summary>
        public Chart()
        {
        }
    }
}