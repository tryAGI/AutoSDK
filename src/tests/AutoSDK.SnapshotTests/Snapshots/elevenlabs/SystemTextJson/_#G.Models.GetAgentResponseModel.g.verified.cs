//HintName: G.Models.GetAgentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent_id":"agent_7101k5zvyjhmfg983brhmhkd98n6","name":"My Agent","workflow":{"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition","type":"llm"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{"type":"unconditional"},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false,"type":"result"},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true,"type":"result"},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{"type":"unconditional"},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition","type":"llm"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition","type":"llm"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer","type":"dynamic_variable"},{"prompt":"Phone condition","type":"llm"},{"left":{"name":"mode","type":"dynamic_variable"},"right":{"type":"string_literal","value":"dev"},"type":"eq_operator"}],"type":"or_operator"},"type":"expression"},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry","position":{"x":0.0,"y":0.0},"type":"override_agent"},"failure_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Failure","position":{"x":0.0,"y":0.0},"type":"override_agent"},"start_node":{"edge_order":["start_to_entry"],"position":{"x":0.0,"y":0.0},"type":"start"},"success_conversation":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Success A","position":{"x":0.0,"y":0.0},"type":"override_agent"},"success_end":{"edge_order":[],"position":{"x":0.0,"y":0.0},"type":"end"},"success_phone":{"custom_sip_headers":[],"edge_order":[],"position":{"x":0.0,"y":0.0},"transfer_destination":{"phone_number":"\u002B1234567890","type":"phone"},"transfer_type":"conference","type":"phone_number"},"success_transfer":{"agent_id":"success_transfer_agent","delay_ms":0,"edge_order":[],"enable_transferred_agent_first_message":false,"position":{"x":0.0,"y":0.0},"type":"standalone_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}],"type":"tool"},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"}],"type":"tool"}},"prevent_subagent_loops":false}}
    /// </summary>
    public sealed partial class GetAgentResponseModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The conversation configuration of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationalConfigAPIModelOutput ConversationConfig { get; set; }

        /// <summary>
        /// The metadata of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentMetadataResponseModel Metadata { get; set; }

        /// <summary>
        /// The platform settings of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_settings")]
        public global::G.AgentPlatformSettingsResponseModel? PlatformSettings { get; set; }

        /// <summary>
        /// The phone numbers of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public global::System.Collections.Generic.IList<global::G.PhoneNumbersItem>? PhoneNumbers { get; set; }

        /// <summary>
        /// WhatsApp accounts assigned to the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_accounts")]
        public global::System.Collections.Generic.IList<global::G.GetWhatsAppAccountResponse>? WhatsappAccounts { get; set; }

        /// <summary>
        /// The workflow of the agent<br/>
        /// Example: {"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition","type":"llm"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{"type":"unconditional"},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false,"type":"result"},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true,"type":"result"},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{"type":"unconditional"},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition","type":"llm"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition","type":"llm"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer","type":"dynamic_variable"},{"prompt":"Phone condition","type":"llm"},{"left":{"name":"mode","type":"dynamic_variable"},"right":{"type":"string_literal","value":"dev"},"type":"eq_operator"}],"type":"or_operator"},"type":"expression"},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry","position":{"x":0.0,"y":0.0},"type":"override_agent"},"failure_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Failure","position":{"x":0.0,"y":0.0},"type":"override_agent"},"start_node":{"edge_order":["start_to_entry"],"position":{"x":0.0,"y":0.0},"type":"start"},"success_conversation":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Success A","position":{"x":0.0,"y":0.0},"type":"override_agent"},"success_end":{"edge_order":[],"position":{"x":0.0,"y":0.0},"type":"end"},"success_phone":{"custom_sip_headers":[],"edge_order":[],"position":{"x":0.0,"y":0.0},"transfer_destination":{"phone_number":"\u002B1234567890","type":"phone"},"transfer_type":"conference","type":"phone_number"},"success_transfer":{"agent_id":"success_transfer_agent","delay_ms":0,"edge_order":[],"enable_transferred_agent_first_message":false,"position":{"x":0.0,"y":0.0},"type":"standalone_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}],"type":"tool"},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"}],"type":"tool"}},"prevent_subagent_loops":false}
        /// </summary>
        /// <example>{"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition","type":"llm"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{"type":"unconditional"},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false,"type":"result"},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true,"type":"result"},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{"type":"unconditional"},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition","type":"llm"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition","type":"llm"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer","type":"dynamic_variable"},{"prompt":"Phone condition","type":"llm"},{"left":{"name":"mode","type":"dynamic_variable"},"right":{"type":"string_literal","value":"dev"},"type":"eq_operator"}],"type":"or_operator"},"type":"expression"},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry","position":{"x":0.0,"y":0.0},"type":"override_agent"},"failure_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Failure","position":{"x":0.0,"y":0.0},"type":"override_agent"},"start_node":{"edge_order":["start_to_entry"],"position":{"x":0.0,"y":0.0},"type":"start"},"success_conversation":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Success A","position":{"x":0.0,"y":0.0},"type":"override_agent"},"success_end":{"edge_order":[],"position":{"x":0.0,"y":0.0},"type":"end"},"success_phone":{"custom_sip_headers":[],"edge_order":[],"position":{"x":0.0,"y":0.0},"transfer_destination":{"phone_number":"\u002B1234567890","type":"phone"},"transfer_type":"conference","type":"phone_number"},"success_transfer":{"agent_id":"success_transfer_agent","delay_ms":0,"edge_order":[],"enable_transferred_agent_first_message":false,"position":{"x":0.0,"y":0.0},"type":"standalone_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}],"type":"tool"},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"}],"type":"tool"}},"prevent_subagent_loops":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::G.AgentWorkflowResponseModel? Workflow { get; set; }

        /// <summary>
        /// The access information of the agent for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Agent tags used to categorize the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The ID of the version the agent is on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// The ID of the branch the agent is on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The ID of the main branch for this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_branch_id")]
        public string? MainBranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="name">
        /// The name of the agent
        /// </param>
        /// <param name="conversationConfig">
        /// The conversation configuration of the agent
        /// </param>
        /// <param name="metadata">
        /// The metadata of the agent
        /// </param>
        /// <param name="platformSettings">
        /// The platform settings of the agent
        /// </param>
        /// <param name="phoneNumbers">
        /// The phone numbers of the agent
        /// </param>
        /// <param name="whatsappAccounts">
        /// WhatsApp accounts assigned to the agent
        /// </param>
        /// <param name="workflow">
        /// The workflow of the agent<br/>
        /// Example: {"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition","type":"llm"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{"type":"unconditional"},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false,"type":"result"},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true,"type":"result"},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{"type":"unconditional"},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition","type":"llm"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition","type":"llm"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer","type":"dynamic_variable"},{"prompt":"Phone condition","type":"llm"},{"left":{"name":"mode","type":"dynamic_variable"},"right":{"type":"string_literal","value":"dev"},"type":"eq_operator"}],"type":"or_operator"},"type":"expression"},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry","position":{"x":0.0,"y":0.0},"type":"override_agent"},"failure_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Failure","position":{"x":0.0,"y":0.0},"type":"override_agent"},"start_node":{"edge_order":["start_to_entry"],"position":{"x":0.0,"y":0.0},"type":"start"},"success_conversation":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Success A","position":{"x":0.0,"y":0.0},"type":"override_agent"},"success_end":{"edge_order":[],"position":{"x":0.0,"y":0.0},"type":"end"},"success_phone":{"custom_sip_headers":[],"edge_order":[],"position":{"x":0.0,"y":0.0},"transfer_destination":{"phone_number":"\u002B1234567890","type":"phone"},"transfer_type":"conference","type":"phone_number"},"success_transfer":{"agent_id":"success_transfer_agent","delay_ms":0,"edge_order":[],"enable_transferred_agent_first_message":false,"position":{"x":0.0,"y":0.0},"type":"standalone_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}],"type":"tool"},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"}],"type":"tool"}},"prevent_subagent_loops":false}
        /// </param>
        /// <param name="accessInfo">
        /// The access information of the agent for the user
        /// </param>
        /// <param name="tags">
        /// Agent tags used to categorize the agent
        /// </param>
        /// <param name="versionId">
        /// The ID of the version the agent is on
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch the agent is on
        /// </param>
        /// <param name="mainBranchId">
        /// The ID of the main branch for this agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentResponseModel(
            string agentId,
            string name,
            global::G.ConversationalConfigAPIModelOutput conversationConfig,
            global::G.AgentMetadataResponseModel metadata,
            global::G.AgentPlatformSettingsResponseModel? platformSettings,
            global::System.Collections.Generic.IList<global::G.PhoneNumbersItem>? phoneNumbers,
            global::System.Collections.Generic.IList<global::G.GetWhatsAppAccountResponse>? whatsappAccounts,
            global::G.AgentWorkflowResponseModel? workflow,
            global::G.ResourceAccessInfo? accessInfo,
            global::System.Collections.Generic.IList<string>? tags,
            string? versionId,
            string? branchId,
            string? mainBranchId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.PlatformSettings = platformSettings;
            this.PhoneNumbers = phoneNumbers;
            this.WhatsappAccounts = whatsappAccounts;
            this.Workflow = workflow;
            this.AccessInfo = accessInfo;
            this.Tags = tags;
            this.VersionId = versionId;
            this.BranchId = branchId;
            this.MainBranchId = mainBranchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        public GetAgentResponseModel()
        {
        }
    }
}