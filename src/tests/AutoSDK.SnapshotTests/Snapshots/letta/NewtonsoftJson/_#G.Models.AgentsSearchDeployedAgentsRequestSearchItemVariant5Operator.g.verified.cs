//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant5OperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator.Eq => "eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator.Eq,
                _ => null,
            };
        }
    }
}