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
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.SessionStartedPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Unique session identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// Session configuration returned by the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.SessionConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionStartedPayload" /> class.
        /// </summary>
        /// <param name="messageType">
        /// Must be 'session_started'.
        /// </param>
        /// <param name="sessionId">
        /// Unique session identifier.
        /// </param>
        /// <param name="config">
        /// Session configuration returned by the server.
        /// </param>
        public SessionStartedPayload(
            string sessionId,
            global::G.SessionStartedPayloadMessageType messageType,
            global::G.SessionConfig? config)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.MessageType = messageType;
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