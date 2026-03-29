//HintName: G.Models.CallbackLiveEndSessionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackLiveEndSessionMessage
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Default Value: live.end_session<br/>
        /// Example: live.end_session
        /// </summary>
        /// <default>global::G.CallbackLiveEndSessionMessageEvent.LiveEndSession</default>
        /// <example>live.end_session</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.CallbackLiveEndSessionMessageEvent Event { get; set; } = global::G.CallbackLiveEndSessionMessageEvent.LiveEndSession;

        /// <summary>
        /// The live message payload as sent to the WebSocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EndSessionMessage Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveEndSessionMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="payload">
        /// The live message payload as sent to the WebSocket
        /// </param>
        /// <param name="event">
        /// Default Value: live.end_session<br/>
        /// Example: live.end_session
        /// </param>
        public CallbackLiveEndSessionMessage(
            global::System.Guid id,
            global::G.EndSessionMessage payload,
            global::G.CallbackLiveEndSessionMessageEvent @event = global::G.CallbackLiveEndSessionMessageEvent.LiveEndSession)
        {
            this.Id = id;
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveEndSessionMessage" /> class.
        /// </summary>
        public CallbackLiveEndSessionMessage()
        {
        }
    }
}