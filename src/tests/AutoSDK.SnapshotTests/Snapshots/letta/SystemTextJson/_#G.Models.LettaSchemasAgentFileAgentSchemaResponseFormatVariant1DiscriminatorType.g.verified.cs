//HintName: G.Models.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType
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
    public static class LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}