//HintName: G.Models.XAIModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum XAIModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class XAIModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XAIModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                XAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                XAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                XAIModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XAIModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => XAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => XAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => XAIModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}