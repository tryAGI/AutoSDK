//HintName: G.Models.GetAnalyticsGraphsErrorsResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsErrorsResponseSummary
    {
        /// <summary>
        /// Total errors across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsResponseSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total errors across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsErrorsResponseSummary(
            int total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsErrorsResponseSummary()
        {
        }
    }
}