//HintName: G.Models.OtlpExportTraceServiceResponsePartialSuccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Present only when some spans were rejected. Null when all spans were accepted.
    /// </summary>
    public sealed partial class OtlpExportTraceServiceResponsePartialSuccess
    {
        /// <summary>
        /// The number of spans that were rejected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rejectedSpans")]
        public int? RejectedSpans { get; set; }

        /// <summary>
        /// A human-readable error message describing why spans were rejected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceResponsePartialSuccess" /> class.
        /// </summary>
        /// <param name="rejectedSpans">
        /// The number of spans that were rejected.
        /// </param>
        /// <param name="errorMessage">
        /// A human-readable error message describing why spans were rejected.
        /// </param>
        public OtlpExportTraceServiceResponsePartialSuccess(
            int? rejectedSpans,
            string? errorMessage)
        {
            this.RejectedSpans = rejectedSpans;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceResponsePartialSuccess" /> class.
        /// </summary>
        public OtlpExportTraceServiceResponsePartialSuccess()
        {
        }
    }
}