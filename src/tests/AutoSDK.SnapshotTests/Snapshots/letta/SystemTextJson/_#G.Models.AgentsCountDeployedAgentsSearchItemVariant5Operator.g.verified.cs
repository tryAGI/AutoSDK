//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant5Operator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsSearchItemVariant5Operator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant5OperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant5Operator value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant5Operator.Eq => "eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant5Operator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AgentsCountDeployedAgentsSearchItemVariant5Operator.Eq,
                _ => null,
            };
        }
    }
}