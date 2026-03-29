//HintName: G.Models.SchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. Data type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SchemaType
    {
        /// <summary>
        /// Array type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ARRAY")]
        Array,
        /// <summary>
        /// Boolean type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BOOLEAN")]
        Boolean,
        /// <summary>
        /// Integer type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INTEGER")]
        Integer,
        /// <summary>
        /// Null type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NULL")]
        Null,
        /// <summary>
        /// Number type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NUMBER")]
        Number,
        /// <summary>
        /// Object type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OBJECT")]
        Object,
        /// <summary>
        /// String type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STRING")]
        String,
        /// <summary>
        /// Not specified, should not be used.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TYPE_UNSPECIFIED")]
        TypeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaType value)
        {
            return value switch
            {
                SchemaType.Array => "ARRAY",
                SchemaType.Boolean => "BOOLEAN",
                SchemaType.Integer => "INTEGER",
                SchemaType.Null => "NULL",
                SchemaType.Number => "NUMBER",
                SchemaType.Object => "OBJECT",
                SchemaType.String => "STRING",
                SchemaType.TypeUnspecified => "TYPE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaType? ToEnum(string value)
        {
            return value switch
            {
                "ARRAY" => SchemaType.Array,
                "BOOLEAN" => SchemaType.Boolean,
                "INTEGER" => SchemaType.Integer,
                "NULL" => SchemaType.Null,
                "NUMBER" => SchemaType.Number,
                "OBJECT" => SchemaType.Object,
                "STRING" => SchemaType.String,
                "TYPE_UNSPECIFIED" => SchemaType.TypeUnspecified,
                _ => null,
            };
        }
    }
}