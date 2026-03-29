//HintName: G.Models.TraceThreadFilterWriteOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceThreadFilterWriteOperator
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