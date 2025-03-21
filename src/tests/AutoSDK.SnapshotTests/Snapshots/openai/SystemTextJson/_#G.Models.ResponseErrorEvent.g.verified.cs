//HintName: G.Models.ResponseErrorEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an error occurs.
    /// </summary>
    public sealed partial class ResponseErrorEvent
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The error parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Param { get; set; }

        /// <summary>
        /// The type of the event. Always `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseErrorEventTypeJsonConverter))]
        public global::G.ResponseErrorEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        /// <param name="param">
        /// The error parameter.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseErrorEvent(
            string? code,
            string message,
            string? param,
            global::G.ResponseErrorEventType type)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param ?? throw new global::System.ArgumentNullException(nameof(param));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        public ResponseErrorEvent()
        {
        }
    }
}