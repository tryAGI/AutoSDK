//HintName: G.Models.GoHighLevelCalendarAvailabilityToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.availability.check" for GoHighLevel Calendar Availability Check tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelCalendarAvailabilityToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.calendar.availability.check")]
        GohighlevelCalendarAvailabilityCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelCalendarAvailabilityToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelCalendarAvailabilityToolType value)
        {
            return value switch
            {
                GoHighLevelCalendarAvailabilityToolType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelCalendarAvailabilityToolType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.availability.check" => GoHighLevelCalendarAvailabilityToolType.GohighlevelCalendarAvailabilityCheck,
                _ => null,
            };
        }
    }
}