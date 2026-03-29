//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant3Operator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsCountDeployedAgentsSearchItemVariant3Operator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant3OperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant3Operator value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant3Operator.Contains => "contains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant3Operator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => AgentsCountDeployedAgentsSearchItemVariant3Operator.Contains,
                _ => null,
            };
        }
    }
}