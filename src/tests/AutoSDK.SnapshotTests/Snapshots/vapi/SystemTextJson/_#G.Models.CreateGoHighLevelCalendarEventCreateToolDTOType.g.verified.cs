//HintName: G.Models.CreateGoHighLevelCalendarEventCreateToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.event.create" for GoHighLevel Calendar Event Create tool.
    /// </summary>
    public enum CreateGoHighLevelCalendarEventCreateToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelCalendarEventCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoHighLevelCalendarEventCreateToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoHighLevelCalendarEventCreateToolDTOType value)
        {
            return value switch
            {
                CreateGoHighLevelCalendarEventCreateToolDTOType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoHighLevelCalendarEventCreateToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.event.create" => CreateGoHighLevelCalendarEventCreateToolDTOType.GohighlevelCalendarEventCreate,
                _ => null,
            };
        }
    }
}