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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Error code, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Parameter related to the error, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The event_id of the client event that caused the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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