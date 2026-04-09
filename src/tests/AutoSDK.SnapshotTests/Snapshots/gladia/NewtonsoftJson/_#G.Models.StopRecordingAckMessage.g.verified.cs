//HintName: G.Models.StopRecordingAckMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopRecordingAckMessage
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
        /// Flag to indicate if the action was successfully acknowledged<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("acknowledged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Acknowledged { get; set; } = default!;

        /// <summary>
        /// Error message if the action was not successfully acknowledged<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.Error? Error { get; set; }

        /// <summary>
        /// Default Value: stop_recording<br/>
        /// Example: stop_recording
        /// </summary>
        /// <default>global::G.StopRecordingAckMessageType.StopRecording</default>
        /// <example>stop_recording</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StopRecordingAckMessageTypeJsonConverter))]
        public global::G.StopRecordingAckMessageType Type { get; set; } = global::G.StopRecordingAckMessageType.StopRecording;

        /// <summary>
        /// The message data. "null" if the action was not successfully acknowledged
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.StopRecordingAckData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAckMessage" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </param>
        /// <param name="createdAt">
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="acknowledged">
        /// Flag to indicate if the action was successfully acknowledged<br/>
        /// Example: true
        /// </param>
        /// <param name="error">
        /// Error message if the action was not successfully acknowledged<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="data">
        /// The message data. "null" if the action was not successfully acknowledged
        /// </param>
        /// <param name="type">
        /// Default Value: stop_recording<br/>
        /// Example: stop_recording
        /// </param>
        public StopRecordingAckMessage(
            string sessionId,
            string createdAt,
            bool acknowledged,
            global::G.Error? error,
            global::G.StopRecordingAckData? data,
            global::G.StopRecordingAckMessageType type = global::G.StopRecordingAckMessageType.StopRecording)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Acknowledged = acknowledged;
            this.Error = error;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAckMessage" /> class.
        /// </summary>
        public StopRecordingAckMessage()
        {
        }
    }
}