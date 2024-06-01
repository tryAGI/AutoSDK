//HintName: G.Models.ReposListActivitiesTimePeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposListActivitiesTimePeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Quarter,
        /// <summary>
        /// 
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListActivitiesTimePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListActivitiesTimePeriod value)
        {
            return value switch
            {
                ReposListActivitiesTimePeriod.Day => "day",
                ReposListActivitiesTimePeriod.Week => "week",
                ReposListActivitiesTimePeriod.Month => "month",
                ReposListActivitiesTimePeriod.Quarter => "quarter",
                ReposListActivitiesTimePeriod.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListActivitiesTimePeriod ToEnum(string value)
        {
            return value switch
            {
                "day" => ReposListActivitiesTimePeriod.Day,
                "week" => ReposListActivitiesTimePeriod.Week,
                "month" => ReposListActivitiesTimePeriod.Month,
                "quarter" => ReposListActivitiesTimePeriod.Quarter,
                "year" => ReposListActivitiesTimePeriod.Year,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}