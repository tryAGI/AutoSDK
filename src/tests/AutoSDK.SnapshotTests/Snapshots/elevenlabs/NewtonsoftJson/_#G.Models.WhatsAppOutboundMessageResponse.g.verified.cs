//HintName: G.Models.WhatsAppOutboundMessageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppOutboundMessageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppOutboundMessageResponse" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        public WhatsAppOutboundMessageResponse(
            string conversationId)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppOutboundMessageResponse" /> class.
        /// </summary>
        public WhatsAppOutboundMessageResponse()
        {
        }
    }
}