//HintName: G.Models.ErrorDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of an error.
    /// </summary>
    public sealed partial class ErrorDetails
    {
        /// <summary>
        /// The type of error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Error code, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Parameter related to the error, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The event_id of the client event that caused the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of error.
        /// </param>
        /// <param name="code">
        /// Error code, if any.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        /// <param name="param">
        /// Parameter related to the error, if any.
        /// </param>
        /// <param name="eventId">
        /// The event_id of the client event that caused the error.
        /// </param>
        public ErrorDetails(
            string? type,
            string? code,
            string? message,
            string? param,
            string? eventId)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message;
            this.Param = param;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails" /> class.
        /// </summary>
        public ErrorDetails()
        {
        }
    }
}