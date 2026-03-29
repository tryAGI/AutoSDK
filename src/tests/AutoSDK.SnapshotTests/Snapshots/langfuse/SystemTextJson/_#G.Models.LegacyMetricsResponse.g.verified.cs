//HintName: G.Models.LegacyMetricsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyMetricsResponse
    {
        /// <summary>
        /// The metrics data. Each item in the list contains the metric values and dimensions requested in the query.<br/>
        /// Format varies based on the query parameters.<br/>
        /// Histograms will return an array with [lower, upper, height] tuples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyMetricsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The metrics data. Each item in the list contains the metric values and dimensions requested in the query.<br/>
        /// Format varies based on the query parameters.<br/>
        /// Histograms will return an array with [lower, upper, height] tuples.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyMetricsResponse(
            global::System.Collections.Generic.IList<object> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyMetricsResponse" /> class.
        /// </summary>
        public LegacyMetricsResponse()
        {
        }
    }
}