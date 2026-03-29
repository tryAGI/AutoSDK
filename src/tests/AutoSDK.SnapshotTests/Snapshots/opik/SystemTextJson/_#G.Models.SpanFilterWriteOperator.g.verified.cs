//HintName: G.Models.SpanFilterWriteOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterWriteOperator
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
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterWriteOperator value)
        {
            return value switch
            {
                SpanFilterWriteOperator.Neq => "!=",
                SpanFilterWriteOperator.Lt => "<",
                SpanFilterWriteOperator.Lte => "<=",
                SpanFilterWriteOperator.Eq => "=",
                SpanFilterWriteOperator.Gt => ">",
                SpanFilterWriteOperator.Gte => ">=",
                SpanFilterWriteOperator.Contains => "contains",
                SpanFilterWriteOperator.EndsWith => "ends_with",
                SpanFilterWriteOperator.IsEmpty => "is_empty",
                SpanFilterWriteOperator.IsNotEmpty => "is_not_empty",
                SpanFilterWriteOperator.NotContains => "not_contains",
                SpanFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => SpanFilterWriteOperator.Neq,
                "<" => SpanFilterWriteOperator.Lt,
                "<=" => SpanFilterWriteOperator.Lte,
                "=" => SpanFilterWriteOperator.Eq,
                ">" => SpanFilterWriteOperator.Gt,
                ">=" => SpanFilterWriteOperator.Gte,
                "contains" => SpanFilterWriteOperator.Contains,
                "ends_with" => SpanFilterWriteOperator.EndsWith,
                "is_empty" => SpanFilterWriteOperator.IsEmpty,
                "is_not_empty" => SpanFilterWriteOperator.IsNotEmpty,
                "not_contains" => SpanFilterWriteOperator.NotContains,
                "starts_with" => SpanFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}