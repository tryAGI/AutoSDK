//HintName: G.Models.GoogleCalendarCheckAvailabilityToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.calendar.availability.check" for Google Calendar Check Availability tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleCalendarCheckAvailabilityToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.availability.check")]
        GoogleCalendarAvailabilityCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleCalendarCheckAvailabilityToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleCalendarCheckAvailabilityToolType value)
        {
            return value switch
            {
                GoogleCalendarCheckAvailabilityToolType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleCalendarCheckAvailabilityToolType? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.availability.check" => GoogleCalendarCheckAvailabilityToolType.GoogleCalendarAvailabilityCheck,
                _ => null,
            };
        }
    }
}