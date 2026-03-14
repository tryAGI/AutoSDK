//HintName: G.Models.IntervalScheduleConfigurationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of schedule.<br/>
    /// Example: interval
    /// </summary>
    public enum IntervalScheduleConfigurationType
    {
        /// <summary>
        /// 
        /// </summary>
        Interval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntervalScheduleConfigurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntervalScheduleConfigurationType value)
        {
            return value switch
            {
                IntervalScheduleConfigurationType.Interval => "interval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntervalScheduleConfigurationType? ToEnum(string value)
        {
            return value switch
            {
                "interval" => IntervalScheduleConfigurationType.Interval,
                _ => null,
            };
        }
    }
}