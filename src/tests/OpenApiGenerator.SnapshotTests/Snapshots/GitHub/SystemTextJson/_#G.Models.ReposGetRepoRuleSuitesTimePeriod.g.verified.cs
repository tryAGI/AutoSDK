//HintName: G.Models.ReposGetRepoRuleSuitesTimePeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: day
    /// </summary>
    public enum ReposGetRepoRuleSuitesTimePeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Hour,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetRepoRuleSuitesTimePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetRepoRuleSuitesTimePeriod value)
        {
            return value switch
            {
                ReposGetRepoRuleSuitesTimePeriod.Hour => "hour",
                ReposGetRepoRuleSuitesTimePeriod.Day => "day",
                ReposGetRepoRuleSuitesTimePeriod.Week => "week",
                ReposGetRepoRuleSuitesTimePeriod.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetRepoRuleSuitesTimePeriod ToEnum(string value)
        {
            return value switch
            {
                "hour" => ReposGetRepoRuleSuitesTimePeriod.Hour,
                "day" => ReposGetRepoRuleSuitesTimePeriod.Day,
                "week" => ReposGetRepoRuleSuitesTimePeriod.Week,
                "month" => ReposGetRepoRuleSuitesTimePeriod.Month,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}