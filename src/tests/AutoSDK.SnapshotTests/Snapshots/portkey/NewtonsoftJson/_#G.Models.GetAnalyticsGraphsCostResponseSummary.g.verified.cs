//HintName: G.Models.GetAnalyticsGraphsCostResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsCostResponseSummary
    {
        /// <summary>
        /// Total cost in cents across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Average cost per request across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg", Required = global::Newtonsoft.Json.Required.Always)]
        public int Avg { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCostResponseSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total cost in cents across all data points
        /// </param>
        /// <param name="avg">
        /// Average cost per request across all data points
        /// </param>
        public GetAnalyticsGraphsCostResponseSummary(
            int total,
            int avg)
        {
            this.Total = total;
            this.Avg = avg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCostResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsCostResponseSummary()
        {
        }
    }
}