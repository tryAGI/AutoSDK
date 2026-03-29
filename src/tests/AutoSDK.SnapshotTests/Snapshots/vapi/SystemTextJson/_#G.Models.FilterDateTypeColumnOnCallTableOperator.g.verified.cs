//HintName: G.Models.FilterDateTypeColumnOnCallTableOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// For date type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
    /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
    /// </summary>
    public enum FilterDateTypeColumnOnCallTableOperator
    {
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
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterDateTypeColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterDateTypeColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterDateTypeColumnOnCallTableOperator.Eq => "eq",
                FilterDateTypeColumnOnCallTableOperator.Gt => "gt",
                FilterDateTypeColumnOnCallTableOperator.Gte => "gte",
                FilterDateTypeColumnOnCallTableOperator.Lt => "lt",
                FilterDateTypeColumnOnCallTableOperator.Lte => "lte",
                FilterDateTypeColumnOnCallTableOperator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterDateTypeColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => FilterDateTypeColumnOnCallTableOperator.Eq,
                "gt" => FilterDateTypeColumnOnCallTableOperator.Gt,
                "gte" => FilterDateTypeColumnOnCallTableOperator.Gte,
                "lt" => FilterDateTypeColumnOnCallTableOperator.Lt,
                "lte" => FilterDateTypeColumnOnCallTableOperator.Lte,
                "neq" => FilterDateTypeColumnOnCallTableOperator.Neq,
                _ => null,
            };
        }
    }
}