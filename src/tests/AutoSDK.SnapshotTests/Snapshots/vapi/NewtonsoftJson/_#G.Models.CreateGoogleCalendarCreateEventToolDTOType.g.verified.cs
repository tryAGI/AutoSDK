//HintName: G.Models.CreateGoogleCalendarCreateEventToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.calendar.event.create" for Google Calendar Create Event tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGoogleCalendarCreateEventToolDTOType
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
    public static class CreateGoogleCalendarCreateEventToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoogleCalendarCreateEventToolDTOType value)
        {
            return value switch
            {
                CreateGoogleCalendarCreateEventToolDTOType.GoogleCalendarEventCreate => "google.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoogleCalendarCreateEventToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.event.create" => CreateGoogleCalendarCreateEventToolDTOType.GoogleCalendarEventCreate,
                _ => null,
            };
        }
    }
}