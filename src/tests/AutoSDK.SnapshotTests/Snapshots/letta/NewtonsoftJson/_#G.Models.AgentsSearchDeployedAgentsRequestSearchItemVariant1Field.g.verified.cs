//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant1Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant1Field
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="version")]
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant1Field value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant1Field.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant1Field? ToEnum(string value)
        {
            return value switch
            {
                "version" => AgentsSearchDeployedAgentsRequestSearchItemVariant1Field.Version,
                _ => null,
            };
        }
    }
}