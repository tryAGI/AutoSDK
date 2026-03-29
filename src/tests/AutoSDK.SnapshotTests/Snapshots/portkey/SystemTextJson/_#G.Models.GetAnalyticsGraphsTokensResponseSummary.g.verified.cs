//HintName: G.Models.GetAnalyticsGraphsTokensResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsTokensResponseSummary
    {
        /// <summary>
        /// Total tokens across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Average tokens per request across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Avg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsTokensResponseSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total tokens across all data points
        /// </param>
        /// <param name="avg">
        /// Average tokens per request across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsTokensResponseSummary(
            int total,
            int avg)
        {
            this.Total = total;
            this.Avg = avg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsTokensResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsTokensResponseSummary()
        {
        }
    }
}