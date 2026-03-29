//HintName: G.Models.CreateGoogleCalendarCheckAvailabilityToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.calendar.availability.check" for Google Calendar Check Availability tool.
    /// </summary>
    public enum CreateGoogleCalendarCheckAvailabilityToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarAvailabilityCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoogleCalendarCheckAvailabilityToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoogleCalendarCheckAvailabilityToolDTOType value)
        {
            return value switch
            {
                CreateGoogleCalendarCheckAvailabilityToolDTOType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoogleCalendarCheckAvailabilityToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.availability.check" => CreateGoogleCalendarCheckAvailabilityToolDTOType.GoogleCalendarAvailabilityCheck,
                _ => null,
            };
        }
    }
}