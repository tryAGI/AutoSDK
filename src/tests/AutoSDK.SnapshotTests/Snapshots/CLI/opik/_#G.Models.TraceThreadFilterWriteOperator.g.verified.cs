//HintName: G.Models.TraceThreadFilterWriteOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadFilterWriteOperator
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
    public static class TraceThreadFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterWriteOperator value)
        {
            return value switch
            {
                TraceThreadFilterWriteOperator.Neq => "!=",
                TraceThreadFilterWriteOperator.Lt => "<",
                TraceThreadFilterWriteOperator.Lte => "<=",
                TraceThreadFilterWriteOperator.Eq => "=",
                TraceThreadFilterWriteOperator.Gt => ">",
                TraceThreadFilterWriteOperator.Gte => ">=",
                TraceThreadFilterWriteOperator.Contains => "contains",
                TraceThreadFilterWriteOperator.EndsWith => "ends_with",
                TraceThreadFilterWriteOperator.IsEmpty => "is_empty",
                TraceThreadFilterWriteOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterWriteOperator.NotContains => "not_contains",
                TraceThreadFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => TraceThreadFilterWriteOperator.Neq,
                "<" => TraceThreadFilterWriteOperator.Lt,
                "<=" => TraceThreadFilterWriteOperator.Lte,
                "=" => TraceThreadFilterWriteOperator.Eq,
                ">" => TraceThreadFilterWriteOperator.Gt,
                ">=" => TraceThreadFilterWriteOperator.Gte,
                "contains" => TraceThreadFilterWriteOperator.Contains,
                "ends_with" => TraceThreadFilterWriteOperator.EndsWith,
                "is_empty" => TraceThreadFilterWriteOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterWriteOperator.IsNotEmpty,
                "not_contains" => TraceThreadFilterWriteOperator.NotContains,
                "starts_with" => TraceThreadFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}