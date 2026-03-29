//HintName: G.Models.ColumnPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColumnPublicType
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
        Null,
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