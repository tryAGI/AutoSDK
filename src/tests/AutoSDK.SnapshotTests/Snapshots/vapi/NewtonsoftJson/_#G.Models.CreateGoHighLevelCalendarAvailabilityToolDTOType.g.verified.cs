//HintName: G.Models.CreateGoHighLevelCalendarAvailabilityToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.availability.check" for GoHighLevel Calendar Availability Check tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGoHighLevelCalendarAvailabilityToolDTOType
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
    public static class CreateGoHighLevelCalendarAvailabilityToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoHighLevelCalendarAvailabilityToolDTOType value)
        {
            return value switch
            {
                CreateGoHighLevelCalendarAvailabilityToolDTOType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoHighLevelCalendarAvailabilityToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.availability.check" => CreateGoHighLevelCalendarAvailabilityToolDTOType.GohighlevelCalendarAvailabilityCheck,
                _ => null,
            };
        }
    }
}