//HintName: G.Models.GetAnalyticsGraphsErrorsStacksResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsErrorsStacksResponseSummary
    {
        /// <summary>
        /// Total errors across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStacksResponseSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total errors across all data points
        /// </param>
        public GetAnalyticsGraphsErrorsStacksResponseSummary(
            int total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStacksResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsErrorsStacksResponseSummary()
        {
        }
    }
}