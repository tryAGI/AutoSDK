//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant1Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsSearchItemVariant1Field
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant1FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant1Field value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant1Field.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant1Field? ToEnum(string value)
        {
            return value switch
            {
                "version" => AgentsCountDeployedAgentsSearchItemVariant1Field.Version,
                _ => null,
            };
        }
    }
}