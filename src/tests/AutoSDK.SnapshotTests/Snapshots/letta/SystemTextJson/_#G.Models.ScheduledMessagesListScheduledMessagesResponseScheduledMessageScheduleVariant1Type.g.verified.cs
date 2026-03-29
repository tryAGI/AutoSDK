//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        OneTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type value)
        {
            return value switch
            {
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type.OneTime => "one-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "one-time" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type.OneTime,
                _ => null,
            };
        }
    }
}