//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one-time")]
        OneTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type value)
        {
            return value switch
            {
                ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type.OneTime => "one-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "one-time" => ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type.OneTime,
                _ => null,
            };
        }
    }
}