//HintName: G.Models.ListAgentsForBlockIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAgentsForBlockIncludeItem
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
    public static class ListAgentsForBlockIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsForBlockIncludeItem value)
        {
            return value switch
            {
                ListAgentsForBlockIncludeItem.AgentBlocks => "agent.blocks",
                ListAgentsForBlockIncludeItem.AgentIdentities => "agent.identities",
                ListAgentsForBlockIncludeItem.AgentManagedGroup => "agent.managed_group",
                ListAgentsForBlockIncludeItem.AgentPendingApproval => "agent.pending_approval",
                ListAgentsForBlockIncludeItem.AgentSecrets => "agent.secrets",
                ListAgentsForBlockIncludeItem.AgentSources => "agent.sources",
                ListAgentsForBlockIncludeItem.AgentTags => "agent.tags",
                ListAgentsForBlockIncludeItem.AgentTools => "agent.tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsForBlockIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "agent.blocks" => ListAgentsForBlockIncludeItem.AgentBlocks,
                "agent.identities" => ListAgentsForBlockIncludeItem.AgentIdentities,
                "agent.managed_group" => ListAgentsForBlockIncludeItem.AgentManagedGroup,
                "agent.pending_approval" => ListAgentsForBlockIncludeItem.AgentPendingApproval,
                "agent.secrets" => ListAgentsForBlockIncludeItem.AgentSecrets,
                "agent.sources" => ListAgentsForBlockIncludeItem.AgentSources,
                "agent.tags" => ListAgentsForBlockIncludeItem.AgentTags,
                "agent.tools" => ListAgentsForBlockIncludeItem.AgentTools,
                _ => null,
            };
        }
    }
}