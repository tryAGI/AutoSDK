//HintName: G.Models.GetAnalyticsGraphsCostResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsCostResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAnalyticsGraphsCostResponseSummary Summary { get; set; } = default!;

        /// <summary>
        /// An array of data points, each with a timestamp and metrics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_points", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsCostResponseDataPoint> DataPoints { get; set; } = default!;

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.GetAnalyticsGraphsCostResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCostResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="dataPoints">
        /// An array of data points, each with a timestamp and metrics
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
        public GetAnalyticsGraphsCostResponse(
            global::G.GetAnalyticsGraphsCostResponseSummary summary,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsCostResponseDataPoint> dataPoints,
            global::G.GetAnalyticsGraphsCostResponseObject @object)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.DataPoints = dataPoints ?? throw new global::System.ArgumentNullException(nameof(dataPoints));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCostResponse" /> class.
        /// </summary>
        public GetAnalyticsGraphsCostResponse()
        {
        }
    }
}