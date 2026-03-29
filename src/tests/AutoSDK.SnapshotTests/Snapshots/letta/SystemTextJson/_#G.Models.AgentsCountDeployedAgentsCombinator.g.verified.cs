//HintName: G.Models.AgentsCountDeployedAgentsCombinator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsCombinator
    {
        /// <summary>
        /// 
        /// </summary>
        And,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsCombinatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsCombinator value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsCombinator.And => "AND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsCombinator? ToEnum(string value)
        {
            return value switch
            {
                "AND" => AgentsCountDeployedAgentsCombinator.And,
                _ => null,
            };
        }
    }
}