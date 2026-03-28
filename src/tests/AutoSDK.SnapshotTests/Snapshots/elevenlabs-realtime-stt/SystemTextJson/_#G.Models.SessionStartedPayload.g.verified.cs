//HintName: G.Models.SessionStartedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event sent when a session is started.
    /// </summary>
    public sealed partial class SessionStartedPayload
    {
        /// <summary>
        /// Must be 'session_started'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionStartedPayloadMessageTypeJsonConverter))]
        public global::G.SessionStartedPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Unique session identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Session configuration returned by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.SessionConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionStartedPayload" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Unique session identifier.
        /// </param>
        /// <param name="messageType">
        /// Must be 'session_started'.
        /// </param>
        /// <param name="config">
        /// Session configuration returned by the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionStartedPayload(
            string sessionId,
            global::G.SessionStartedPayloadMessageType messageType,
            global::G.SessionConfig? config)
        {
            this.MessageType = messageType;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionStartedPayload" /> class.
        /// </summary>
        public SessionStartedPayload()
        {
        }
    }
}