//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        OneTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type.OneTime => "one-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "one-time" => ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type.OneTime,
                _ => null,
            };
        }
    }
}