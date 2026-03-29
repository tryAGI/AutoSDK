//HintName: G.Models.ProjectMetricRequestPublicInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectMetricRequestPublicInterval
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
    public static class ProjectMetricRequestPublicIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMetricRequestPublicInterval value)
        {
            return value switch
            {
                ProjectMetricRequestPublicInterval.Daily => "DAILY",
                ProjectMetricRequestPublicInterval.Hourly => "HOURLY",
                ProjectMetricRequestPublicInterval.Total => "TOTAL",
                ProjectMetricRequestPublicInterval.Weekly => "WEEKLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMetricRequestPublicInterval? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => ProjectMetricRequestPublicInterval.Daily,
                "HOURLY" => ProjectMetricRequestPublicInterval.Hourly,
                "TOTAL" => ProjectMetricRequestPublicInterval.Total,
                "WEEKLY" => ProjectMetricRequestPublicInterval.Weekly,
                _ => null,
            };
        }
    }
}