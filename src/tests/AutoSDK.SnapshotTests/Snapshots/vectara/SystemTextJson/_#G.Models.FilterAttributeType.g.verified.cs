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
    public static class FilterAttributeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterAttributeType value)
        {
            return value switch
            {
                FilterAttributeType.Integer => "integer",
                FilterAttributeType.RealNumber => "real_number",
                FilterAttributeType.Text => "text",
                FilterAttributeType.Boolean => "boolean",
                FilterAttributeType.Listinteger => "list[integer]",
                FilterAttributeType.ListrealNumber => "list[real_number]",
                FilterAttributeType.Listtext => "list[text]",
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
                "integer" => FilterAttributeType.Integer,
                "real_number" => FilterAttributeType.RealNumber,
                "text" => FilterAttributeType.Text,
                "boolean" => FilterAttributeType.Boolean,
                "list[integer]" => FilterAttributeType.Listinteger,
                "list[real_number]" => FilterAttributeType.ListrealNumber,
                "list[text]" => FilterAttributeType.Listtext,
                _ => null,
            };
        }
    }
}