//HintName: G.Models.EdgeConditionalOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EdgeConditionalOperator
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
        [global::System.Runtime.Serialization.EnumMember(Value="=")]
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
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_not_null")]
        IsNotNull,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_null")]
        IsNull,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_in")]
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EdgeConditionalOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EdgeConditionalOperator value)
        {
            return value switch
            {
                EdgeConditionalOperator.Neq => "!=",
                EdgeConditionalOperator.Lt => "<",
                EdgeConditionalOperator.Lte => "<=",
                EdgeConditionalOperator.Eq => "=",
                EdgeConditionalOperator.Gt => ">",
                EdgeConditionalOperator.Gte => ">=",
                EdgeConditionalOperator.In => "in",
                EdgeConditionalOperator.IsNotNull => "is_not_null",
                EdgeConditionalOperator.IsNull => "is_null",
                EdgeConditionalOperator.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EdgeConditionalOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => EdgeConditionalOperator.Neq,
                "<" => EdgeConditionalOperator.Lt,
                "<=" => EdgeConditionalOperator.Lte,
                "=" => EdgeConditionalOperator.Eq,
                ">" => EdgeConditionalOperator.Gt,
                ">=" => EdgeConditionalOperator.Gte,
                "in" => EdgeConditionalOperator.In,
                "is_not_null" => EdgeConditionalOperator.IsNotNull,
                "is_null" => EdgeConditionalOperator.IsNull,
                "not_in" => EdgeConditionalOperator.NotIn,
                _ => null,
            };
        }
    }
}