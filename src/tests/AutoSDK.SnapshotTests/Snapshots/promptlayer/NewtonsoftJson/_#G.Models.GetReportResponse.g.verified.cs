//HintName: G.Models.GetReportResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetReportResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The report data with all fields
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetReportResponseReport Report { get; set; } = default!;

        /// <summary>
        /// Overall status of the report execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetReportResponseStatusJsonConverter))]
        public global::G.GetReportResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetReportResponseStats Stats { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="report">
        /// The report data with all fields
        /// </param>
        /// <param name="status">
        /// Overall status of the report execution
        /// </param>
        /// <param name="stats"></param>
        public GetReportResponse(
            bool success,
            string message,
            global::G.GetReportResponseReport report,
            global::G.GetReportResponseStatus status,
            global::G.GetReportResponseStats stats)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Report = report ?? throw new global::System.ArgumentNullException(nameof(report));
            this.Status = status;
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponse" /> class.
        /// </summary>
        public GetReportResponse()
        {
        }
    }
}