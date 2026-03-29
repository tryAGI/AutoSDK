//HintName: G.Models.SpanFilterWriteOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanFilterWriteOperator
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
    public static class SpanFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterWriteOperator value)
        {
            return value switch
            {
                SpanFilterWriteOperator.Neq => "!=",
                SpanFilterWriteOperator.Lt => "<",
                SpanFilterWriteOperator.Lte => "<=",
                SpanFilterWriteOperator.Eq => "=",
                SpanFilterWriteOperator.Gt => ">",
                SpanFilterWriteOperator.Gte => ">=",
                SpanFilterWriteOperator.Contains => "contains",
                SpanFilterWriteOperator.EndsWith => "ends_with",
                SpanFilterWriteOperator.IsEmpty => "is_empty",
                SpanFilterWriteOperator.IsNotEmpty => "is_not_empty",
                SpanFilterWriteOperator.NotContains => "not_contains",
                SpanFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => SpanFilterWriteOperator.Neq,
                "<" => SpanFilterWriteOperator.Lt,
                "<=" => SpanFilterWriteOperator.Lte,
                "=" => SpanFilterWriteOperator.Eq,
                ">" => SpanFilterWriteOperator.Gt,
                ">=" => SpanFilterWriteOperator.Gte,
                "contains" => SpanFilterWriteOperator.Contains,
                "ends_with" => SpanFilterWriteOperator.EndsWith,
                "is_empty" => SpanFilterWriteOperator.IsEmpty,
                "is_not_empty" => SpanFilterWriteOperator.IsNotEmpty,
                "not_contains" => SpanFilterWriteOperator.NotContains,
                "starts_with" => SpanFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}