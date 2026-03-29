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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Helps track conversation context across multiple messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// This is the path to the content being updated.<br/>
        /// Format: `chat.output[{contentIndex}].content` where contentIndex identifies the specific content item.<br/>
        /// Example: chat.output[0].content
        /// </summary>
        /// <example>chat.output[0].content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// This is the incremental content chunk being streamed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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