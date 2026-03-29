//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant2Operator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsSearchItemVariant2Operator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant2OperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant2Operator value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant2Operator.Contains => "contains",
                AgentsCountDeployedAgentsSearchItemVariant2Operator.Eq => "eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant2Operator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => AgentsCountDeployedAgentsSearchItemVariant2Operator.Contains,
                "eq" => AgentsCountDeployedAgentsSearchItemVariant2Operator.Eq,
                _ => null,
            };
        }
    }
}