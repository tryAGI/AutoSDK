//HintName: G.Models.EdgeConditionalOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator.
    /// </summary>
    public enum EdgeConditionalOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        IsNotNull,
        /// <summary>
        /// 
        /// </summary>
        IsNull,
        /// <summary>
        /// 
        /// </summary>
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