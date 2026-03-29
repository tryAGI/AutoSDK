//HintName: G.Models.CallbackLivePostTranscriptMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackLivePostTranscriptMessage
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Default Value: live.post_transcript<br/>
        /// Example: live.post_transcript
        /// </summary>
        /// <default>global::G.CallbackLivePostTranscriptMessageEvent.LivePostTranscript</default>
        /// <example>live.post_transcript</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallbackLivePostTranscriptMessageEventJsonConverter))]
        public global::G.CallbackLivePostTranscriptMessageEvent Event { get; set; } = global::G.CallbackLivePostTranscriptMessageEvent.LivePostTranscript;

        /// <summary>
        /// The live message payload as sent to the WebSocket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostTranscriptMessage Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLivePostTranscriptMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="payload">
        /// The live message payload as sent to the WebSocket
        /// </param>
        /// <param name="event">
        /// Default Value: live.post_transcript<br/>
        /// Example: live.post_transcript
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackLivePostTranscriptMessage(
            global::System.Guid id,
            global::G.PostTranscriptMessage payload,
            global::G.CallbackLivePostTranscriptMessageEvent @event = global::G.CallbackLivePostTranscriptMessageEvent.LivePostTranscript)
        {
            this.Id = id;
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLivePostTranscriptMessage" /> class.
        /// </summary>
        public CallbackLivePostTranscriptMessage()
        {
        }
    }
}