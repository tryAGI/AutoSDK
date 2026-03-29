//HintName: G.Models.CallbackLiveStartSessionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackLiveStartSessionMessage
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Default Value: live.start_session<br/>
        /// Example: live.start_session
        /// </summary>
        /// <default>global::G.CallbackLiveStartSessionMessageEvent.LiveStartSession</default>
        /// <example>live.start_session</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.CallbackLiveStartSessionMessageEvent Event { get; set; } = global::G.CallbackLiveStartSessionMessageEvent.LiveStartSession;

        /// <summary>
        /// The live message payload as sent to the WebSocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StartSessionMessage Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveStartSessionMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="payload">
        /// The live message payload as sent to the WebSocket
        /// </param>
        /// <param name="event">
        /// Default Value: live.start_session<br/>
        /// Example: live.start_session
        /// </param>
        public CallbackLiveStartSessionMessage(
            global::System.Guid id,
            global::G.StartSessionMessage payload,
            global::G.CallbackLiveStartSessionMessageEvent @event = global::G.CallbackLiveStartSessionMessageEvent.LiveStartSession)
        {
            this.Id = id;
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveStartSessionMessage" /> class.
        /// </summary>
        public CallbackLiveStartSessionMessage()
        {
        }
    }
}