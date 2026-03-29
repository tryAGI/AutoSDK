//HintName: G.Models.FilterNumberArrayTypeColumnOnCallTableOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// The operator must be `in` or `not_in`.<br/>
    /// Example: "in" or "not_in"
    /// </summary>
    public enum FilterNumberArrayTypeColumnOnCallTableOperator
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
    public static class FilterNumberArrayTypeColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterNumberArrayTypeColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterNumberArrayTypeColumnOnCallTableOperator.In => "in",
                FilterNumberArrayTypeColumnOnCallTableOperator.IsEmpty => "is_empty",
                FilterNumberArrayTypeColumnOnCallTableOperator.IsNotEmpty => "is_not_empty",
                FilterNumberArrayTypeColumnOnCallTableOperator.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterNumberArrayTypeColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "in" => FilterNumberArrayTypeColumnOnCallTableOperator.In,
                "is_empty" => FilterNumberArrayTypeColumnOnCallTableOperator.IsEmpty,
                "is_not_empty" => FilterNumberArrayTypeColumnOnCallTableOperator.IsNotEmpty,
                "not_in" => FilterNumberArrayTypeColumnOnCallTableOperator.NotIn,
                _ => null,
            };
        }
    }
}