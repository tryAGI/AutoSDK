//HintName: G.Models.ColumnPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ColumnPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="array")]
        Array,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="null")]
        Null,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object")]
        Object,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColumnPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColumnPublicType value)
        {
            return value switch
            {
                ColumnPublicType.Array => "array",
                ColumnPublicType.Boolean => "boolean",
                ColumnPublicType.Null => "null",
                ColumnPublicType.Number => "number",
                ColumnPublicType.Object => "object",
                ColumnPublicType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColumnPublicType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ColumnPublicType.Array,
                "boolean" => ColumnPublicType.Boolean,
                "null" => ColumnPublicType.Null,
                "number" => ColumnPublicType.Number,
                "object" => ColumnPublicType.Object,
                "string" => ColumnPublicType.String,
                _ => null,
            };
        }
    }
}