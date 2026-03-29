//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant3Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant3Field
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tags")]
        Tags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant3Field value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant3Field.Tags => "tags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant3Field? ToEnum(string value)
        {
            return value switch
            {
                "tags" => AgentsSearchDeployedAgentsRequestSearchItemVariant3Field.Tags,
                _ => null,
            };
        }
    }
}