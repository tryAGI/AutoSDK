//HintName: G.Models.JsonSchemaDefinitionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The JSON type for this schema element.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JsonSchemaDefinitionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object")]
        Object,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="array")]
        Array,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integer")]
        Integer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
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