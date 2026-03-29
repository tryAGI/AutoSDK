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
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Average cost per request across all data points
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
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCostResponseSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total cost in cents across all data points
        /// </param>
        /// <param name="avg">
        /// Average cost per request across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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