//HintName: G.Models.CallbackLiveTranslationMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackLiveTranslationMessage
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Default Value: live.translation<br/>
        /// Example: live.translation
        /// </summary>
        /// <default>global::G.CallbackLiveTranslationMessageEvent.LiveTranslation</default>
        /// <example>live.translation</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CallbackLiveTranslationMessageEventJsonConverter))]
        public global::G.CallbackLiveTranslationMessageEvent Event { get; set; } = global::G.CallbackLiveTranslationMessageEvent.LiveTranslation;

        /// <summary>
        /// The live message payload as sent to the WebSocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranslationMessage Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveTranslationMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="payload">
        /// The live message payload as sent to the WebSocket
        /// </param>
        /// <param name="event">
        /// Default Value: live.translation<br/>
        /// Example: live.translation
        /// </param>
        public CallbackLiveTranslationMessage(
            global::System.Guid id,
            global::G.TranslationMessage payload,
            global::G.CallbackLiveTranslationMessageEvent @event = global::G.CallbackLiveTranslationMessageEvent.LiveTranslation)
        {
            this.Id = id;
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveTranslationMessage" /> class.
        /// </summary>
        public CallbackLiveTranslationMessage()
        {
        }
    }
}