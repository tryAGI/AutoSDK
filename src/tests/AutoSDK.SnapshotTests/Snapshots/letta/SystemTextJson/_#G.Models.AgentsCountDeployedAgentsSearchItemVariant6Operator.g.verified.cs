//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant6Operator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsSearchItemVariant6Operator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant6OperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant6Operator value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant6Operator.Eq => "eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant6Operator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AgentsCountDeployedAgentsSearchItemVariant6Operator.Eq,
                _ => null,
            };
        }
    }
}