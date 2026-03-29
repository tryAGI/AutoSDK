//HintName: G.Models.ModelStatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelStatsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeSeries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelStatsTimeSeriesDataPoint> TimeSeries { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatsResponse" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="totalTokens"></param>
        /// <param name="timeSeries"></param>
        public ModelStatsResponse(
            string model,
            double totalTokens,
            global::System.Collections.Generic.IList<global::G.ModelStatsTimeSeriesDataPoint> timeSeries)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TotalTokens = totalTokens;
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatsResponse" /> class.
        /// </summary>
        public ModelStatsResponse()
        {
        }
    }
}