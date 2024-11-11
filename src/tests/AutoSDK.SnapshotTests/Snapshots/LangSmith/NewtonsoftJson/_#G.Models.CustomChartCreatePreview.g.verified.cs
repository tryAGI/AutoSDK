//HintName: G.Models.CustomChartCreatePreview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartCreatePreview
    {
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
        /// Initializes a new instance of the <see cref="CustomChartCreatePreview" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="commonFilters"></param>
        public CustomChartCreatePreview(
            global::System.Collections.Generic.IList<global::G.CustomChartSeries> series,
            global::G.CustomChartSeriesFilters? commonFilters)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.CommonFilters = commonFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartCreatePreview" /> class.
        /// </summary>
        public CustomChartCreatePreview()
        {
        }
    }
}