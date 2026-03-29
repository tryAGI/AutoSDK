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
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_flow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationFlowId { get; set; }

        /// <summary>
        /// Version number of the conversation flow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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