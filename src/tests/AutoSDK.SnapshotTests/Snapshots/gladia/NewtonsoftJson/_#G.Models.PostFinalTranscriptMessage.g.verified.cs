//HintName: G.Models.PostFinalTranscriptMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostFinalTranscriptMessage
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
        /// Default Value: post_final_transcript<br/>
        /// Example: post_final_transcript
        /// </summary>
        /// <default>global::G.PostFinalTranscriptMessageType.PostFinalTranscript</default>
        /// <example>post_final_transcript</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostFinalTranscriptMessageTypeJsonConverter))]
        public global::G.PostFinalTranscriptMessageType Type { get; set; } = global::G.PostFinalTranscriptMessageType.PostFinalTranscript;

        /// <summary>
        /// The message data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StreamingTranscriptionResultDTO Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFinalTranscriptMessage" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </param>
        /// <param name="createdAt">
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="data">
        /// The message data
        /// </param>
        /// <param name="type">
        /// Default Value: post_final_transcript<br/>
        /// Example: post_final_transcript
        /// </param>
        public PostFinalTranscriptMessage(
            string sessionId,
            string createdAt,
            global::G.StreamingTranscriptionResultDTO data,
            global::G.PostFinalTranscriptMessageType type = global::G.PostFinalTranscriptMessageType.PostFinalTranscript)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFinalTranscriptMessage" /> class.
        /// </summary>
        public PostFinalTranscriptMessage()
        {
        }
    }
}