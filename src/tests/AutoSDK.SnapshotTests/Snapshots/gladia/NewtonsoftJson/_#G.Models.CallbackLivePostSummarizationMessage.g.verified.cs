//HintName: G.Models.CallbackLivePostSummarizationMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackLivePostSummarizationMessage
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Default Value: live.post_summarization<br/>
        /// Example: live.post_summarization
        /// </summary>
        /// <default>global::G.CallbackLivePostSummarizationMessageEvent.LivePostSummarization</default>
        /// <example>live.post_summarization</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.CallbackLivePostSummarizationMessageEvent Event { get; set; } = global::G.CallbackLivePostSummarizationMessageEvent.LivePostSummarization;

        /// <summary>
        /// The live message payload as sent to the WebSocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostSummarizationMessage Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLivePostSummarizationMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="payload">
        /// The live message payload as sent to the WebSocket
        /// </param>
        /// <param name="event">
        /// Default Value: live.post_summarization<br/>
        /// Example: live.post_summarization
        /// </param>
        public CallbackLivePostSummarizationMessage(
            global::System.Guid id,
            global::G.PostSummarizationMessage payload,
            global::G.CallbackLivePostSummarizationMessageEvent @event = global::G.CallbackLivePostSummarizationMessageEvent.LivePostSummarization)
        {
            this.Id = id;
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLivePostSummarizationMessage" /> class.
        /// </summary>
        public CallbackLivePostSummarizationMessage()
        {
        }
    }
}