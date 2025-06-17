//HintName: G.Models.ChatMessageEndEventVariant2Delta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageEndEventVariant2Delta
    {
        /// <summary>
        /// An error message if an error occurred during the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The reason a chat request has finished.<br/>
        /// - **complete**: The model finished sending a complete message.<br/>
        /// - **max_tokens**: The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.<br/>
        /// - **stop_sequence**: One of the provided `stop_sequence` entries was reached in the model's generation.<br/>
        /// - **tool_call**: The model generated a Tool Call and is expecting a Tool Message in return<br/>
        /// - **error**: The generation failed due to an internal error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public global::G.ChatFinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2Delta" /> class.
        /// </summary>
        /// <param name="error">
        /// An error message if an error occurred during the generation.
        /// </param>
        /// <param name="finishReason">
        /// The reason a chat request has finished.<br/>
        /// - **complete**: The model finished sending a complete message.<br/>
        /// - **max_tokens**: The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.<br/>
        /// - **stop_sequence**: One of the provided `stop_sequence` entries was reached in the model's generation.<br/>
        /// - **tool_call**: The model generated a Tool Call and is expecting a Tool Message in return<br/>
        /// - **error**: The generation failed due to an internal error
        /// </param>
        /// <param name="usage"></param>
        public ChatMessageEndEventVariant2Delta(
            string? error,
            global::G.ChatFinishReason? finishReason,
            global::G.Usage? usage)
        {
            this.Error = error;
            this.FinishReason = finishReason;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2Delta" /> class.
        /// </summary>
        public ChatMessageEndEventVariant2Delta()
        {
        }
    }
}