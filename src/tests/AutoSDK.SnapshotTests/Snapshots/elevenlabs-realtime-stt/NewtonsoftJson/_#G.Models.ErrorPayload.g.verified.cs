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
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.ErrorPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Type of error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorType { get; set; } = default!;

        /// <summary>
        /// Error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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