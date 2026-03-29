//HintName: G.Models.ConversationFlowResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationFlowResponseVariant2
    {
        /// <summary>
        /// Unique identifier for the conversation flow
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_flow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationFlowId { get; set; } = default!;

        /// <summary>
        /// Version number of the conversation flow
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowResponseVariant2" /> class.
        /// </summary>
        /// <param name="conversationFlowId">
        /// Unique identifier for the conversation flow
        /// </param>
        /// <param name="version">
        /// Version number of the conversation flow
        /// </param>
        public ConversationFlowResponseVariant2(
            string conversationFlowId,
            int version)
        {
            this.ConversationFlowId = conversationFlowId ?? throw new global::System.ArgumentNullException(nameof(conversationFlowId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowResponseVariant2" /> class.
        /// </summary>
        public ConversationFlowResponseVariant2()
        {
        }
    }
}