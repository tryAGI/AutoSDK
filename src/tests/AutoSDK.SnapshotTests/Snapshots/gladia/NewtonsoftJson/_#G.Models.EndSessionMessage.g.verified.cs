//HintName: G.Models.EndSessionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndSessionMessage
    {
        /// <summary>
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </summary>
        /// <example>4a39145c-2844-4557-8f34-34883f7be7d9</example>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Default Value: end_session<br/>
        /// Example: end_session
        /// </summary>
        /// <default>global::G.EndSessionMessageType.EndSession</default>
        /// <example>end_session</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EndSessionMessageTypeJsonConverter))]
        public global::G.EndSessionMessageType Type { get; set; } = global::G.EndSessionMessageType.EndSession;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndSessionMessage" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </param>
        /// <param name="createdAt">
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="type">
        /// Default Value: end_session<br/>
        /// Example: end_session
        /// </param>
        public EndSessionMessage(
            string sessionId,
            string createdAt,
            global::G.EndSessionMessageType type = global::G.EndSessionMessageType.EndSession)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndSessionMessage" /> class.
        /// </summary>
        public EndSessionMessage()
        {
        }
    }
}