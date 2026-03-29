//HintName: G.Models.GroqModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GroqModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class GroqModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroqModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                GroqModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                GroqModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                GroqModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroqModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => GroqModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => GroqModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => GroqModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}