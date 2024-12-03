//HintName: G.Models.ProcessUIErrorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessUIErrorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace", Required = global::Newtonsoft.Json.Required.Always)]
        public string Workspace { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentTarget", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurrentTarget { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stacktrace", Required = global::Newtonsoft.Json.Required.Always)]
        public string Stacktrace { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessUIErrorRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="workspace"></param>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="currentTarget"></param>
        /// <param name="stacktrace"></param>
        public ProcessUIErrorRequest(
            string projectId,
            string userId,
            string workspace,
            string errorCode,
            string message,
            string currentTarget,
            string stacktrace)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Workspace = workspace ?? throw new global::System.ArgumentNullException(nameof(workspace));
            this.ErrorCode = errorCode ?? throw new global::System.ArgumentNullException(nameof(errorCode));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.CurrentTarget = currentTarget ?? throw new global::System.ArgumentNullException(nameof(currentTarget));
            this.Stacktrace = stacktrace ?? throw new global::System.ArgumentNullException(nameof(stacktrace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessUIErrorRequest" /> class.
        /// </summary>
        public ProcessUIErrorRequest()
        {
        }
    }
}