//HintName: G.Models.CreateChatStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatStreamResponse
    {
        /// <summary>
        /// This is the unique identifier for the streaming response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Helps track conversation context across multiple messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// This is the path to the content being updated.<br/>
        /// Format: `chat.output[{contentIndex}].content` where contentIndex identifies the specific content item.<br/>
        /// Example: chat.output[0].content
        /// </summary>
        /// <example>chat.output[0].content</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// This is the incremental content chunk being streamed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatStreamResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the streaming response.
        /// </param>
        /// <param name="path">
        /// This is the path to the content being updated.<br/>
        /// Format: `chat.output[{contentIndex}].content` where contentIndex identifies the specific content item.<br/>
        /// Example: chat.output[0].content
        /// </param>
        /// <param name="delta">
        /// This is the incremental content chunk being streamed.
        /// </param>
        /// <param name="sessionId">
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Helps track conversation context across multiple messages.
        /// </param>
        public CreateChatStreamResponse(
            string id,
            string path,
            string delta,
            string? sessionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionId = sessionId;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatStreamResponse" /> class.
        /// </summary>
        public CreateChatStreamResponse()
        {
        }
    }
}