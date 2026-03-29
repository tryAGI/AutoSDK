//HintName: G.Models.TraceThreadFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadFilterOperator
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
    public static class TraceThreadFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterOperator value)
        {
            return value switch
            {
                TraceThreadFilterOperator.Neq => "!=",
                TraceThreadFilterOperator.Lt => "<",
                TraceThreadFilterOperator.Lte => "<=",
                TraceThreadFilterOperator.Eq => "=",
                TraceThreadFilterOperator.Gt => ">",
                TraceThreadFilterOperator.Gte => ">=",
                TraceThreadFilterOperator.Contains => "contains",
                TraceThreadFilterOperator.EndsWith => "ends_with",
                TraceThreadFilterOperator.IsEmpty => "is_empty",
                TraceThreadFilterOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterOperator.NotContains => "not_contains",
                TraceThreadFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => TraceThreadFilterOperator.Neq,
                "<" => TraceThreadFilterOperator.Lt,
                "<=" => TraceThreadFilterOperator.Lte,
                "=" => TraceThreadFilterOperator.Eq,
                ">" => TraceThreadFilterOperator.Gt,
                ">=" => TraceThreadFilterOperator.Gte,
                "contains" => TraceThreadFilterOperator.Contains,
                "ends_with" => TraceThreadFilterOperator.EndsWith,
                "is_empty" => TraceThreadFilterOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterOperator.IsNotEmpty,
                "not_contains" => TraceThreadFilterOperator.NotContains,
                "starts_with" => TraceThreadFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}