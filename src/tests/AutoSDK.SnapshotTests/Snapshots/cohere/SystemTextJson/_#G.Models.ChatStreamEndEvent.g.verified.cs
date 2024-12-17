//HintName: G.Models.ChatStreamEndEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamEndEvent : ChatStreamEvent
    {
        /// <summary>
        /// - `COMPLETE` - the model sent back a finished reply<br/>
        /// - `ERROR_LIMIT` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
        /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens specified by the max_tokens parameter<br/>
        /// - `ERROR` - something went wrong when generating the reply<br/>
        /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatStreamEndEventVariant2FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatStreamEndEventVariant2FinishReason FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NonStreamedChatResponse Response { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEndEvent" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// - `COMPLETE` - the model sent back a finished reply<br/>
        /// - `ERROR_LIMIT` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
        /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens specified by the max_tokens parameter<br/>
        /// - `ERROR` - something went wrong when generating the reply<br/>
        /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
        /// </param>
        /// <param name="response"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatStreamEndEvent(
            global::G.ChatStreamEndEventVariant2FinishReason finishReason,
            global::G.NonStreamedChatResponse response)
        {
            this.FinishReason = finishReason;
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEndEvent" /> class.
        /// </summary>
        public ChatStreamEndEvent()
        {
        }
    }
}