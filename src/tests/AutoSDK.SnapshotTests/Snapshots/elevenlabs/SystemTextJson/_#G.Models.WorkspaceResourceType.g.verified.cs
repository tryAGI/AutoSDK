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
        ConvaiAgentBranches,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentDrafts,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentResponseTests,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentVersions,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentVersionsDeployments,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgents,
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
        ConvaiCoachingProposals,
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
        ConvaiKnowledgeBaseDocuments,
        /// <summary>
        /// 
        /// </summary>
        ConvaiMcpServers,
        /// <summary>
        /// 
        /// </summary>
        ConvaiMemoryEntries,
        /// <summary>
        /// 
        /// </summary>
        ConvaiPhoneNumbers,
        /// <summary>
        /// 
        /// </summary>
        ConvaiSecrets,
        /// <summary>
        /// 
        /// </summary>
        ConvaiSettings,
        /// <summary>
        /// 
        /// </summary>
        ConvaiTestSuiteInvocations,
        /// <summary>
        /// 
        /// </summary>
        ConvaiTools,
        /// <summary>
        /// 
        /// </summary>
        ConvaiWhatsappAccounts,
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
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionary,
        /// <summary>
        /// 
        /// </summary>
        ResourceLocators,
        /// <summary>
        /// 
        /// </summary>
        Songs,
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
        WorkspaceAuthConnections,
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
                WorkspaceResourceType.Assets => "assets",
                WorkspaceResourceType.ContentGenerations => "content_generations",
                WorkspaceResourceType.ContentTemplates => "content_templates",
                WorkspaceResourceType.ConvaiAgentBranches => "convai_agent_branches",
                WorkspaceResourceType.ConvaiAgentDrafts => "convai_agent_drafts",
                WorkspaceResourceType.ConvaiAgentResponseTests => "convai_agent_response_tests",
                WorkspaceResourceType.ConvaiAgentVersions => "convai_agent_versions",
                WorkspaceResourceType.ConvaiAgentVersionsDeployments => "convai_agent_versions_deployments",
                WorkspaceResourceType.ConvaiAgents => "convai_agents",
                WorkspaceResourceType.ConvaiApiIntegrationConnections => "convai_api_integration_connections",
                WorkspaceResourceType.ConvaiApiIntegrationTriggerConnections => "convai_api_integration_trigger_connections",
                WorkspaceResourceType.ConvaiBatchCalls => "convai_batch_calls",
                WorkspaceResourceType.ConvaiCoachingProposals => "convai_coaching_proposals",
                WorkspaceResourceType.ConvaiCrawlJobs => "convai_crawl_jobs",
                WorkspaceResourceType.ConvaiCrawlTasks => "convai_crawl_tasks",
                WorkspaceResourceType.ConvaiKnowledgeBaseDocuments => "convai_knowledge_base_documents",
                WorkspaceResourceType.ConvaiMcpServers => "convai_mcp_servers",
                WorkspaceResourceType.ConvaiMemoryEntries => "convai_memory_entries",
                WorkspaceResourceType.ConvaiPhoneNumbers => "convai_phone_numbers",
                WorkspaceResourceType.ConvaiSecrets => "convai_secrets",
                WorkspaceResourceType.ConvaiSettings => "convai_settings",
                WorkspaceResourceType.ConvaiTestSuiteInvocations => "convai_test_suite_invocations",
                WorkspaceResourceType.ConvaiTools => "convai_tools",
                WorkspaceResourceType.ConvaiWhatsappAccounts => "convai_whatsapp_accounts",
                WorkspaceResourceType.Dashboard => "dashboard",
                WorkspaceResourceType.DashboardConfiguration => "dashboard_configuration",
                WorkspaceResourceType.Dubbing => "dubbing",
                WorkspaceResourceType.Project => "project",
                WorkspaceResourceType.PronunciationDictionary => "pronunciation_dictionary",
                WorkspaceResourceType.ResourceLocators => "resource_locators",
                WorkspaceResourceType.Songs => "songs",
                WorkspaceResourceType.Voice => "voice",
                WorkspaceResourceType.VoiceCollection => "voice_collection",
                WorkspaceResourceType.WorkspaceAuthConnections => "workspace_auth_connections",
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
                "assets" => WorkspaceResourceType.Assets,
                "content_generations" => WorkspaceResourceType.ContentGenerations,
                "content_templates" => WorkspaceResourceType.ContentTemplates,
                "convai_agent_branches" => WorkspaceResourceType.ConvaiAgentBranches,
                "convai_agent_drafts" => WorkspaceResourceType.ConvaiAgentDrafts,
                "convai_agent_response_tests" => WorkspaceResourceType.ConvaiAgentResponseTests,
                "convai_agent_versions" => WorkspaceResourceType.ConvaiAgentVersions,
                "convai_agent_versions_deployments" => WorkspaceResourceType.ConvaiAgentVersionsDeployments,
                "convai_agents" => WorkspaceResourceType.ConvaiAgents,
                "convai_api_integration_connections" => WorkspaceResourceType.ConvaiApiIntegrationConnections,
                "convai_api_integration_trigger_connections" => WorkspaceResourceType.ConvaiApiIntegrationTriggerConnections,
                "convai_batch_calls" => WorkspaceResourceType.ConvaiBatchCalls,
                "convai_coaching_proposals" => WorkspaceResourceType.ConvaiCoachingProposals,
                "convai_crawl_jobs" => WorkspaceResourceType.ConvaiCrawlJobs,
                "convai_crawl_tasks" => WorkspaceResourceType.ConvaiCrawlTasks,
                "convai_knowledge_base_documents" => WorkspaceResourceType.ConvaiKnowledgeBaseDocuments,
                "convai_mcp_servers" => WorkspaceResourceType.ConvaiMcpServers,
                "convai_memory_entries" => WorkspaceResourceType.ConvaiMemoryEntries,
                "convai_phone_numbers" => WorkspaceResourceType.ConvaiPhoneNumbers,
                "convai_secrets" => WorkspaceResourceType.ConvaiSecrets,
                "convai_settings" => WorkspaceResourceType.ConvaiSettings,
                "convai_test_suite_invocations" => WorkspaceResourceType.ConvaiTestSuiteInvocations,
                "convai_tools" => WorkspaceResourceType.ConvaiTools,
                "convai_whatsapp_accounts" => WorkspaceResourceType.ConvaiWhatsappAccounts,
                "dashboard" => WorkspaceResourceType.Dashboard,
                "dashboard_configuration" => WorkspaceResourceType.DashboardConfiguration,
                "dubbing" => WorkspaceResourceType.Dubbing,
                "project" => WorkspaceResourceType.Project,
                "pronunciation_dictionary" => WorkspaceResourceType.PronunciationDictionary,
                "resource_locators" => WorkspaceResourceType.ResourceLocators,
                "songs" => WorkspaceResourceType.Songs,
                "voice" => WorkspaceResourceType.Voice,
                "voice_collection" => WorkspaceResourceType.VoiceCollection,
                "workspace_auth_connections" => WorkspaceResourceType.WorkspaceAuthConnections,
                _ => null,
            };
        }
    }
}