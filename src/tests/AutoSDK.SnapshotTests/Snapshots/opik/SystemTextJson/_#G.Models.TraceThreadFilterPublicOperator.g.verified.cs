//HintName: G.Models.TraceThreadFilterPublicOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadFilterPublicOperator
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
    public static class TraceThreadFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterPublicOperator value)
        {
            return value switch
            {
                TraceThreadFilterPublicOperator.Neq => "!=",
                TraceThreadFilterPublicOperator.Lt => "<",
                TraceThreadFilterPublicOperator.Lte => "<=",
                TraceThreadFilterPublicOperator.Eq => "=",
                TraceThreadFilterPublicOperator.Gt => ">",
                TraceThreadFilterPublicOperator.Gte => ">=",
                TraceThreadFilterPublicOperator.Contains => "contains",
                TraceThreadFilterPublicOperator.EndsWith => "ends_with",
                TraceThreadFilterPublicOperator.IsEmpty => "is_empty",
                TraceThreadFilterPublicOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterPublicOperator.NotContains => "not_contains",
                TraceThreadFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => TraceThreadFilterPublicOperator.Neq,
                "<" => TraceThreadFilterPublicOperator.Lt,
                "<=" => TraceThreadFilterPublicOperator.Lte,
                "=" => TraceThreadFilterPublicOperator.Eq,
                ">" => TraceThreadFilterPublicOperator.Gt,
                ">=" => TraceThreadFilterPublicOperator.Gte,
                "contains" => TraceThreadFilterPublicOperator.Contains,
                "ends_with" => TraceThreadFilterPublicOperator.EndsWith,
                "is_empty" => TraceThreadFilterPublicOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterPublicOperator.IsNotEmpty,
                "not_contains" => TraceThreadFilterPublicOperator.NotContains,
                "starts_with" => TraceThreadFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}