//HintName: G.Models.GoogleCalendarCreateEventToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.calendar.event.create" for Google Calendar Create Event tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleCalendarCreateEventToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.event.create")]
        GoogleCalendarEventCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleCalendarCreateEventToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleCalendarCreateEventToolType value)
        {
            return value switch
            {
                GoogleCalendarCreateEventToolType.GoogleCalendarEventCreate => "google.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleCalendarCreateEventToolType? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.event.create" => GoogleCalendarCreateEventToolType.GoogleCalendarEventCreate,
                _ => null,
            };
        }
    }
}