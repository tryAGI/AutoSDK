//HintName: G.Models.GoHighLevelCalendarEventCreateToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.event.create" for GoHighLevel Calendar Event Create tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelCalendarEventCreateToolWithToolCallType
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
    public static class GoHighLevelCalendarEventCreateToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelCalendarEventCreateToolWithToolCallType value)
        {
            return value switch
            {
                GoHighLevelCalendarEventCreateToolWithToolCallType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelCalendarEventCreateToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.event.create" => GoHighLevelCalendarEventCreateToolWithToolCallType.GohighlevelCalendarEventCreate,
                _ => null,
            };
        }
    }
}