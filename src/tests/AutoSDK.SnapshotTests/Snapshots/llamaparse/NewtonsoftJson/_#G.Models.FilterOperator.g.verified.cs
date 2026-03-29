//HintName: G.Models.FilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vector store filter operator.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="!=")]
        Neq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<=")]
        Lte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="==")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value=">")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value=">=")]
        Gte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="any")]
        Any,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_empty")]
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nin")]
        Nin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_match")]
        TextMatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_match_insensitive")]
        TextMatchInsensitive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterOperator value)
        {
            return value switch
            {
                FilterOperator.Neq => "!=",
                FilterOperator.Lt => "<",
                FilterOperator.Lte => "<=",
                FilterOperator.Eq => "==",
                FilterOperator.Gt => ">",
                FilterOperator.Gte => ">=",
                FilterOperator.All => "all",
                FilterOperator.Any => "any",
                FilterOperator.Contains => "contains",
                FilterOperator.In => "in",
                FilterOperator.IsEmpty => "is_empty",
                FilterOperator.Nin => "nin",
                FilterOperator.TextMatch => "text_match",
                FilterOperator.TextMatchInsensitive => "text_match_insensitive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => FilterOperator.Neq,
                "<" => FilterOperator.Lt,
                "<=" => FilterOperator.Lte,
                "==" => FilterOperator.Eq,
                ">" => FilterOperator.Gt,
                ">=" => FilterOperator.Gte,
                "all" => FilterOperator.All,
                "any" => FilterOperator.Any,
                "contains" => FilterOperator.Contains,
                "in" => FilterOperator.In,
                "is_empty" => FilterOperator.IsEmpty,
                "nin" => FilterOperator.Nin,
                "text_match" => FilterOperator.TextMatch,
                "text_match_insensitive" => FilterOperator.TextMatchInsensitive,
                _ => null,
            };
        }
    }
}