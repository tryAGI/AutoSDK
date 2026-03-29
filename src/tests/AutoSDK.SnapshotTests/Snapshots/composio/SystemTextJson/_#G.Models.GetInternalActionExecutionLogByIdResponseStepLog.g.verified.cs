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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetInternalActionExecutionLogByIdResponseStepLogType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetInternalActionExecutionLogByIdResponseStepLogRequest Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetInternalActionExecutionLogByIdResponseStepLogResponse Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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