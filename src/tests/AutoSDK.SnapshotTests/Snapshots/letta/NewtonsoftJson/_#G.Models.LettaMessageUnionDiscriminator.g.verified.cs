//HintName: G.Models.LettaMessageUnionDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaMessageUnionDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.LettaMessageUnionDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaMessageUnionDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        public LettaMessageUnionDiscriminator(
            global::G.LettaMessageUnionDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaMessageUnionDiscriminator" /> class.
        /// </summary>
        public LettaMessageUnionDiscriminator()
        {
        }
    }
}