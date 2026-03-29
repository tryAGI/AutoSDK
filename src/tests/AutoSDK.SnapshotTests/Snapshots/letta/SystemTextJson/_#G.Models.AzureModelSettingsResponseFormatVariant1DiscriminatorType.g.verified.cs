//HintName: G.Models.AzureModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class AzureModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                AzureModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                AzureModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                AzureModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => AzureModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => AzureModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => AzureModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}