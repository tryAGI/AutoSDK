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
    public enum FilterStructuredOutputColumnOnCallTableOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
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
        In,
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
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
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