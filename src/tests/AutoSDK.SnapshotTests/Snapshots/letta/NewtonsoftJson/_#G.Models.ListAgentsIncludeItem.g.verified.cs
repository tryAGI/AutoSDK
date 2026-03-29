//HintName: G.Models.ListAgentsIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAgentsIncludeItem
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