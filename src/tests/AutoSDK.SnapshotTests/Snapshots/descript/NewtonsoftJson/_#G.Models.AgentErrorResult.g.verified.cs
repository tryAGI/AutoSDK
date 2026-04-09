//HintName: G.Models.AgentErrorResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result when Agent edit failed
    /// </summary>
    public sealed partial class AgentErrorResult
    {
        /// <summary>
        /// Indicates the job failed<br/>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentErrorResultStatusJsonConverter))]
        public global::G.AgentErrorResultStatus Status { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: AI agent failed to process the request
        /// </summary>
        /// <example>AI agent failed to process the request</example>
        [global::Newtonsoft.Json.JsonProperty("error_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorMessage { get; set; } = default!;

        /// <summary>
        /// Machine-readable error code<br/>
        /// Example: agent_execution_failed
        /// </summary>
        /// <example>agent_execution_failed</example>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorResult" /> class.
        /// </summary>
        /// <param name="errorMessage">
        /// Human-readable error message<br/>
        /// Example: AI agent failed to process the request
        /// </param>
        /// <param name="status">
        /// Indicates the job failed<br/>
        /// Example: error
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code<br/>
        /// Example: agent_execution_failed
        /// </param>
        public AgentErrorResult(
            string errorMessage,
            global::G.AgentErrorResultStatus status,
            string? errorCode)
        {
            this.Status = status;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorResult" /> class.
        /// </summary>
        public AgentErrorResult()
        {
        }
    }
}