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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The report data with all fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetReportResponseReport Report { get; set; }

        /// <summary>
        /// Overall status of the report execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetReportResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetReportResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetReportResponseStats Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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