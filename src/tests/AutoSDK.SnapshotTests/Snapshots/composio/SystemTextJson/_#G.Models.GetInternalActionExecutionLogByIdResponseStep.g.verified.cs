//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetInternalActionExecutionLogByIdResponseStepType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetInternalActionExecutionLogByIdResponseStepStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.GetInternalActionExecutionLogByIdResponseStepMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public global::System.Collections.Generic.IList<global::G.GetInternalActionExecutionLogByIdResponseStepLog>? Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStep" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="totalDuration"></param>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="metadata"></param>
        /// <param name="logs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInternalActionExecutionLogByIdResponseStep(
            global::G.GetInternalActionExecutionLogByIdResponseStepType type,
            double startTime,
            double endTime,
            double totalDuration,
            global::G.GetInternalActionExecutionLogByIdResponseStepStatus status,
            string message,
            global::G.GetInternalActionExecutionLogByIdResponseStepMetadata? metadata,
            global::System.Collections.Generic.IList<global::G.GetInternalActionExecutionLogByIdResponseStepLog>? logs)
        {
            this.Type = type;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TotalDuration = totalDuration;
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Metadata = metadata;
            this.Logs = logs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStep" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseStep()
        {
        }
    }
}