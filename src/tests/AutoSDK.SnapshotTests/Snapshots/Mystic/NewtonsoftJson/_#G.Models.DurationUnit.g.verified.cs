//HintName: G.Models.DurationUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DurationUnit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="seconds")]
        Seconds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minutes")]
        Minutes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hours")]
        Hours,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="days")]
        Days,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weeks")]
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
                DurationUnit.Seconds => "seconds",
                DurationUnit.Minutes => "minutes",
                DurationUnit.Hours => "hours",
                DurationUnit.Days => "days",
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
                "seconds" => DurationUnit.Seconds,
                "minutes" => DurationUnit.Minutes,
                "hours" => DurationUnit.Hours,
                "days" => DurationUnit.Days,
                "weeks" => DurationUnit.Weeks,
                _ => null,
            };
        }
    }
}