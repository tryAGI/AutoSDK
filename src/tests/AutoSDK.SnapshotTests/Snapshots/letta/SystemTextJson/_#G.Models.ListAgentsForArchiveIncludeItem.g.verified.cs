//HintName: G.Models.ListAgentsForArchiveIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAgentsForArchiveIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AgentBlocks,
        /// <summary>
        /// 
        /// </summary>
        AgentIdentities,
        /// <summary>
        /// 
        /// </summary>
        AgentManagedGroup,
        /// <summary>
        /// 
        /// </summary>
        AgentPendingApproval,
        /// <summary>
        /// 
        /// </summary>
        AgentSecrets,
        /// <summary>
        /// 
        /// </summary>
        AgentSources,
        /// <summary>
        /// 
        /// </summary>
        AgentTags,
        /// <summary>
        /// 
        /// </summary>
        AgentTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentsForArchiveIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsForArchiveIncludeItem value)
        {
            return value switch
            {
                ListAgentsForArchiveIncludeItem.AgentBlocks => "agent.blocks",
                ListAgentsForArchiveIncludeItem.AgentIdentities => "agent.identities",
                ListAgentsForArchiveIncludeItem.AgentManagedGroup => "agent.managed_group",
                ListAgentsForArchiveIncludeItem.AgentPendingApproval => "agent.pending_approval",
                ListAgentsForArchiveIncludeItem.AgentSecrets => "agent.secrets",
                ListAgentsForArchiveIncludeItem.AgentSources => "agent.sources",
                ListAgentsForArchiveIncludeItem.AgentTags => "agent.tags",
                ListAgentsForArchiveIncludeItem.AgentTools => "agent.tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsForArchiveIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "agent.blocks" => ListAgentsForArchiveIncludeItem.AgentBlocks,
                "agent.identities" => ListAgentsForArchiveIncludeItem.AgentIdentities,
                "agent.managed_group" => ListAgentsForArchiveIncludeItem.AgentManagedGroup,
                "agent.pending_approval" => ListAgentsForArchiveIncludeItem.AgentPendingApproval,
                "agent.secrets" => ListAgentsForArchiveIncludeItem.AgentSecrets,
                "agent.sources" => ListAgentsForArchiveIncludeItem.AgentSources,
                "agent.tags" => ListAgentsForArchiveIncludeItem.AgentTags,
                "agent.tools" => ListAgentsForArchiveIncludeItem.AgentTools,
                _ => null,
            };
        }
    }
}