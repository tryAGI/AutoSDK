//HintName: G.Models.DurationUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum DurationUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Days,
        /// <summary>
        /// 
        /// </summary>
        Hours,
        /// <summary>
        /// 
        /// </summary>
        Minutes,
        /// <summary>
        /// 
        /// </summary>
        Seconds,
        /// <summary>
        /// 
        /// </summary>
        Weeks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DurationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DurationUnit value)
        {
            return value switch
            {
                DurationUnit.Days => "days",
                DurationUnit.Hours => "hours",
                DurationUnit.Minutes => "minutes",
                DurationUnit.Seconds => "seconds",
                DurationUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DurationUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DurationUnit.Days,
                "hours" => DurationUnit.Hours,
                "minutes" => DurationUnit.Minutes,
                "seconds" => DurationUnit.Seconds,
                "weeks" => DurationUnit.Weeks,
                _ => null,
            };
        }
    }
}