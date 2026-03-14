//HintName: G.Models.JsonSchemaDefinitionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The JSON type for this schema element.
    /// </summary>
    public enum JsonSchemaDefinitionType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonSchemaDefinitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonSchemaDefinitionType value)
        {
            return value switch
            {
                JsonSchemaDefinitionType.Object => "object",
                JsonSchemaDefinitionType.Array => "array",
                JsonSchemaDefinitionType.String => "string",
                JsonSchemaDefinitionType.Number => "number",
                JsonSchemaDefinitionType.Integer => "integer",
                JsonSchemaDefinitionType.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonSchemaDefinitionType? ToEnum(string value)
        {
            return value switch
            {
                "object" => JsonSchemaDefinitionType.Object,
                "array" => JsonSchemaDefinitionType.Array,
                "string" => JsonSchemaDefinitionType.String,
                "number" => JsonSchemaDefinitionType.Number,
                "integer" => JsonSchemaDefinitionType.Integer,
                "boolean" => JsonSchemaDefinitionType.Boolean,
                _ => null,
            };
        }
    }
}