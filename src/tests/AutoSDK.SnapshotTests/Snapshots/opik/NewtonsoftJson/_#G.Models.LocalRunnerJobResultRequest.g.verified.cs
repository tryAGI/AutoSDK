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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LocalRunnerJobResultRequestStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.JsonNode? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJobResultRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="traceId"></param>
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