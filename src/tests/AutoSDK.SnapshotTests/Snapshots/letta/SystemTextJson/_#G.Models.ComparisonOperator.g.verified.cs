//HintName: G.Models.ComparisonOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operators for filtering numeric values
    /// </summary>
    public enum ComparisonOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComparisonOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComparisonOperator value)
        {
            return value switch
            {
                ComparisonOperator.Eq => "eq",
                ComparisonOperator.Gte => "gte",
                ComparisonOperator.Lte => "lte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComparisonOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ComparisonOperator.Eq,
                "gte" => ComparisonOperator.Gte,
                "lte" => ComparisonOperator.Lte,
                _ => null,
            };
        }
    }
}