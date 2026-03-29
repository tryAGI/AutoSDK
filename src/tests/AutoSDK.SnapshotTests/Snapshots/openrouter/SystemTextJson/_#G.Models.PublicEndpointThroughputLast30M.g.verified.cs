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
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P50 { get; set; }

        /// <summary>
        /// 75th percentile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P75 { get; set; }

        /// <summary>
        /// 90th percentile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P90 { get; set; }

        /// <summary>
        /// 99th percentile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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