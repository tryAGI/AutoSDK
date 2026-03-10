//HintName: G.Models.WorkspaceResourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resource types that can be shared in the workspace. The name always need to match the collection names
    /// </summary>
    public enum WorkspaceResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
        /// <summary>
        /// 
        /// </summary>
        VoiceCollection,
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionary,
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgents,
        /// <summary>
        /// 
        /// </summary>
        ConvaiKnowledgeBaseDocuments,
        /// <summary>
        /// 
        /// </summary>
        ConvaiTools,
        /// <summary>
        /// 
        /// </summary>
        ConvaiSettings,
        /// <summary>
        /// 
        /// </summary>
        ConvaiSecrets,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceAuthConnections,
        /// <summary>
        /// 
        /// </summary>
        ConvaiPhoneNumbers,
        /// <summary>
        /// 
        /// </summary>
        ConvaiMcpServers,
        /// <summary>
        /// 
        /// </summary>
        ConvaiApiIntegrationConnections,
        /// <summary>
        /// 
        /// </summary>
        ConvaiApiIntegrationTriggerConnections,
        /// <summary>
        /// 
        /// </summary>
        ConvaiBatchCalls,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentResponseTests,
        /// <summary>
        /// 
        /// </summary>
        ConvaiTestSuiteInvocations,
        /// <summary>
        /// 
        /// </summary>
        ConvaiCrawlJobs,
        /// <summary>
        /// 
        /// </summary>
        ConvaiCrawlTasks,
        /// <summary>
        /// 
        /// </summary>
        ConvaiWhatsappAccounts,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentVersions,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentBranches,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentVersionsDeployments,
        /// <summary>
        /// 
        /// </summary>
        ConvaiMemoryEntries,
        /// <summary>
        /// 
        /// </summary>
        ConvaiCoachingProposals,
        /// <summary>
        /// 
        /// </summary>
        Dashboard,
        /// <summary>
        /// 
        /// </summary>
        DashboardConfiguration,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentDrafts,
        /// <summary>
        /// 
        /// </summary>
        ResourceLocators,
        /// <summary>
        /// 
        /// </summary>
        Assets,
        /// <summary>
        /// 
        /// </summary>
        ContentGenerations,
        /// <summary>
        /// 
        /// </summary>
        ContentTemplates,
        /// <summary>
        /// 
        /// </summary>
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