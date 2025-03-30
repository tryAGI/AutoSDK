//HintName: G.Models.LiteralJsonSchemaPropertyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LiteralJsonSchemaPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiteralJsonSchemaPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteralJsonSchemaPropertyType value)
        {
            return value switch
            {
                LiteralJsonSchemaPropertyType.Boolean => "boolean",
                LiteralJsonSchemaPropertyType.String => "string",
                LiteralJsonSchemaPropertyType.Integer => "integer",
                LiteralJsonSchemaPropertyType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteralJsonSchemaPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => LiteralJsonSchemaPropertyType.Boolean,
                "string" => LiteralJsonSchemaPropertyType.String,
                "integer" => LiteralJsonSchemaPropertyType.Integer,
                "number" => LiteralJsonSchemaPropertyType.Number,
                _ => null,
            };
        }
    }
}