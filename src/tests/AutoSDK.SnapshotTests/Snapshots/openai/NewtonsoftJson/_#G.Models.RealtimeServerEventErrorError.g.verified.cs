//HintName: G.Models.RealtimeServerEventErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the error.
    /// </summary>
    public sealed partial class RealtimeServerEventErrorError
    {
        /// <summary>
        /// Error code, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The event_id of the client event that caused the error, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Parameter related to the error, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The type of error (e.g., "invalid_request_error", "server_error").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventErrorError" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code, if any.
        /// </param>
        /// <param name="eventId">
        /// The event_id of the client event that caused the error, if applicable.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        /// <param name="param">
        /// Parameter related to the error, if any.
        /// </param>
        /// <param name="type">
        /// The type of error (e.g., "invalid_request_error", "server_error").
        /// </param>
        public RealtimeServerEventErrorError(
            string message,
            string type,
            string? code,
            string? eventId,
            string? param)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Code = code;
            this.EventId = eventId;
            this.Param = param;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventErrorError" /> class.
        /// </summary>
        public RealtimeServerEventErrorError()
        {
        }
    }
}