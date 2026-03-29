//HintName: G.Models.PromptVersionResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionResponseFormatVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                PromptVersionResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => PromptVersionResponseFormatVariant1DiscriminatorType.JsonSchema,
                _ => null,
            };
        }
    }
}