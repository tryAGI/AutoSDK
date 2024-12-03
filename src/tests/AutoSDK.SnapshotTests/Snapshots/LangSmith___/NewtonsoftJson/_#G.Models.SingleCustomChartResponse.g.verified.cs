//HintName: G.Models.SingleCustomChartResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleCustomChartResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomChartsDataPoint> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Enum for custom chart types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chart_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomChartType ChartType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("series", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomChartSeries> Series { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("common_filters")]
        public global::G.CustomChartSeriesFilters? CommonFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="index"></param>
        /// <param name="chartType">
        /// Enum for custom chart types.
        /// </param>
        /// <param name="series"></param>
        /// <param name="commonFilters"></param>
        public SingleCustomChartResponse(
            global::System.Collections.Generic.IList<global::G.CustomChartsDataPoint> data,
            global::System.Guid id,
            string title,
            int index,
            global::G.CustomChartType chartType,
            global::System.Collections.Generic.IList<global::G.CustomChartSeries> series,
            string? description,
            object? metadata,
            global::G.CustomChartSeriesFilters? commonFilters)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Index = index;
            this.ChartType = chartType;
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Description = description;
            this.Metadata = metadata;
            this.CommonFilters = commonFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartResponse" /> class.
        /// </summary>
        public SingleCustomChartResponse()
        {
        }
    }
}