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
        [global::Newtonsoft.Json.JsonProperty("total_errors", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalErrors { get; set; } = default!;

        /// <summary>
        /// Unique error codes across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unique_error_codes", Required = global::Newtonsoft.Json.Required.Always)]
        public int UniqueErrorCodes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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