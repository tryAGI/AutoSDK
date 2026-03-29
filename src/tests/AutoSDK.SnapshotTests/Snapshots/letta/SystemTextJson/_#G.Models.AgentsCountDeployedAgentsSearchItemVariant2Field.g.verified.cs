//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant2Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsSearchItemVariant2Field
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant2FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant2Field value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant2Field.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant2Field? ToEnum(string value)
        {
            return value switch
            {
                "name" => AgentsCountDeployedAgentsSearchItemVariant2Field.Name,
                _ => null,
            };
        }
    }
}