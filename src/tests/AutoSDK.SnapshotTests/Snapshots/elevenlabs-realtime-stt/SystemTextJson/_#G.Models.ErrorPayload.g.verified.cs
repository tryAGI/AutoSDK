//HintName: G.Models.ErrorPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error event.
    /// </summary>
    public sealed partial class ErrorPayload
    {
        /// <summary>
        /// Must be 'error'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ErrorPayloadMessageTypeJsonConverter))]
        public global::G.ErrorPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Type of error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorType { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        /// <param name="errorType">
        /// Type of error.
        /// </param>
        /// <param name="error">
        /// Error message.
        /// </param>
        /// <param name="messageType">
        /// Must be 'error'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorPayload(
            string errorType,
            string error,
            global::G.ErrorPayloadMessageType messageType)
        {
            this.MessageType = messageType;
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        public ErrorPayload()
        {
        }
    }
}