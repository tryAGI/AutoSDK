//HintName: G.Models.TextResponseFormatJsonSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of response format being defined. Always `json_schema`.
    /// </summary>
    public enum TextResponseFormatJsonSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextResponseFormatJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextResponseFormatJsonSchemaType value)
        {
            return value switch
            {
                TextResponseFormatJsonSchemaType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextResponseFormatJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => TextResponseFormatJsonSchemaType.JsonSchema,
                _ => null,
            };
        }
    }
}