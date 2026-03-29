//HintName: G.Models.LocalRunnerJobResultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerJobResultRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LocalRunnerJobResultRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LocalRunnerJobResultRequestStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.JsonNode? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJobResultRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="traceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunnerJobResultRequest(
            global::G.LocalRunnerJobResultRequestStatus status,
            global::G.JsonNode? result,
            string? error,
            global::System.Guid? traceId)
        {
            this.Status = status;
            this.Result = result;
            this.Error = error;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJobResultRequest" /> class.
        /// </summary>
        public LocalRunnerJobResultRequest()
        {
        }
    }
}