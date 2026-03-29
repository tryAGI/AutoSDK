//HintName: G.Models.DayOfWeek.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Day of week. Matches server-side DayOfWeek enum.
    /// </summary>
    public enum DayOfWeek
    {
        /// <summary>
        /// 
        /// </summary>
        Friday,
        /// <summary>
        /// 
        /// </summary>
        Monday,
        /// <summary>
        /// 
        /// </summary>
        Saturday,
        /// <summary>
        /// 
        /// </summary>
        Sunday,
        /// <summary>
        /// 
        /// </summary>
        Thursday,
        /// <summary>
        /// 
        /// </summary>
        Tuesday,
        /// <summary>
        /// 
        /// </summary>
        Wednesday,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DayOfWeekExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DayOfWeek value)
        {
            return value switch
            {
                DayOfWeek.Friday => "Friday",
                DayOfWeek.Monday => "Monday",
                DayOfWeek.Saturday => "Saturday",
                DayOfWeek.Sunday => "Sunday",
                DayOfWeek.Thursday => "Thursday",
                DayOfWeek.Tuesday => "Tuesday",
                DayOfWeek.Wednesday => "Wednesday",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DayOfWeek? ToEnum(string value)
        {
            return value switch
            {
                "Friday" => DayOfWeek.Friday,
                "Monday" => DayOfWeek.Monday,
                "Saturday" => DayOfWeek.Saturday,
                "Sunday" => DayOfWeek.Sunday,
                "Thursday" => DayOfWeek.Thursday,
                "Tuesday" => DayOfWeek.Tuesday,
                "Wednesday" => DayOfWeek.Wednesday,
                _ => null,
            };
        }
    }
}