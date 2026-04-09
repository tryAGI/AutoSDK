//HintName: G.Models.ChatRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Chat payload. Here you will need to pass the message with additional details
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// List of messages for Chat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatRequestMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Id of Stream (a new WebRTC connection to a browser peer)<br/>
        /// For more details go to Stream documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streamId")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Id of session for Stream<br/>
        /// Required to organize requests to one thread of messages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chatMode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatRequestChatModeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatRequestChatMode? ChatMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of messages for Chat
        /// </param>
        /// <param name="streamId">
        /// Id of Stream (a new WebRTC connection to a browser peer)<br/>
        /// For more details go to Stream documents
        /// </param>
        /// <param name="sessionId">
        /// Id of session for Stream<br/>
        /// Required to organize requests to one thread of messages
        /// </param>
        public ChatRequest(
            global::System.Collections.Generic.IList<global::G.ChatRequestMessage> messages,
            string? streamId,
            string? sessionId)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.StreamId = streamId;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        public ChatRequest()
        {
        }
    }
}