//HintName: G.Models.TraceFilterWriteOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceFilterWriteOperator
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
    public static class TraceFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceFilterWriteOperator value)
        {
            return value switch
            {
                TraceFilterWriteOperator.Neq => "!=",
                TraceFilterWriteOperator.Lt => "<",
                TraceFilterWriteOperator.Lte => "<=",
                TraceFilterWriteOperator.Eq => "=",
                TraceFilterWriteOperator.Gt => ">",
                TraceFilterWriteOperator.Gte => ">=",
                TraceFilterWriteOperator.Contains => "contains",
                TraceFilterWriteOperator.EndsWith => "ends_with",
                TraceFilterWriteOperator.IsEmpty => "is_empty",
                TraceFilterWriteOperator.IsNotEmpty => "is_not_empty",
                TraceFilterWriteOperator.NotContains => "not_contains",
                TraceFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => TraceFilterWriteOperator.Neq,
                "<" => TraceFilterWriteOperator.Lt,
                "<=" => TraceFilterWriteOperator.Lte,
                "=" => TraceFilterWriteOperator.Eq,
                ">" => TraceFilterWriteOperator.Gt,
                ">=" => TraceFilterWriteOperator.Gte,
                "contains" => TraceFilterWriteOperator.Contains,
                "ends_with" => TraceFilterWriteOperator.EndsWith,
                "is_empty" => TraceFilterWriteOperator.IsEmpty,
                "is_not_empty" => TraceFilterWriteOperator.IsNotEmpty,
                "not_contains" => TraceFilterWriteOperator.NotContains,
                "starts_with" => TraceFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}