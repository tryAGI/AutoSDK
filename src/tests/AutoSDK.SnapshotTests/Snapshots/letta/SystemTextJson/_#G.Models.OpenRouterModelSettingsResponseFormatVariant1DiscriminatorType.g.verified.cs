//HintName: G.Models.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}