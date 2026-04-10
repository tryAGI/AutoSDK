//HintName: G.Models.CallbackLiveNamedEntityRecognitionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackLiveNamedEntityRecognitionMessage
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Default Value: live.named_entity_recognition<br/>
        /// Example: live.named_entity_recognition
        /// </summary>
        /// <default>global::G.CallbackLiveNamedEntityRecognitionMessageEvent.LiveNamedEntityRecognition</default>
        /// <example>live.named_entity_recognition</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CallbackLiveNamedEntityRecognitionMessageEventJsonConverter))]
        public global::G.CallbackLiveNamedEntityRecognitionMessageEvent Event { get; set; } = global::G.CallbackLiveNamedEntityRecognitionMessageEvent.LiveNamedEntityRecognition;

        /// <summary>
        /// The live message payload as sent to the WebSocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NamedEntityRecognitionMessage Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveNamedEntityRecognitionMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="payload">
        /// The live message payload as sent to the WebSocket
        /// </param>
        /// <param name="event">
        /// Default Value: live.named_entity_recognition<br/>
        /// Example: live.named_entity_recognition
        /// </param>
        public CallbackLiveNamedEntityRecognitionMessage(
            global::System.Guid id,
            global::G.NamedEntityRecognitionMessage payload,
            global::G.CallbackLiveNamedEntityRecognitionMessageEvent @event = global::G.CallbackLiveNamedEntityRecognitionMessageEvent.LiveNamedEntityRecognition)
        {
            this.Id = id;
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLiveNamedEntityRecognitionMessage" /> class.
        /// </summary>
        public CallbackLiveNamedEntityRecognitionMessage()
        {
        }
    }
}