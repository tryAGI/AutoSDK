//HintName: G.Models.AgentOverrideRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
    /// </summary>
    public sealed partial class AgentOverrideRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::G.AgentRequest? Agent { get; set; }

        /// <summary>
        /// Override properties for Retell LLM configuration in agent override requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retell_llm")]
        public global::G.RetellLlmOverride? RetellLlm { get; set; }

        /// <summary>
        /// Override properties for conversation flow configuration in agent override requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_flow")]
        public global::G.ConversationFlowOverride? ConversationFlow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideRequest" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="retellLlm">
        /// Override properties for Retell LLM configuration in agent override requests.
        /// </param>
        /// <param name="conversationFlow">
        /// Override properties for conversation flow configuration in agent override requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOverrideRequest(
            global::G.AgentRequest? agent,
            global::G.RetellLlmOverride? retellLlm,
            global::G.ConversationFlowOverride? conversationFlow)
        {
            this.Agent = agent;
            this.RetellLlm = retellLlm;
            this.ConversationFlow = conversationFlow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideRequest" /> class.
        /// </summary>
        public AgentOverrideRequest()
        {
        }
    }
}