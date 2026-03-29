//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator.Contains => "contains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator.Contains,
                _ => null,
            };
        }
    }
}