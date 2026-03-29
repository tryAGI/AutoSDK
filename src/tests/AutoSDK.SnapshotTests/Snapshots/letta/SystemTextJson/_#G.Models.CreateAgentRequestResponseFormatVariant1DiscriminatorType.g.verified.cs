//HintName: G.Models.CreateAgentRequestResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgentRequestResponseFormatVariant1DiscriminatorType
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
    public static class CreateAgentRequestResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRequestResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                CreateAgentRequestResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                CreateAgentRequestResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                CreateAgentRequestResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRequestResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => CreateAgentRequestResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => CreateAgentRequestResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => CreateAgentRequestResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}