//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant6Field
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentId")]
        AgentId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant6Field value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant6Field.AgentId => "agentId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant6Field? ToEnum(string value)
        {
            return value switch
            {
                "agentId" => AgentsSearchDeployedAgentsRequestSearchItemVariant6Field.AgentId,
                _ => null,
            };
        }
    }
}