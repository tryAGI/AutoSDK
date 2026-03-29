//HintName: G.Models.FilterStringArrayTypeColumnOnCallTableOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// The operator must be `in` or `not_in`.<br/>
    /// Example: "in" or "not_in"
    /// </summary>
    public enum FilterStringArrayTypeColumnOnCallTableOperator
    {
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
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterStringArrayTypeColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterStringArrayTypeColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterStringArrayTypeColumnOnCallTableOperator.In => "in",
                FilterStringArrayTypeColumnOnCallTableOperator.IsEmpty => "is_empty",
                FilterStringArrayTypeColumnOnCallTableOperator.IsNotEmpty => "is_not_empty",
                FilterStringArrayTypeColumnOnCallTableOperator.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterStringArrayTypeColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "in" => FilterStringArrayTypeColumnOnCallTableOperator.In,
                "is_empty" => FilterStringArrayTypeColumnOnCallTableOperator.IsEmpty,
                "is_not_empty" => FilterStringArrayTypeColumnOnCallTableOperator.IsNotEmpty,
                "not_in" => FilterStringArrayTypeColumnOnCallTableOperator.NotIn,
                _ => null,
            };
        }
    }
}