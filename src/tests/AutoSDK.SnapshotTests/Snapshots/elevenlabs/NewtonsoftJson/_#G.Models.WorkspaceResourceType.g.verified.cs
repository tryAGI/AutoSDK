//HintName: G.Models.WorkspaceResourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resource types that can be shared in the workspace. The name always need to match the collection names
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkspaceResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice")]
        Voice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_collection")]
        VoiceCollection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pronunciation_dictionary")]
        PronunciationDictionary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing")]
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agents")]
        ConvaiAgents,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_knowledge_base_documents")]
        ConvaiKnowledgeBaseDocuments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_tools")]
        ConvaiTools,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_settings")]
        ConvaiSettings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_secrets")]
        ConvaiSecrets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_auth_connections")]
        WorkspaceAuthConnections,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_phone_numbers")]
        ConvaiPhoneNumbers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_mcp_servers")]
        ConvaiMcpServers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_api_integration_connections")]
        ConvaiApiIntegrationConnections,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_api_integration_trigger_connections")]
        ConvaiApiIntegrationTriggerConnections,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_batch_calls")]
        ConvaiBatchCalls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_response_tests")]
        ConvaiAgentResponseTests,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_test_suite_invocations")]
        ConvaiTestSuiteInvocations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_crawl_jobs")]
        ConvaiCrawlJobs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_crawl_tasks")]
        ConvaiCrawlTasks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_whatsapp_accounts")]
        ConvaiWhatsappAccounts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_versions")]
        ConvaiAgentVersions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_branches")]
        ConvaiAgentBranches,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_versions_deployments")]
        ConvaiAgentVersionsDeployments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_memory_entries")]
        ConvaiMemoryEntries,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_coaching_proposals")]
        ConvaiCoachingProposals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dashboard")]
        Dashboard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dashboard_configuration")]
        DashboardConfiguration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_drafts")]
        ConvaiAgentDrafts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resource_locators")]
        ResourceLocators,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assets")]
        Assets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_generations")]
        ContentGenerations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_templates")]
        ContentTemplates,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="songs")]
        Songs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceResourceType value)
        {
            return value switch
            {
                WorkspaceResourceType.Voice => "voice",
                WorkspaceResourceType.VoiceCollection => "voice_collection",
                WorkspaceResourceType.PronunciationDictionary => "pronunciation_dictionary",
                WorkspaceResourceType.Dubbing => "dubbing",
                WorkspaceResourceType.Project => "project",
                WorkspaceResourceType.ConvaiAgents => "convai_agents",
                WorkspaceResourceType.ConvaiKnowledgeBaseDocuments => "convai_knowledge_base_documents",
                WorkspaceResourceType.ConvaiTools => "convai_tools",
                WorkspaceResourceType.ConvaiSettings => "convai_settings",
                WorkspaceResourceType.ConvaiSecrets => "convai_secrets",
                WorkspaceResourceType.WorkspaceAuthConnections => "workspace_auth_connections",
                WorkspaceResourceType.ConvaiPhoneNumbers => "convai_phone_numbers",
                WorkspaceResourceType.ConvaiMcpServers => "convai_mcp_servers",
                WorkspaceResourceType.ConvaiApiIntegrationConnections => "convai_api_integration_connections",
                WorkspaceResourceType.ConvaiApiIntegrationTriggerConnections => "convai_api_integration_trigger_connections",
                WorkspaceResourceType.ConvaiBatchCalls => "convai_batch_calls",
                WorkspaceResourceType.ConvaiAgentResponseTests => "convai_agent_response_tests",
                WorkspaceResourceType.ConvaiTestSuiteInvocations => "convai_test_suite_invocations",
                WorkspaceResourceType.ConvaiCrawlJobs => "convai_crawl_jobs",
                WorkspaceResourceType.ConvaiCrawlTasks => "convai_crawl_tasks",
                WorkspaceResourceType.ConvaiWhatsappAccounts => "convai_whatsapp_accounts",
                WorkspaceResourceType.ConvaiAgentVersions => "convai_agent_versions",
                WorkspaceResourceType.ConvaiAgentBranches => "convai_agent_branches",
                WorkspaceResourceType.ConvaiAgentVersionsDeployments => "convai_agent_versions_deployments",
                WorkspaceResourceType.ConvaiMemoryEntries => "convai_memory_entries",
                WorkspaceResourceType.ConvaiCoachingProposals => "convai_coaching_proposals",
                WorkspaceResourceType.Dashboard => "dashboard",
                WorkspaceResourceType.DashboardConfiguration => "dashboard_configuration",
                WorkspaceResourceType.ConvaiAgentDrafts => "convai_agent_drafts",
                WorkspaceResourceType.ResourceLocators => "resource_locators",
                WorkspaceResourceType.Assets => "assets",
                WorkspaceResourceType.ContentGenerations => "content_generations",
                WorkspaceResourceType.ContentTemplates => "content_templates",
                WorkspaceResourceType.Songs => "songs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => WorkspaceResourceType.Voice,
                "voice_collection" => WorkspaceResourceType.VoiceCollection,
                "pronunciation_dictionary" => WorkspaceResourceType.PronunciationDictionary,
                "dubbing" => WorkspaceResourceType.Dubbing,
                "project" => WorkspaceResourceType.Project,
                "convai_agents" => WorkspaceResourceType.ConvaiAgents,
                "convai_knowledge_base_documents" => WorkspaceResourceType.ConvaiKnowledgeBaseDocuments,
                "convai_tools" => WorkspaceResourceType.ConvaiTools,
                "convai_settings" => WorkspaceResourceType.ConvaiSettings,
                "convai_secrets" => WorkspaceResourceType.ConvaiSecrets,
                "workspace_auth_connections" => WorkspaceResourceType.WorkspaceAuthConnections,
                "convai_phone_numbers" => WorkspaceResourceType.ConvaiPhoneNumbers,
                "convai_mcp_servers" => WorkspaceResourceType.ConvaiMcpServers,
                "convai_api_integration_connections" => WorkspaceResourceType.ConvaiApiIntegrationConnections,
                "convai_api_integration_trigger_connections" => WorkspaceResourceType.ConvaiApiIntegrationTriggerConnections,
                "convai_batch_calls" => WorkspaceResourceType.ConvaiBatchCalls,
                "convai_agent_response_tests" => WorkspaceResourceType.ConvaiAgentResponseTests,
                "convai_test_suite_invocations" => WorkspaceResourceType.ConvaiTestSuiteInvocations,
                "convai_crawl_jobs" => WorkspaceResourceType.ConvaiCrawlJobs,
                "convai_crawl_tasks" => WorkspaceResourceType.ConvaiCrawlTasks,
                "convai_whatsapp_accounts" => WorkspaceResourceType.ConvaiWhatsappAccounts,
                "convai_agent_versions" => WorkspaceResourceType.ConvaiAgentVersions,
                "convai_agent_branches" => WorkspaceResourceType.ConvaiAgentBranches,
                "convai_agent_versions_deployments" => WorkspaceResourceType.ConvaiAgentVersionsDeployments,
                "convai_memory_entries" => WorkspaceResourceType.ConvaiMemoryEntries,
                "convai_coaching_proposals" => WorkspaceResourceType.ConvaiCoachingProposals,
                "dashboard" => WorkspaceResourceType.Dashboard,
                "dashboard_configuration" => WorkspaceResourceType.DashboardConfiguration,
                "convai_agent_drafts" => WorkspaceResourceType.ConvaiAgentDrafts,
                "resource_locators" => WorkspaceResourceType.ResourceLocators,
                "assets" => WorkspaceResourceType.Assets,
                "content_generations" => WorkspaceResourceType.ContentGenerations,
                "content_templates" => WorkspaceResourceType.ContentTemplates,
                "songs" => WorkspaceResourceType.Songs,
                _ => null,
            };
        }
    }
}