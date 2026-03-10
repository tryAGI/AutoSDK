//HintName: G.Models.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost
    {
        /// <summary>
        /// Conversation config for the draft
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ConversationConfig { get; set; }

        /// <summary>
        /// Platform settings for the draft
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object PlatformSettings { get; set; }

        /// <summary>
        /// Workflow for the draft<br/>
        /// Example: {"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer"},{"prompt":"Phone condition"},{"left":{"name":"mode"},"right":{"value":"dev"}}]}},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry"},"failure_node":{"conversation_config":{},"label":"Failure"},"start_node":{"edge_order":["start_to_entry"]},"success_conversation":{"conversation_config":{},"label":"Success A"},"success_end":{},"success_phone":{"transfer_destination":{"phone_number":"\u002B1234567890"}},"success_transfer":{"agent_id":"success_transfer_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}]},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"tools":[{"tool_id":"tool_a"}]}}}
        /// </summary>
        /// <example>{"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer"},{"prompt":"Phone condition"},{"left":{"name":"mode"},"right":{"value":"dev"}}]}},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry"},"failure_node":{"conversation_config":{},"label":"Failure"},"start_node":{"edge_order":["start_to_entry"]},"success_conversation":{"conversation_config":{},"label":"Success A"},"success_end":{},"success_phone":{"transfer_destination":{"phone_number":"\u002B1234567890"}},"success_transfer":{"agent_id":"success_transfer_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}]},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"tools":[{"tool_id":"tool_a"}]}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentWorkflowRequestModel Workflow { get; set; }

        /// <summary>
        /// Name for the draft
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tags to help classify and filter the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost" /> class.
        /// </summary>
        /// <param name="conversationConfig">
        /// Conversation config for the draft
        /// </param>
        /// <param name="platformSettings">
        /// Platform settings for the draft
        /// </param>
        /// <param name="workflow">
        /// Workflow for the draft<br/>
        /// Example: {"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer"},{"prompt":"Phone condition"},{"left":{"name":"mode"},"right":{"value":"dev"}}]}},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry"},"failure_node":{"conversation_config":{},"label":"Failure"},"start_node":{"edge_order":["start_to_entry"]},"success_conversation":{"conversation_config":{},"label":"Success A"},"success_end":{},"success_phone":{"transfer_destination":{"phone_number":"\u002B1234567890"}},"success_transfer":{"agent_id":"success_transfer_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}]},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"tools":[{"tool_id":"tool_a"}]}}}
        /// </param>
        /// <param name="name">
        /// Name for the draft
        /// </param>
        /// <param name="tags">
        /// Tags to help classify and filter the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost(
            object conversationConfig,
            object platformSettings,
            global::G.AgentWorkflowRequestModel workflow,
            string name,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.PlatformSettings = platformSettings ?? throw new global::System.ArgumentNullException(nameof(platformSettings));
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost" /> class.
        /// </summary>
        public BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost()
        {
        }
    }
}