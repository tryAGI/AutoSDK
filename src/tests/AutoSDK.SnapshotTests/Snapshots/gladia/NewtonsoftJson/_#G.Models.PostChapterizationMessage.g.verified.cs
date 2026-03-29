//HintName: G.Models.PostChapterizationMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostChapterizationMessage
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
        /// Error message if the addon failed<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.Error? Error { get; set; }

        /// <summary>
        /// Default Value: post_chapterization<br/>
        /// Example: post_chapterization
        /// </summary>
        /// <default>global::G.PostChapterizationMessageType.PostChapterization</default>
        /// <example>post_chapterization</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PostChapterizationMessageType Type { get; set; } = global::G.PostChapterizationMessageType.PostChapterization;

        /// <summary>
        /// The message data. "null" if the addon failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.PostChapterizationMessageData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChapterizationMessage" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </param>
        /// <param name="createdAt">
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="error">
        /// Error message if the addon failed<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="data">
        /// The message data. "null" if the addon failed
        /// </param>
        /// <param name="type">
        /// Default Value: post_chapterization<br/>
        /// Example: post_chapterization
        /// </param>
        public PostChapterizationMessage(
            string sessionId,
            string createdAt,
            global::G.Error? error,
            global::G.PostChapterizationMessageData? data,
            global::G.PostChapterizationMessageType type = global::G.PostChapterizationMessageType.PostChapterization)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Error = error;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChapterizationMessage" /> class.
        /// </summary>
        public PostChapterizationMessage()
        {
        }
    }
}