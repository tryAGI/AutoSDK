//HintName: G.Models.TraceFilterPublicOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceFilterPublicOperator
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
    public static class TraceFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceFilterPublicOperator value)
        {
            return value switch
            {
                TraceFilterPublicOperator.Neq => "!=",
                TraceFilterPublicOperator.Lt => "<",
                TraceFilterPublicOperator.Lte => "<=",
                TraceFilterPublicOperator.Eq => "=",
                TraceFilterPublicOperator.Gt => ">",
                TraceFilterPublicOperator.Gte => ">=",
                TraceFilterPublicOperator.Contains => "contains",
                TraceFilterPublicOperator.EndsWith => "ends_with",
                TraceFilterPublicOperator.IsEmpty => "is_empty",
                TraceFilterPublicOperator.IsNotEmpty => "is_not_empty",
                TraceFilterPublicOperator.NotContains => "not_contains",
                TraceFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => TraceFilterPublicOperator.Neq,
                "<" => TraceFilterPublicOperator.Lt,
                "<=" => TraceFilterPublicOperator.Lte,
                "=" => TraceFilterPublicOperator.Eq,
                ">" => TraceFilterPublicOperator.Gt,
                ">=" => TraceFilterPublicOperator.Gte,
                "contains" => TraceFilterPublicOperator.Contains,
                "ends_with" => TraceFilterPublicOperator.EndsWith,
                "is_empty" => TraceFilterPublicOperator.IsEmpty,
                "is_not_empty" => TraceFilterPublicOperator.IsNotEmpty,
                "not_contains" => TraceFilterPublicOperator.NotContains,
                "starts_with" => TraceFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}