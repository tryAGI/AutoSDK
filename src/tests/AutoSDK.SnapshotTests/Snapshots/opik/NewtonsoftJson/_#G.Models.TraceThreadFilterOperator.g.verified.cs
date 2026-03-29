//HintName: G.Models.TraceThreadFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceThreadFilterOperator
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
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ends_with")]
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_empty")]
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_not_empty")]
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_contains")]
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starts_with")]
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