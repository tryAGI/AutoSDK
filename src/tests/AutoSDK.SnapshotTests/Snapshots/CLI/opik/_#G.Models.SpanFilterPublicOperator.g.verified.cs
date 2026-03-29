//HintName: G.Models.SpanFilterPublicOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterPublicOperator
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
    public static class SpanFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterPublicOperator value)
        {
            return value switch
            {
                SpanFilterPublicOperator.Neq => "!=",
                SpanFilterPublicOperator.Lt => "<",
                SpanFilterPublicOperator.Lte => "<=",
                SpanFilterPublicOperator.Eq => "=",
                SpanFilterPublicOperator.Gt => ">",
                SpanFilterPublicOperator.Gte => ">=",
                SpanFilterPublicOperator.Contains => "contains",
                SpanFilterPublicOperator.EndsWith => "ends_with",
                SpanFilterPublicOperator.IsEmpty => "is_empty",
                SpanFilterPublicOperator.IsNotEmpty => "is_not_empty",
                SpanFilterPublicOperator.NotContains => "not_contains",
                SpanFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => SpanFilterPublicOperator.Neq,
                "<" => SpanFilterPublicOperator.Lt,
                "<=" => SpanFilterPublicOperator.Lte,
                "=" => SpanFilterPublicOperator.Eq,
                ">" => SpanFilterPublicOperator.Gt,
                ">=" => SpanFilterPublicOperator.Gte,
                "contains" => SpanFilterPublicOperator.Contains,
                "ends_with" => SpanFilterPublicOperator.EndsWith,
                "is_empty" => SpanFilterPublicOperator.IsEmpty,
                "is_not_empty" => SpanFilterPublicOperator.IsNotEmpty,
                "not_contains" => SpanFilterPublicOperator.NotContains,
                "starts_with" => SpanFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}