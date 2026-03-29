//HintName: G.Models.FilterStructuredOutputColumnOnCallTableOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// The operator depends on the value type of the structured output.<br/>
    /// If the structured output is a string or boolean, the operator must be "=", "!="<br/>
    /// If the structured output is a number, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
    /// If the structured output is an array, the operator must be "in" or "not_in"<br/>
    /// Example: "=" or "&gt;" or "&lt;" or "in" or "not_in"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterStructuredOutputColumnOnCallTableOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gte")]
        Gte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
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
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lte")]
        Lte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neq")]
        Neq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_contains")]
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_in")]
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterStructuredOutputColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterStructuredOutputColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterStructuredOutputColumnOnCallTableOperator.Contains => "contains",
                FilterStructuredOutputColumnOnCallTableOperator.Eq => "eq",
                FilterStructuredOutputColumnOnCallTableOperator.Gt => "gt",
                FilterStructuredOutputColumnOnCallTableOperator.Gte => "gte",
                FilterStructuredOutputColumnOnCallTableOperator.In => "in",
                FilterStructuredOutputColumnOnCallTableOperator.IsEmpty => "is_empty",
                FilterStructuredOutputColumnOnCallTableOperator.IsNotEmpty => "is_not_empty",
                FilterStructuredOutputColumnOnCallTableOperator.Lt => "lt",
                FilterStructuredOutputColumnOnCallTableOperator.Lte => "lte",
                FilterStructuredOutputColumnOnCallTableOperator.Neq => "neq",
                FilterStructuredOutputColumnOnCallTableOperator.NotContains => "not_contains",
                FilterStructuredOutputColumnOnCallTableOperator.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterStructuredOutputColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => FilterStructuredOutputColumnOnCallTableOperator.Contains,
                "eq" => FilterStructuredOutputColumnOnCallTableOperator.Eq,
                "gt" => FilterStructuredOutputColumnOnCallTableOperator.Gt,
                "gte" => FilterStructuredOutputColumnOnCallTableOperator.Gte,
                "in" => FilterStructuredOutputColumnOnCallTableOperator.In,
                "is_empty" => FilterStructuredOutputColumnOnCallTableOperator.IsEmpty,
                "is_not_empty" => FilterStructuredOutputColumnOnCallTableOperator.IsNotEmpty,
                "lt" => FilterStructuredOutputColumnOnCallTableOperator.Lt,
                "lte" => FilterStructuredOutputColumnOnCallTableOperator.Lte,
                "neq" => FilterStructuredOutputColumnOnCallTableOperator.Neq,
                "not_contains" => FilterStructuredOutputColumnOnCallTableOperator.NotContains,
                "not_in" => FilterStructuredOutputColumnOnCallTableOperator.NotIn,
                _ => null,
            };
        }
    }
}