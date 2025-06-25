//HintName: G.Models.ReposGetOrgRuleSuitesTimePeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: day
    /// </summary>
    public enum ReposGetOrgRuleSuitesTimePeriod
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
    public static class ReposGetOrgRuleSuitesTimePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetOrgRuleSuitesTimePeriod value)
        {
            return value switch
            {
                ReposGetOrgRuleSuitesTimePeriod.Hour => "hour",
                ReposGetOrgRuleSuitesTimePeriod.Day => "day",
                ReposGetOrgRuleSuitesTimePeriod.Week => "week",
                ReposGetOrgRuleSuitesTimePeriod.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetOrgRuleSuitesTimePeriod? ToEnum(string value)
        {
            return value switch
            {
                "hour" => ReposGetOrgRuleSuitesTimePeriod.Hour,
                "day" => ReposGetOrgRuleSuitesTimePeriod.Day,
                "week" => ReposGetOrgRuleSuitesTimePeriod.Week,
                "month" => ReposGetOrgRuleSuitesTimePeriod.Month,
                _ => null,
            };
        }
    }
}