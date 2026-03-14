//HintName: G.Models.FilterAttributeStatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The data type of this filter attribute, which determines the aggregation behavior. Numeric types (integer, real_number, and their list variants) include statistical aggregations, while text and boolean types provide value distributions.<br/>
    /// Example: text
    /// </summary>
    public enum FilterAttributeStatType
    {
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        RealNumber,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Listinteger,
        /// <summary>
        /// 
        /// </summary>
        ListrealNumber,
        /// <summary>
        /// 
        /// </summary>
        Listtext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterAttributeStatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterAttributeStatType value)
        {
            return value switch
            {
                FilterAttributeStatType.Integer => "integer",
                FilterAttributeStatType.RealNumber => "real_number",
                FilterAttributeStatType.Text => "text",
                FilterAttributeStatType.Boolean => "boolean",
                FilterAttributeStatType.Listinteger => "list[integer]",
                FilterAttributeStatType.ListrealNumber => "list[real_number]",
                FilterAttributeStatType.Listtext => "list[text]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterAttributeStatType? ToEnum(string value)
        {
            return value switch
            {
                "integer" => FilterAttributeStatType.Integer,
                "real_number" => FilterAttributeStatType.RealNumber,
                "text" => FilterAttributeStatType.Text,
                "boolean" => FilterAttributeStatType.Boolean,
                "list[integer]" => FilterAttributeStatType.Listinteger,
                "list[real_number]" => FilterAttributeStatType.ListrealNumber,
                "list[text]" => FilterAttributeStatType.Listtext,
                _ => null,
            };
        }
    }
}