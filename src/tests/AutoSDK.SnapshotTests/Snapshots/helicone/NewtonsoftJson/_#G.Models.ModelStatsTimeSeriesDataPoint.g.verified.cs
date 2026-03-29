//HintName: G.Models.ModelStatsTimeSeriesDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelStatsTimeSeriesDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public string Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatsTimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="totalTokens"></param>
        public ModelStatsTimeSeriesDataPoint(
            string time,
            double totalTokens)
        {
            this.Time = time ?? throw new global::System.ArgumentNullException(nameof(time));
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatsTimeSeriesDataPoint" /> class.
        /// </summary>
        public ModelStatsTimeSeriesDataPoint()
        {
        }
    }
}