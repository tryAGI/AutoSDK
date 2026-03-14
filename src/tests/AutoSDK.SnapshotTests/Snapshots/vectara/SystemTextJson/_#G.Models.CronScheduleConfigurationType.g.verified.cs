//HintName: G.Models.CronScheduleConfigurationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of schedule.<br/>
    /// Example: cron
    /// </summary>
    public enum CronScheduleConfigurationType
    {
        /// <summary>
        /// 
        /// </summary>
        Cron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CronScheduleConfigurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CronScheduleConfigurationType value)
        {
            return value switch
            {
                CronScheduleConfigurationType.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CronScheduleConfigurationType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => CronScheduleConfigurationType.Cron,
                _ => null,
            };
        }
    }
}