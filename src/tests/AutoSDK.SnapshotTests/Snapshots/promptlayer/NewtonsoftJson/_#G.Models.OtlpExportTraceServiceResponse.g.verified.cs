//HintName: G.Models.OtlpExportTraceServiceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to an OTLP trace export request.
    /// </summary>
    public sealed partial class OtlpExportTraceServiceResponse
    {
        /// <summary>
        /// Present only when some spans were rejected. Null when all spans were accepted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partialSuccess")]
        public global::G.OtlpExportTraceServiceResponsePartialSuccess? PartialSuccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceResponse" /> class.
        /// </summary>
        /// <param name="partialSuccess">
        /// Present only when some spans were rejected. Null when all spans were accepted.
        /// </param>
        public OtlpExportTraceServiceResponse(
            global::G.OtlpExportTraceServiceResponsePartialSuccess? partialSuccess)
        {
            this.PartialSuccess = partialSuccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceResponse" /> class.
        /// </summary>
        public OtlpExportTraceServiceResponse()
        {
        }
    }
}