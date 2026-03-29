//HintName: G.Models.TogetherModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TogetherModelSettingsResponseFormatVariant1DiscriminatorType
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
    public static class TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TogetherModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                TogetherModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                TogetherModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                TogetherModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TogetherModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => TogetherModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => TogetherModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => TogetherModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}