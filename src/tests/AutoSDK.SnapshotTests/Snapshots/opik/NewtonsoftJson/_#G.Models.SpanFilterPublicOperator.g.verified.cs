//HintName: G.Models.SpanFilterPublicOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanFilterPublicOperator
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