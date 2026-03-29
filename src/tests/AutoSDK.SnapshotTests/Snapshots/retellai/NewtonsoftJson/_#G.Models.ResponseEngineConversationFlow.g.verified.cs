//HintName: G.Models.ResponseEngineConversationFlow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseEngineConversationFlow
    {
        /// <summary>
        /// type of the Response Engine.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseEngineConversationFlowType Type { get; set; }

        /// <summary>
        /// ID of the Conversation Flow Response Engine.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_flow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationFlowId { get; set; } = default!;

        /// <summary>
        /// Version of the Conversation Flow Response Engine.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public double? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineConversationFlow" /> class.
        /// </summary>
        /// <param name="conversationFlowId">
        /// ID of the Conversation Flow Response Engine.
        /// </param>
        /// <param name="type">
        /// type of the Response Engine.
        /// </param>
        /// <param name="version">
        /// Version of the Conversation Flow Response Engine.<br/>
        /// Example: 0
        /// </param>
        public ResponseEngineConversationFlow(
            string conversationFlowId,
            global::G.ResponseEngineConversationFlowType type,
            double? version)
        {
            this.Type = type;
            this.ConversationFlowId = conversationFlowId ?? throw new global::System.ArgumentNullException(nameof(conversationFlowId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineConversationFlow" /> class.
        /// </summary>
        public ResponseEngineConversationFlow()
        {
        }
    }
}