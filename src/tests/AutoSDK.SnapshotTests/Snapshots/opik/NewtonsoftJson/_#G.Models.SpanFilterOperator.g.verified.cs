//HintName: G.Models.SpanFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanFilterOperator
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
    public static class SpanFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterOperator value)
        {
            return value switch
            {
                SpanFilterOperator.Neq => "!=",
                SpanFilterOperator.Lt => "<",
                SpanFilterOperator.Lte => "<=",
                SpanFilterOperator.Eq => "=",
                SpanFilterOperator.Gt => ">",
                SpanFilterOperator.Gte => ">=",
                SpanFilterOperator.Contains => "contains",
                SpanFilterOperator.EndsWith => "ends_with",
                SpanFilterOperator.IsEmpty => "is_empty",
                SpanFilterOperator.IsNotEmpty => "is_not_empty",
                SpanFilterOperator.NotContains => "not_contains",
                SpanFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => SpanFilterOperator.Neq,
                "<" => SpanFilterOperator.Lt,
                "<=" => SpanFilterOperator.Lte,
                "=" => SpanFilterOperator.Eq,
                ">" => SpanFilterOperator.Gt,
                ">=" => SpanFilterOperator.Gte,
                "contains" => SpanFilterOperator.Contains,
                "ends_with" => SpanFilterOperator.EndsWith,
                "is_empty" => SpanFilterOperator.IsEmpty,
                "is_not_empty" => SpanFilterOperator.IsNotEmpty,
                "not_contains" => SpanFilterOperator.NotContains,
                "starts_with" => SpanFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}