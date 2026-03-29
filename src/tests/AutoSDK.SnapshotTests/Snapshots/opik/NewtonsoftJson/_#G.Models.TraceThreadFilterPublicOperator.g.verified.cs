//HintName: G.Models.TraceThreadFilterPublicOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceThreadFilterPublicOperator
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