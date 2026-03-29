//HintName: G.Models.ColumnType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColumnType
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
    public static class ColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColumnType value)
        {
            return value switch
            {
                ColumnType.Array => "array",
                ColumnType.Boolean => "boolean",
                ColumnType.Null => "null",
                ColumnType.Number => "number",
                ColumnType.Object => "object",
                ColumnType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColumnType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ColumnType.Array,
                "boolean" => ColumnType.Boolean,
                "null" => ColumnType.Null,
                "number" => ColumnType.Number,
                "object" => ColumnType.Object,
                "string" => ColumnType.String,
                _ => null,
            };
        }
    }
}