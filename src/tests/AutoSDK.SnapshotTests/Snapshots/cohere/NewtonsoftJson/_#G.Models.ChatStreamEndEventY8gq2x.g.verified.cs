//HintName: G.Models.ChatStreamEndEventY8gq2x.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamEndEventY8gq2x
    {
        /// <summary>
        /// - `COMPLETE` - the model sent back a finished reply<br/>
        /// - `ERROR_LIMIT` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
        /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens specified by the max_tokens parameter<br/>
        /// - `ERROR` - something went wrong when generating the reply<br/>
        /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatStreamEndEventY8gq2xFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// The consolidated response from the model. Contains the generated reply and all the other information streamed back in the previous events.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NonStreamedChatResponse Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEndEventY8gq2x" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// - `COMPLETE` - the model sent back a finished reply<br/>
        /// - `ERROR_LIMIT` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
        /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens specified by the max_tokens parameter<br/>
        /// - `ERROR` - something went wrong when generating the reply<br/>
        /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
        /// </param>
        /// <param name="response">
        /// The consolidated response from the model. Contains the generated reply and all the other information streamed back in the previous events.
        /// </param>
        public ChatStreamEndEventY8gq2x(
            global::G.ChatStreamEndEventY8gq2xFinishReason finishReason,
            global::G.NonStreamedChatResponse response)
        {
            this.FinishReason = finishReason;
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEndEventY8gq2x" /> class.
        /// </summary>
        public ChatStreamEndEventY8gq2x()
        {
        }
    }
}