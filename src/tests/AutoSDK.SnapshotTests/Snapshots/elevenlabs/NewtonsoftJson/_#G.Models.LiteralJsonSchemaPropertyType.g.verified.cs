//HintName: G.Models.LiteralJsonSchemaPropertyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LiteralJsonSchemaPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integer")]
        Integer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
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
                LiteralJsonSchemaPropertyType.Integer => "integer",
                LiteralJsonSchemaPropertyType.Number => "number",
                LiteralJsonSchemaPropertyType.String => "string",
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
                "integer" => LiteralJsonSchemaPropertyType.Integer,
                "number" => LiteralJsonSchemaPropertyType.Number,
                "string" => LiteralJsonSchemaPropertyType.String,
                _ => null,
            };
        }
    }
}