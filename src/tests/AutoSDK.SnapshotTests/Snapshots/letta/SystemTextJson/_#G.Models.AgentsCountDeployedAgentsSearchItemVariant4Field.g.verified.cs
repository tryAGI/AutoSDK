//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant4Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCountDeployedAgentsSearchItemVariant4Field
    {
        /// <summary>
        /// 
        /// </summary>
        Identity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant4FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant4Field value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant4Field.Identity => "identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant4Field? ToEnum(string value)
        {
            return value switch
            {
                "identity" => AgentsCountDeployedAgentsSearchItemVariant4Field.Identity,
                _ => null,
            };
        }
    }
}