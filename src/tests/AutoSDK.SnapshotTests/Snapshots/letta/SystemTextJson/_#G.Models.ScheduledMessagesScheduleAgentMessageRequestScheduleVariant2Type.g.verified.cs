//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Recurring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type.Recurring => "recurring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "recurring" => ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type.Recurring,
                _ => null,
            };
        }
    }
}