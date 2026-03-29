//HintName: G.Models.GoHighLevelCalendarEventCreateToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.event.create" for GoHighLevel Calendar event create tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelCalendarEventCreateToolProviderDetailsType
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
    public static class GoHighLevelCalendarEventCreateToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelCalendarEventCreateToolProviderDetailsType value)
        {
            return value switch
            {
                GoHighLevelCalendarEventCreateToolProviderDetailsType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelCalendarEventCreateToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.event.create" => GoHighLevelCalendarEventCreateToolProviderDetailsType.GohighlevelCalendarEventCreate,
                _ => null,
            };
        }
    }
}