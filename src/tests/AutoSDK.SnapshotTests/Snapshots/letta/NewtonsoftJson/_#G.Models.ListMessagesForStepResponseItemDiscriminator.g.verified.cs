//HintName: G.Models.ListMessagesForStepResponseItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMessagesForStepResponseItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeJsonConverter))]
        public global::G.ListMessagesForStepResponseItemDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessagesForStepResponseItemDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        public ListMessagesForStepResponseItemDiscriminator(
            global::G.ListMessagesForStepResponseItemDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessagesForStepResponseItemDiscriminator" /> class.
        /// </summary>
        public ListMessagesForStepResponseItemDiscriminator()
        {
        }
    }
}