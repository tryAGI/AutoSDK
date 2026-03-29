//HintName: G.Models.FilterStringTypeColumnOnCallTableOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// For string type columns, the operator must be "=", "!=", "contains", "not contains"<br/>
    /// Example: "=" or "!="
    /// </summary>
    public enum FilterStringTypeColumnOnCallTableOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterStringTypeColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterStringTypeColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterStringTypeColumnOnCallTableOperator.Neq => "!=",
                FilterStringTypeColumnOnCallTableOperator.Eq => "=",
                FilterStringTypeColumnOnCallTableOperator.Contains => "contains",
                FilterStringTypeColumnOnCallTableOperator.NotContains => "not_contains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterStringTypeColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => FilterStringTypeColumnOnCallTableOperator.Neq,
                "=" => FilterStringTypeColumnOnCallTableOperator.Eq,
                "contains" => FilterStringTypeColumnOnCallTableOperator.Contains,
                "not_contains" => FilterStringTypeColumnOnCallTableOperator.NotContains,
                _ => null,
            };
        }
    }
}