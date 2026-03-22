//HintName: G.Models.ReposGetRepoRuleSuitesTimePeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: day
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposGetRepoRuleSuitesTimePeriod
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