//HintName: G.Models.FormatJsonSchemaConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormatJsonSchemaConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormatJsonSchemaConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormatJsonSchemaConfigType value)
        {
            return value switch
            {
                FormatJsonSchemaConfigType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormatJsonSchemaConfigType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => FormatJsonSchemaConfigType.JsonSchema,
                _ => null,
            };
        }
    }
}