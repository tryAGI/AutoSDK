//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator
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
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator.Contains => "contains",
                AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator.Eq => "eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator.Contains,
                "eq" => AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator.Eq,
                _ => null,
            };
        }
    }
}