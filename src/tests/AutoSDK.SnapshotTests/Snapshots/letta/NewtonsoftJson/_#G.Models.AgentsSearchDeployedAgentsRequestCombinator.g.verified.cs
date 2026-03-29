//HintName: G.Models.AgentsSearchDeployedAgentsRequestCombinator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSearchDeployedAgentsRequestCombinator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AND")]
        And,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestCombinatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestCombinator value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestCombinator.And => "AND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestCombinator? ToEnum(string value)
        {
            return value switch
            {
                "AND" => AgentsSearchDeployedAgentsRequestCombinator.And,
                _ => null,
            };
        }
    }
}