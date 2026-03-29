//HintName: G.Models.ListAgentsForIdentityIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAgentsForIdentityIncludeItem
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
    public static class ListAgentsForIdentityIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsForIdentityIncludeItem value)
        {
            return value switch
            {
                ListAgentsForIdentityIncludeItem.AgentBlocks => "agent.blocks",
                ListAgentsForIdentityIncludeItem.AgentIdentities => "agent.identities",
                ListAgentsForIdentityIncludeItem.AgentManagedGroup => "agent.managed_group",
                ListAgentsForIdentityIncludeItem.AgentPendingApproval => "agent.pending_approval",
                ListAgentsForIdentityIncludeItem.AgentSecrets => "agent.secrets",
                ListAgentsForIdentityIncludeItem.AgentSources => "agent.sources",
                ListAgentsForIdentityIncludeItem.AgentTags => "agent.tags",
                ListAgentsForIdentityIncludeItem.AgentTools => "agent.tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsForIdentityIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "agent.blocks" => ListAgentsForIdentityIncludeItem.AgentBlocks,
                "agent.identities" => ListAgentsForIdentityIncludeItem.AgentIdentities,
                "agent.managed_group" => ListAgentsForIdentityIncludeItem.AgentManagedGroup,
                "agent.pending_approval" => ListAgentsForIdentityIncludeItem.AgentPendingApproval,
                "agent.secrets" => ListAgentsForIdentityIncludeItem.AgentSecrets,
                "agent.sources" => ListAgentsForIdentityIncludeItem.AgentSources,
                "agent.tags" => ListAgentsForIdentityIncludeItem.AgentTags,
                "agent.tools" => ListAgentsForIdentityIncludeItem.AgentTools,
                _ => null,
            };
        }
    }
}