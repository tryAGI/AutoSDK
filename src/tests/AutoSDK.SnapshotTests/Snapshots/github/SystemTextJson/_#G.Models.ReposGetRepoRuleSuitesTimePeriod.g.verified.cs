//HintName: G.Models.ReposGetRepoRuleSuitesTimePeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: day
    /// </summary>
    public enum ReposGetRepoRuleSuitesTimePeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
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
                ReposGetRepoRuleSuitesTimePeriod.Day => "day",
                ReposGetRepoRuleSuitesTimePeriod.Hour => "hour",
                ReposGetRepoRuleSuitesTimePeriod.Month => "month",
                ReposGetRepoRuleSuitesTimePeriod.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetRepoRuleSuitesTimePeriod? ToEnum(string value)
        {
            return value switch
            {
                "day" => ReposGetRepoRuleSuitesTimePeriod.Day,
                "hour" => ReposGetRepoRuleSuitesTimePeriod.Hour,
                "month" => ReposGetRepoRuleSuitesTimePeriod.Month,
                "week" => ReposGetRepoRuleSuitesTimePeriod.Week,
                _ => null,
            };
        }
    }
}