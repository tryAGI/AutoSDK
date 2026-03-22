//HintName: G.Models.FilterAttributeStatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The data type of this filter attribute, which determines the aggregation behavior. Numeric types (integer, real_number, and their list variants) include statistical aggregations, while text and boolean types provide value distributions.<br/>
    /// Example: text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterAttributeStatType
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
        [global::System.Runtime.Serialization.EnumMember(Value="list[integer]")]
        Listinteger,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list[real_number]")]
        ListrealNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list[text]")]
        Listtext,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="real_number")]
        RealNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
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
                FilterAttributeStatType.Boolean => "boolean",
                FilterAttributeStatType.Integer => "integer",
                FilterAttributeStatType.Listinteger => "list[integer]",
                FilterAttributeStatType.ListrealNumber => "list[real_number]",
                FilterAttributeStatType.Listtext => "list[text]",
                FilterAttributeStatType.RealNumber => "real_number",
                FilterAttributeStatType.Text => "text",
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
                "boolean" => FilterAttributeStatType.Boolean,
                "integer" => FilterAttributeStatType.Integer,
                "list[integer]" => FilterAttributeStatType.Listinteger,
                "list[real_number]" => FilterAttributeStatType.ListrealNumber,
                "list[text]" => FilterAttributeStatType.Listtext,
                "real_number" => FilterAttributeStatType.RealNumber,
                "text" => FilterAttributeStatType.Text,
                _ => null,
            };
        }
    }
}