//HintName: G.Models.AgentStateResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentStateResponseFormatVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentStateResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStateResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                AgentStateResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                AgentStateResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                AgentStateResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStateResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => AgentStateResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => AgentStateResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => AgentStateResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}