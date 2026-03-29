//HintName: G.Models.ProjectMetricResponsePublicInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectMetricResponsePublicInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Total,
        /// <summary>
        /// 
        /// </summary>
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