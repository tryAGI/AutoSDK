//HintName: G.Models.LLMConfigResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMConfigResponseFormatVariant1DiscriminatorType
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
    public static class LLMConfigResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                LLMConfigResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                LLMConfigResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                LLMConfigResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => LLMConfigResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => LLMConfigResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => LLMConfigResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}