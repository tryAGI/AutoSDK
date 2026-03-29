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
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_flow_component_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationFlowComponentId { get; set; }

        /// <summary>
        /// Timestamp of last user modification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// IDs of conversation flows linked to this shared component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_conversation_flow_ids")]
        public global::System.Collections.Generic.IList<string>? LinkedConversationFlowIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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