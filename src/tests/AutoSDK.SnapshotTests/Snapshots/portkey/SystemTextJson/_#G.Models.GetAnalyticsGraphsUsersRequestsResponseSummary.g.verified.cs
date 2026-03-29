//HintName: G.Models.GetAnalyticsGraphsUsersRequestsResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsUsersRequestsResponseSummary
    {
        /// <summary>
        /// Total requests across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Total unique users across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Unique { get; set; }

        /// <summary>
        /// Average requests per user across all data points
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
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsUsersRequestsResponseSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total requests across all data points
        /// </param>
        /// <param name="unique">
        /// Total unique users across all data points
        /// </param>
        /// <param name="avg">
        /// Average requests per user across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsUsersRequestsResponseSummary(
            int total,
            int unique,
            int avg)
        {
            this.Total = total;
            this.Unique = unique;
            this.Avg = avg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsUsersRequestsResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsUsersRequestsResponseSummary()
        {
        }
    }
}