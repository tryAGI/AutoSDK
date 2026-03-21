//HintName: G.Models.SpeakV1ServerEventDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV1ServerEventDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.SpeakV1ServerEventDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1ServerEventDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        public SpeakV1ServerEventDiscriminator(
            global::G.SpeakV1ServerEventDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1ServerEventDiscriminator" /> class.
        /// </summary>
        public SpeakV1ServerEventDiscriminator()
        {
        }
    }
}