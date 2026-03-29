//HintName: G.Models.PublicEndpointThroughputLast30M.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicEndpointThroughputLast30M
    {
        /// <summary>
        /// Median (50th percentile)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p50", Required = global::Newtonsoft.Json.Required.Always)]
        public double P50 { get; set; } = default!;

        /// <summary>
        /// 75th percentile
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p75", Required = global::Newtonsoft.Json.Required.Always)]
        public double P75 { get; set; } = default!;

        /// <summary>
        /// 90th percentile
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90", Required = global::Newtonsoft.Json.Required.Always)]
        public double P90 { get; set; } = default!;

        /// <summary>
        /// 99th percentile
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p99", Required = global::Newtonsoft.Json.Required.Always)]
        public double P99 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointThroughputLast30M" /> class.
        /// </summary>
        /// <param name="p50">
        /// Median (50th percentile)
        /// </param>
        /// <param name="p75">
        /// 75th percentile
        /// </param>
        /// <param name="p90">
        /// 90th percentile
        /// </param>
        /// <param name="p99">
        /// 99th percentile
        /// </param>
        public PublicEndpointThroughputLast30M(
            double p50,
            double p75,
            double p90,
            double p99)
        {
            this.P50 = p50;
            this.P75 = p75;
            this.P90 = p90;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointThroughputLast30M" /> class.
        /// </summary>
        public PublicEndpointThroughputLast30M()
        {
        }
    }
}