//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant6Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsCountDeployedAgentsSearchItemVariant6Field
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
    public static class AgentsCountDeployedAgentsSearchItemVariant6FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant6Field value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant6Field.AgentId => "agentId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant6Field? ToEnum(string value)
        {
            return value switch
            {
                "agentId" => AgentsCountDeployedAgentsSearchItemVariant6Field.AgentId,
                _ => null,
            };
        }
    }
}