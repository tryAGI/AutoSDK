//HintName: G.Models.JsonSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of output you'd like.<br/>
    /// `string`, `number`, `integer`, `boolean` are the primitive types and should be obvious.<br/>
    /// `array` and `object` are more interesting and quite powerful. They allow you to define nested structures.<br/>
    /// For `array`, you can define the schema of the items in the array using the `items` property.<br/>
    /// For `object`, you can define the properties of the object using the `properties` property.
    /// </summary>
    public enum JsonSchemaType
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
    public static class JsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonSchemaType value)
        {
            return value switch
            {
                JsonSchemaType.Array => "array",
                JsonSchemaType.Boolean => "boolean",
                JsonSchemaType.Integer => "integer",
                JsonSchemaType.Number => "number",
                JsonSchemaType.Object => "object",
                JsonSchemaType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "array" => JsonSchemaType.Array,
                "boolean" => JsonSchemaType.Boolean,
                "integer" => JsonSchemaType.Integer,
                "number" => JsonSchemaType.Number,
                "object" => JsonSchemaType.Object,
                "string" => JsonSchemaType.String,
                _ => null,
            };
        }
    }
}