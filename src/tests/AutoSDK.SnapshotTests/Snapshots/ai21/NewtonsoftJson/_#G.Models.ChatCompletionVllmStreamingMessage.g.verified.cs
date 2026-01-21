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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionResponseDeltaChoice> Choices { get; set; } = default!;

        /// <summary>
        /// Included in the last message only. Total token counts for the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.UsageInfo? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="usage">
        /// Included in the last message only. Total token counts for the message.
        /// </param>
        /// <param name="meta"></param>
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