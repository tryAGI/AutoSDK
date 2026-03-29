//HintName: G.Models.ColumnCompareType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColumnCompareType
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
    public static class ColumnCompareTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColumnCompareType value)
        {
            return value switch
            {
                ColumnCompareType.Array => "array",
                ColumnCompareType.Boolean => "boolean",
                ColumnCompareType.Null => "null",
                ColumnCompareType.Number => "number",
                ColumnCompareType.Object => "object",
                ColumnCompareType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColumnCompareType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ColumnCompareType.Array,
                "boolean" => ColumnCompareType.Boolean,
                "null" => ColumnCompareType.Null,
                "number" => ColumnCompareType.Number,
                "object" => ColumnCompareType.Object,
                "string" => ColumnCompareType.String,
                _ => null,
            };
        }
    }
}