//HintName: G.Models.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                OpenAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                OpenAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                OpenAIModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => OpenAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => OpenAIModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => OpenAIModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}