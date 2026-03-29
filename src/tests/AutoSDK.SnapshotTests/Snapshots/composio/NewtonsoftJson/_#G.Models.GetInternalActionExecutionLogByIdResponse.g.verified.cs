//HintName: G.Models.GetInternalActionExecutionLogByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actionLogId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ActionLogId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ActionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetInternalActionExecutionLogByIdResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetInternalActionExecutionLogByIdResponseApp App { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetInternalActionExecutionLogByIdResponseConnection Connection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Session { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("executionMetadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> ExecutionMetadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetInternalActionExecutionLogByIdResponseStep> Steps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payloadReceived", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> PayloadReceived { get; set; } = default!;

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
        public string TotalDuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Response { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponse" /> class.
        /// </summary>
        /// <param name="actionLogId"></param>
        /// <param name="actionId"></param>
        /// <param name="status"></param>
        /// <param name="app"></param>
        /// <param name="version"></param>
        /// <param name="connection"></param>
        /// <param name="session"></param>
        /// <param name="executionMetadata"></param>
        /// <param name="steps"></param>
        /// <param name="payloadReceived"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="totalDuration"></param>
        /// <param name="response"></param>
        /// <param name="error"></param>
        public GetInternalActionExecutionLogByIdResponse(
            string actionLogId,
            string actionId,
            global::G.GetInternalActionExecutionLogByIdResponseStatus status,
            global::G.GetInternalActionExecutionLogByIdResponseApp app,
            string version,
            global::G.GetInternalActionExecutionLogByIdResponseConnection connection,
            global::System.Collections.Generic.Dictionary<string, object?> session,
            global::System.Collections.Generic.Dictionary<string, object?> executionMetadata,
            global::System.Collections.Generic.IList<global::G.GetInternalActionExecutionLogByIdResponseStep> steps,
            global::System.Collections.Generic.Dictionary<string, object?> payloadReceived,
            double startTime,
            double endTime,
            string totalDuration,
            global::System.Collections.Generic.Dictionary<string, object?> response,
            global::System.Collections.Generic.Dictionary<string, object?> error)
        {
            this.ActionLogId = actionLogId ?? throw new global::System.ArgumentNullException(nameof(actionLogId));
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.Status = status;
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Connection = connection ?? throw new global::System.ArgumentNullException(nameof(connection));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.ExecutionMetadata = executionMetadata ?? throw new global::System.ArgumentNullException(nameof(executionMetadata));
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.PayloadReceived = payloadReceived ?? throw new global::System.ArgumentNullException(nameof(payloadReceived));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TotalDuration = totalDuration ?? throw new global::System.ArgumentNullException(nameof(totalDuration));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponse" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponse()
        {
        }
    }
}