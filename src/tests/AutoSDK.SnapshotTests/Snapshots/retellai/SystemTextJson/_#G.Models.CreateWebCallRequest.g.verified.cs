//HintName: G.Models.CreateWebCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebCallRequest
    {
        /// <summary>
        /// Unique id of agent used for the call. Your agent would contain the LLM Websocket url used for this call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The version of the agent to use for the call.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        public int? AgentVersion { get; set; }

        /// <summary>
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_override")]
        public global::G.AgentOverrideRequest? AgentOverride { get; set; }

        /// <summary>
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </summary>
        /// <example>{"customer_name":"John Doe"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retell_llm_dynamic_variables")]
        public object? RetellLlmDynamicVariables { get; set; }

        /// <summary>
        /// Start the call at this conversation flow node (stage). Must be a valid node id in the agent's conversation flow. Only applicable when the agent uses conversation flow as the response engine. Ignored for retell-llm agents.<br/>
        /// Example: collect_info
        /// </summary>
        /// <example>collect_info</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_node_id")]
        public string? CurrentNodeId { get; set; }

        /// <summary>
        /// Start the conversation in this state (stage). Must be a valid state name in the agent's Retell LLM. Only applicable when the agent uses Retell LLM with states. Ignored for conversation-flow agents.<br/>
        /// Example: information_collection
        /// </summary>
        /// <example>information_collection</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_state")]
        public string? CurrentState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebCallRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique id of agent used for the call. Your agent would contain the LLM Websocket url used for this call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="agentVersion">
        /// The version of the agent to use for the call.<br/>
        /// Example: 1
        /// </param>
        /// <param name="agentOverride">
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        /// <param name="currentNodeId">
        /// Start the call at this conversation flow node (stage). Must be a valid node id in the agent's conversation flow. Only applicable when the agent uses conversation flow as the response engine. Ignored for retell-llm agents.<br/>
        /// Example: collect_info
        /// </param>
        /// <param name="currentState">
        /// Start the conversation in this state (stage). Must be a valid state name in the agent's Retell LLM. Only applicable when the agent uses Retell LLM with states. Ignored for conversation-flow agents.<br/>
        /// Example: information_collection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebCallRequest(
            string agentId,
            int? agentVersion,
            global::G.AgentOverrideRequest? agentOverride,
            object? metadata,
            object? retellLlmDynamicVariables,
            string? currentNodeId,
            string? currentState)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.AgentOverride = agentOverride;
            this.Metadata = metadata;
            this.RetellLlmDynamicVariables = retellLlmDynamicVariables;
            this.CurrentNodeId = currentNodeId;
            this.CurrentState = currentState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebCallRequest" /> class.
        /// </summary>
        public CreateWebCallRequest()
        {
        }
    }
}