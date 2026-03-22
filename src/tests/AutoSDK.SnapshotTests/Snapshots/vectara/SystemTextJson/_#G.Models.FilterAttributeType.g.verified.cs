//HintName: G.Models.FilterAttributeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The value type of the filter.<br/>
    /// Example: text
    /// </summary>
    public enum FilterAttributeType
    {
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
        Listinteger,
        /// <summary>
        /// 
        /// </summary>
        ListrealNumber,
        /// <summary>
        /// 
        /// </summary>
        Listtext,
        /// <summary>
        /// 
        /// </summary>
        RealNumber,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterAttributeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterAttributeType value)
        {
            return value switch
            {
                FilterAttributeType.Boolean => "boolean",
                FilterAttributeType.Integer => "integer",
                FilterAttributeType.Listinteger => "list[integer]",
                FilterAttributeType.ListrealNumber => "list[real_number]",
                FilterAttributeType.Listtext => "list[text]",
                FilterAttributeType.RealNumber => "real_number",
                FilterAttributeType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterAttributeType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FilterAttributeType.Boolean,
                "integer" => FilterAttributeType.Integer,
                "list[integer]" => FilterAttributeType.Listinteger,
                "list[real_number]" => FilterAttributeType.ListrealNumber,
                "list[text]" => FilterAttributeType.Listtext,
                "real_number" => FilterAttributeType.RealNumber,
                "text" => FilterAttributeType.Text,
                _ => null,
            };
        }
    }
}