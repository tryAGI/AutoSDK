//HintName: G.Models.ProcessStatusResponseIngest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessStatusResponseIngest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProcessId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public global::G.ProcessStatusResponseIngestProgress? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProcessingStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngest" /> class.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
        /// <param name="statusMessage"></param>
        public ProcessStatusResponseIngest(
            global::System.Guid processId,
            global::G.ProcessingStatus status,
            global::G.ProcessStatusResponseIngestProgress? progress,
            string? statusMessage)
        {
            this.ProcessId = processId;
            this.Progress = progress;
            this.Status = status;
            this.StatusMessage = statusMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngest" /> class.
        /// </summary>
        public ProcessStatusResponseIngest()
        {
        }
    }
}