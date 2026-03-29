//HintName: G.Models.LettaErrorMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error messages are used to notify the client of an error that occurred during the agent's execution.
    /// </summary>
    public sealed partial class LettaErrorMessage
    {
        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: error_message
        /// </summary>
        /// <default>"error_message"</default>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string MessageType { get; set; } = "error_message";

        /// <summary>
        /// The ID of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// The type of error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorType { get; set; } = default!;

        /// <summary>
        /// The error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// An optional error detail.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// The sequence ID for cursor-based pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seq_id")]
        public int? SeqId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaErrorMessage" /> class.
        /// </summary>
        /// <param name="runId">
        /// The ID of the run.
        /// </param>
        /// <param name="errorType">
        /// The type of error.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        /// <param name="detail">
        /// An optional error detail.
        /// </param>
        /// <param name="seqId">
        /// The sequence ID for cursor-based pagination.
        /// </param>
        /// <param name="messageType">
        /// The type of the message.<br/>
        /// Default Value: error_message
        /// </param>
        public LettaErrorMessage(
            string runId,
            string errorType,
            string message,
            string? detail,
            int? seqId,
            string messageType = "error_message")
        {
            this.MessageType = messageType;
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Detail = detail;
            this.SeqId = seqId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaErrorMessage" /> class.
        /// </summary>
        public LettaErrorMessage()
        {
        }
    }
}