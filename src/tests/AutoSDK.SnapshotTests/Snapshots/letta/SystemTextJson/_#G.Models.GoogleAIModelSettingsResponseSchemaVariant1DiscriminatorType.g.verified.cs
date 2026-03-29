//HintName: G.Models.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType
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
    public static class GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType value)
        {
            return value switch
            {
                GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType.JsonObject => "json_object",
                GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType.JsonSchema => "json_schema",
                GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType.JsonObject,
                "json_schema" => GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType.JsonSchema,
                "text" => GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}