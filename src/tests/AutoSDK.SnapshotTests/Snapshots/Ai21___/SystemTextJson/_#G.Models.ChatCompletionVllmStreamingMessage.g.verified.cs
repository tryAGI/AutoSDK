//HintName: G.Models.ChatCompletionVllmStreamingMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned for streaming messages. Non-streaming responses return `ChatCompletion`.
    /// </summary>
    public sealed partial class ChatCompletionVllmStreamingMessage
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionResponseDeltaChoice> Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.UsageInfo? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVllmStreamingMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="choices">
        /// The message
        /// </param>
        /// <param name="usage"></param>
        /// <param name="meta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionVllmStreamingMessage(
            string id,
            global::System.Collections.Generic.IList<global::G.ChatCompletionResponseDeltaChoice> choices,
            global::G.UsageInfo? usage,
            object? meta)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVllmStreamingMessage" /> class.
        /// </summary>
        public ChatCompletionVllmStreamingMessage()
        {
        }
    }
}