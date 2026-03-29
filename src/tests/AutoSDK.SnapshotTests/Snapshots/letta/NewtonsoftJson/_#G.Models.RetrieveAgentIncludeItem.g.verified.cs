//HintName: G.Models.RetrieveAgentIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetrieveAgentIncludeItem
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