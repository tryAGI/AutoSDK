//HintName: G.Models.GetAnalyticsGraphsErrorsStatusCodesResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsErrorsStatusCodesResponseSummary
    {
        /// <summary>
        /// Total errors across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalErrors { get; set; }

        /// <summary>
        /// Unique error codes across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_error_codes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UniqueErrorCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStatusCodesResponseSummary" /> class.
        /// </summary>
        /// <param name="totalErrors">
        /// Total errors across all data points
        /// </param>
        /// <param name="uniqueErrorCodes">
        /// Unique error codes across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsErrorsStatusCodesResponseSummary(
            int totalErrors,
            int uniqueErrorCodes)
        {
            this.TotalErrors = totalErrors;
            this.UniqueErrorCodes = uniqueErrorCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStatusCodesResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsErrorsStatusCodesResponseSummary()
        {
        }
    }
}