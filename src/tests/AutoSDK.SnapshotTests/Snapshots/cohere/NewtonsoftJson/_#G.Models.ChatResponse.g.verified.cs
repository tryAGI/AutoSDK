//HintName: G.Models.ChatResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatResponse
    {
        /// <summary>
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The reason a chat request has finished.<br/>
        /// - **complete**: The model finished sending a complete message.<br/>
        /// - **max_tokens**: The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.<br/>
        /// - **stop_sequence**: One of the provided `stop_sequence` entries was reached in the model's generation.<br/>
        /// - **tool_call**: The model generated a Tool Call and is expecting a Tool Message in return<br/>
        /// - **error**: The generation failed due to an internal error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// A message from the assistant role can contain text and tool call information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssistantMessageResponse Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::System.Collections.Generic.IList<global::G.LogprobItem>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </param>
        /// <param name="finishReason">
        /// The reason a chat request has finished.<br/>
        /// - **complete**: The model finished sending a complete message.<br/>
        /// - **max_tokens**: The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.<br/>
        /// - **stop_sequence**: One of the provided `stop_sequence` entries was reached in the model's generation.<br/>
        /// - **tool_call**: The model generated a Tool Call and is expecting a Tool Message in return<br/>
        /// - **error**: The generation failed due to an internal error
        /// </param>
        /// <param name="message">
        /// A message from the assistant role can contain text and tool call information.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="logprobs"></param>
        public ChatResponse(
            string id,
            global::G.ChatFinishReason finishReason,
            global::G.AssistantMessageResponse message,
            global::G.Usage? usage,
            global::System.Collections.Generic.IList<global::G.LogprobItem>? logprobs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FinishReason = finishReason;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Usage = usage;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse" /> class.
        /// </summary>
        public ChatResponse()
        {
        }
    }
}