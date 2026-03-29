//HintName: G.Models.ListAgentsForArchiveIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAgentsForArchiveIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.blocks")]
        AgentBlocks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.identities")]
        AgentIdentities,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.managed_group")]
        AgentManagedGroup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.pending_approval")]
        AgentPendingApproval,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.secrets")]
        AgentSecrets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.sources")]
        AgentSources,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.tags")]
        AgentTags,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent.tools")]
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