//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant3Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsSearchItemVariant3Field
    {
        /// <summary>
        /// 
        /// </summary>
        Tags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant3FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant3Field value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant3Field.Tags => "tags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant3Field? ToEnum(string value)
        {
            return value switch
            {
                "tags" => AgentsCountDeployedAgentsSearchItemVariant3Field.Tags,
                _ => null,
            };
        }
    }
}