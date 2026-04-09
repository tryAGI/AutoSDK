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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeJsonConverter))]
        public global::G.GetInternalActionExecutionLogByIdResponseStepType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTime", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalDuration", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalDuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusJsonConverter))]
        public global::G.GetInternalActionExecutionLogByIdResponseStepStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.GetInternalActionExecutionLogByIdResponseStepMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs")]
        public global::System.Collections.Generic.IList<global::G.GetInternalActionExecutionLogByIdResponseStepLog>? Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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