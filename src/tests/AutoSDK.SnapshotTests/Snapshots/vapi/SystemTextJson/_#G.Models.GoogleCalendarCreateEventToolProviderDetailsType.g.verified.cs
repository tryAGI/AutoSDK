//HintName: G.Models.GoogleCalendarCreateEventToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.calendar.event.create" for Google Calendar tool.
    /// </summary>
    public enum GoogleCalendarCreateEventToolProviderDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarEventCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleCalendarCreateEventToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleCalendarCreateEventToolProviderDetailsType value)
        {
            return value switch
            {
                GoogleCalendarCreateEventToolProviderDetailsType.GoogleCalendarEventCreate => "google.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleCalendarCreateEventToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.event.create" => GoogleCalendarCreateEventToolProviderDetailsType.GoogleCalendarEventCreate,
                _ => null,
            };
        }
    }
}