//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Recurring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type value)
        {
            return value switch
            {
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type.Recurring => "recurring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "recurring" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type.Recurring,
                _ => null,
            };
        }
    }
}