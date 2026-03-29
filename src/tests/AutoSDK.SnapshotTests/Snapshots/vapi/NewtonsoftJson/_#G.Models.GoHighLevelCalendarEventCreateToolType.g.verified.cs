//HintName: G.Models.GoHighLevelCalendarEventCreateToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.event.create" for GoHighLevel Calendar Event Create tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelCalendarEventCreateToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.calendar.event.create")]
        GohighlevelCalendarEventCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelCalendarEventCreateToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelCalendarEventCreateToolType value)
        {
            return value switch
            {
                GoHighLevelCalendarEventCreateToolType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelCalendarEventCreateToolType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.event.create" => GoHighLevelCalendarEventCreateToolType.GohighlevelCalendarEventCreate,
                _ => null,
            };
        }
    }
}