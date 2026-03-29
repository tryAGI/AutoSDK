//HintName: G.Models.ProjectMetricResponsePublicInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectMetricResponsePublicInterval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DAILY")]
        Daily,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HOURLY")]
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOTAL")]
        Total,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WEEKLY")]
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectMetricResponsePublicIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMetricResponsePublicInterval value)
        {
            return value switch
            {
                ProjectMetricResponsePublicInterval.Daily => "DAILY",
                ProjectMetricResponsePublicInterval.Hourly => "HOURLY",
                ProjectMetricResponsePublicInterval.Total => "TOTAL",
                ProjectMetricResponsePublicInterval.Weekly => "WEEKLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMetricResponsePublicInterval? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => ProjectMetricResponsePublicInterval.Daily,
                "HOURLY" => ProjectMetricResponsePublicInterval.Hourly,
                "TOTAL" => ProjectMetricResponsePublicInterval.Total,
                "WEEKLY" => ProjectMetricResponsePublicInterval.Weekly,
                _ => null,
            };
        }
    }
}