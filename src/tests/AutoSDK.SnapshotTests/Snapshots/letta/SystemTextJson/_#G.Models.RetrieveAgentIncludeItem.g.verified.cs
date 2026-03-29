//HintName: G.Models.RetrieveAgentIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetrieveAgentIncludeItem
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
    public static class RetrieveAgentIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrieveAgentIncludeItem value)
        {
            return value switch
            {
                RetrieveAgentIncludeItem.AgentBlocks => "agent.blocks",
                RetrieveAgentIncludeItem.AgentIdentities => "agent.identities",
                RetrieveAgentIncludeItem.AgentManagedGroup => "agent.managed_group",
                RetrieveAgentIncludeItem.AgentPendingApproval => "agent.pending_approval",
                RetrieveAgentIncludeItem.AgentSecrets => "agent.secrets",
                RetrieveAgentIncludeItem.AgentSources => "agent.sources",
                RetrieveAgentIncludeItem.AgentTags => "agent.tags",
                RetrieveAgentIncludeItem.AgentTools => "agent.tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrieveAgentIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "agent.blocks" => RetrieveAgentIncludeItem.AgentBlocks,
                "agent.identities" => RetrieveAgentIncludeItem.AgentIdentities,
                "agent.managed_group" => RetrieveAgentIncludeItem.AgentManagedGroup,
                "agent.pending_approval" => RetrieveAgentIncludeItem.AgentPendingApproval,
                "agent.secrets" => RetrieveAgentIncludeItem.AgentSecrets,
                "agent.sources" => RetrieveAgentIncludeItem.AgentSources,
                "agent.tags" => RetrieveAgentIncludeItem.AgentTags,
                "agent.tools" => RetrieveAgentIncludeItem.AgentTools,
                _ => null,
            };
        }
    }
}