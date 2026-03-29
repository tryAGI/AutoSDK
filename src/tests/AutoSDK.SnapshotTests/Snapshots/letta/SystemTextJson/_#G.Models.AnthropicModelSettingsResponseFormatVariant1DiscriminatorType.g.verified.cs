//HintName: G.Models.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                AnthropicModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                AnthropicModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                AnthropicModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => AnthropicModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => AnthropicModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => AnthropicModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}