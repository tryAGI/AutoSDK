//HintName: G.Models.SortParamsForRunsComparisonViewSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: DESC
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SortParamsForRunsComparisonViewSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASC")]
        ASC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESC")]
        DESC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortParamsForRunsComparisonViewSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortParamsForRunsComparisonViewSortOrder value)
        {
            return value switch
            {
                SortParamsForRunsComparisonViewSortOrder.ASC => "ASC",
                SortParamsForRunsComparisonViewSortOrder.DESC => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortParamsForRunsComparisonViewSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => SortParamsForRunsComparisonViewSortOrder.ASC,
                "DESC" => SortParamsForRunsComparisonViewSortOrder.DESC,
                _ => null,
            };
        }
    }
}