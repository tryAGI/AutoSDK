//HintName: G.Models.ConversationFlowComponentResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationFlowComponentResponseVariant2
    {
        /// <summary>
        /// Unique identifier for the component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_flow_component_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationFlowComponentId { get; set; } = default!;

        /// <summary>
        /// Timestamp of last user modification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_modified_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long UserModifiedTimestamp { get; set; } = default!;

        /// <summary>
        /// IDs of conversation flows linked to this shared component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linked_conversation_flow_ids")]
        public global::System.Collections.Generic.IList<string>? LinkedConversationFlowIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowComponentResponseVariant2" /> class.
        /// </summary>
        /// <param name="conversationFlowComponentId">
        /// Unique identifier for the component
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// Timestamp of last user modification
        /// </param>
        /// <param name="linkedConversationFlowIds">
        /// IDs of conversation flows linked to this shared component
        /// </param>
        public ConversationFlowComponentResponseVariant2(
            string conversationFlowComponentId,
            long userModifiedTimestamp,
            global::System.Collections.Generic.IList<string>? linkedConversationFlowIds)
        {
            this.ConversationFlowComponentId = conversationFlowComponentId ?? throw new global::System.ArgumentNullException(nameof(conversationFlowComponentId));
            this.UserModifiedTimestamp = userModifiedTimestamp;
            this.LinkedConversationFlowIds = linkedConversationFlowIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowComponentResponseVariant2" /> class.
        /// </summary>
        public ConversationFlowComponentResponseVariant2()
        {
        }
    }
}