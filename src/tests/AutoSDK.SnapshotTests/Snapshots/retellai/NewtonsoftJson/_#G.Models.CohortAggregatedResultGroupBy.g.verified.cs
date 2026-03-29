//HintName: G.Models.CohortAggregatedResultGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CohortAggregatedResultGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hour")]
        Hour,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortAggregatedResultGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortAggregatedResultGroupBy value)
        {
            return value switch
            {
                CohortAggregatedResultGroupBy.Day => "day",
                CohortAggregatedResultGroupBy.Hour => "hour",
                CohortAggregatedResultGroupBy.Month => "month",
                CohortAggregatedResultGroupBy.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortAggregatedResultGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "day" => CohortAggregatedResultGroupBy.Day,
                "hour" => CohortAggregatedResultGroupBy.Hour,
                "month" => CohortAggregatedResultGroupBy.Month,
                "week" => CohortAggregatedResultGroupBy.Week,
                _ => null,
            };
        }
    }
}