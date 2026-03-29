//HintName: G.Models.GoHighLevelCalendarAvailabilityToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.availability.check" for GoHighLevel Calendar availability check tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelCalendarAvailabilityToolProviderDetailsType
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
    public static class GoHighLevelCalendarAvailabilityToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelCalendarAvailabilityToolProviderDetailsType value)
        {
            return value switch
            {
                GoHighLevelCalendarAvailabilityToolProviderDetailsType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelCalendarAvailabilityToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.availability.check" => GoHighLevelCalendarAvailabilityToolProviderDetailsType.GohighlevelCalendarAvailabilityCheck,
                _ => null,
            };
        }
    }
}