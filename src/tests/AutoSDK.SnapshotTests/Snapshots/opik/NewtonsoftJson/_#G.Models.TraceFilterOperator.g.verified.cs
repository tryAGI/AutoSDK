//HintName: G.Models.TraceFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceFilterOperator
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
    public static class TraceFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceFilterOperator value)
        {
            return value switch
            {
                TraceFilterOperator.Neq => "!=",
                TraceFilterOperator.Lt => "<",
                TraceFilterOperator.Lte => "<=",
                TraceFilterOperator.Eq => "=",
                TraceFilterOperator.Gt => ">",
                TraceFilterOperator.Gte => ">=",
                TraceFilterOperator.Contains => "contains",
                TraceFilterOperator.EndsWith => "ends_with",
                TraceFilterOperator.IsEmpty => "is_empty",
                TraceFilterOperator.IsNotEmpty => "is_not_empty",
                TraceFilterOperator.NotContains => "not_contains",
                TraceFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => TraceFilterOperator.Neq,
                "<" => TraceFilterOperator.Lt,
                "<=" => TraceFilterOperator.Lte,
                "=" => TraceFilterOperator.Eq,
                ">" => TraceFilterOperator.Gt,
                ">=" => TraceFilterOperator.Gte,
                "contains" => TraceFilterOperator.Contains,
                "ends_with" => TraceFilterOperator.EndsWith,
                "is_empty" => TraceFilterOperator.IsEmpty,
                "is_not_empty" => TraceFilterOperator.IsNotEmpty,
                "not_contains" => TraceFilterOperator.NotContains,
                "starts_with" => TraceFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}