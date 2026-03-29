//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant2Field
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant2Field value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant2Field.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant2Field? ToEnum(string value)
        {
            return value switch
            {
                "name" => AgentsSearchDeployedAgentsRequestSearchItemVariant2Field.Name,
                _ => null,
            };
        }
    }
}