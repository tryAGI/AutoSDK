//HintName: G.Models.LettaStreamingResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaStreamingResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeJsonConverter))]
        public global::G.LettaStreamingResponseDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaStreamingResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        public LettaStreamingResponseDiscriminator(
            global::G.LettaStreamingResponseDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaStreamingResponseDiscriminator" /> class.
        /// </summary>
        public LettaStreamingResponseDiscriminator()
        {
        }
    }
}