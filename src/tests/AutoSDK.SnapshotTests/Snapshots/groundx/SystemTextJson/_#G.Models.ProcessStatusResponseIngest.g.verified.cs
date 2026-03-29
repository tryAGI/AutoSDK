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
        [global::System.Text.Json.Serialization.JsonPropertyName("processId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProcessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::G.ProcessStatusResponseIngestProgress? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProcessingStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProcessingStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngest" /> class.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
        /// <param name="statusMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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