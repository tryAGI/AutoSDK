//HintName: G.Models.ListAgentsIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAgentsIncludeItem
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
    public static class ListAgentsIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsIncludeItem value)
        {
            return value switch
            {
                ListAgentsIncludeItem.AgentBlocks => "agent.blocks",
                ListAgentsIncludeItem.AgentIdentities => "agent.identities",
                ListAgentsIncludeItem.AgentManagedGroup => "agent.managed_group",
                ListAgentsIncludeItem.AgentPendingApproval => "agent.pending_approval",
                ListAgentsIncludeItem.AgentSecrets => "agent.secrets",
                ListAgentsIncludeItem.AgentSources => "agent.sources",
                ListAgentsIncludeItem.AgentTags => "agent.tags",
                ListAgentsIncludeItem.AgentTools => "agent.tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "agent.blocks" => ListAgentsIncludeItem.AgentBlocks,
                "agent.identities" => ListAgentsIncludeItem.AgentIdentities,
                "agent.managed_group" => ListAgentsIncludeItem.AgentManagedGroup,
                "agent.pending_approval" => ListAgentsIncludeItem.AgentPendingApproval,
                "agent.secrets" => ListAgentsIncludeItem.AgentSecrets,
                "agent.sources" => ListAgentsIncludeItem.AgentSources,
                "agent.tags" => ListAgentsIncludeItem.AgentTags,
                "agent.tools" => ListAgentsIncludeItem.AgentTools,
                _ => null,
            };
        }
    }
}