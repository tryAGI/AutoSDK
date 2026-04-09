//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseStepLog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeJsonConverter))]
        public global::G.GetInternalActionExecutionLogByIdResponseStepLogType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level", Required = global::Newtonsoft.Json.Required.Always)]
        public string Level { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetInternalActionExecutionLogByIdResponseStepLogRequest Request { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetInternalActionExecutionLogByIdResponseStepLogResponse Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepLog" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="requestId"></param>
        /// <param name="time"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
        public GetInternalActionExecutionLogByIdResponseStepLog(
            global::G.GetInternalActionExecutionLogByIdResponseStepLogType type,
            string level,
            string message,
            global::System.Guid requestId,
            double time,
            global::G.GetInternalActionExecutionLogByIdResponseStepLogRequest request,
            global::G.GetInternalActionExecutionLogByIdResponseStepLogResponse response)
        {
            this.Type = type;
            this.Level = level ?? throw new global::System.ArgumentNullException(nameof(level));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequestId = requestId;
            this.Time = time;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepLog" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseStepLog()
        {
        }
    }
}