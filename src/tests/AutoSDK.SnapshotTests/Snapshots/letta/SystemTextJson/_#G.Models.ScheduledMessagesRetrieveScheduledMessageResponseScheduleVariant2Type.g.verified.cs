//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Recurring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type value)
        {
            return value switch
            {
                ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type.Recurring => "recurring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "recurring" => ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type.Recurring,
                _ => null,
            };
        }
    }
}