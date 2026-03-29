//HintName: G.Models.BedrockModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BedrockModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BedrockModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                BedrockModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                BedrockModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                BedrockModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BedrockModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => BedrockModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => BedrockModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => BedrockModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}