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
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_branches")]
        ConvaiAgentBranches,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_drafts")]
        ConvaiAgentDrafts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_response_tests")]
        ConvaiAgentResponseTests,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_versions")]
        ConvaiAgentVersions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agent_versions_deployments")]
        ConvaiAgentVersionsDeployments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agents")]
        ConvaiAgents,
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
        [global::System.Runtime.Serialization.EnumMember(Value="convai_coaching_proposals")]
        ConvaiCoachingProposals,
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
        [global::System.Runtime.Serialization.EnumMember(Value="convai_knowledge_base_documents")]
        ConvaiKnowledgeBaseDocuments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_mcp_servers")]
        ConvaiMcpServers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_memory_entries")]
        ConvaiMemoryEntries,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_phone_numbers")]
        ConvaiPhoneNumbers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_secrets")]
        ConvaiSecrets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_settings")]
        ConvaiSettings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_test_suite_invocations")]
        ConvaiTestSuiteInvocations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_tools")]
        ConvaiTools,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_whatsapp_accounts")]
        ConvaiWhatsappAccounts,
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
        [global::System.Runtime.Serialization.EnumMember(Value="pronunciation_dictionary")]
        PronunciationDictionary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resource_locators")]
        ResourceLocators,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="songs")]
        Songs,
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
        [global::System.Runtime.Serialization.EnumMember(Value="workspace_auth_connections")]
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