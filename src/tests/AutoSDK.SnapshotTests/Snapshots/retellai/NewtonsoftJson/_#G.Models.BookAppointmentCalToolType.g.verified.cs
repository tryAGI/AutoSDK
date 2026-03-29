//HintName: G.Models.BookAppointmentCalToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BookAppointmentCalToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="book_appointment_cal")]
        BookAppointmentCal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BookAppointmentCalToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BookAppointmentCalToolType value)
        {
            return value switch
            {
                BookAppointmentCalToolType.BookAppointmentCal => "book_appointment_cal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BookAppointmentCalToolType? ToEnum(string value)
        {
            return value switch
            {
                "book_appointment_cal" => BookAppointmentCalToolType.BookAppointmentCal,
                _ => null,
            };
        }
    }
}