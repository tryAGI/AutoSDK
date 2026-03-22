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
        Array,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        String,
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
                JsonSchemaDefinitionType.Array => "array",
                JsonSchemaDefinitionType.Boolean => "boolean",
                JsonSchemaDefinitionType.Integer => "integer",
                JsonSchemaDefinitionType.Number => "number",
                JsonSchemaDefinitionType.Object => "object",
                JsonSchemaDefinitionType.String => "string",
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
                "array" => JsonSchemaDefinitionType.Array,
                "boolean" => JsonSchemaDefinitionType.Boolean,
                "integer" => JsonSchemaDefinitionType.Integer,
                "number" => JsonSchemaDefinitionType.Number,
                "object" => JsonSchemaDefinitionType.Object,
                "string" => JsonSchemaDefinitionType.String,
                _ => null,
            };
        }
    }
}