//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesScheduleAgentMessageRequestMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesScheduleAgentMessageRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestMessageRole value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestMessageRole.Assistant => "assistant",
                ScheduledMessagesScheduleAgentMessageRequestMessageRole.System => "system",
                ScheduledMessagesScheduleAgentMessageRequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ScheduledMessagesScheduleAgentMessageRequestMessageRole.Assistant,
                "system" => ScheduledMessagesScheduleAgentMessageRequestMessageRole.System,
                "user" => ScheduledMessagesScheduleAgentMessageRequestMessageRole.User,
                _ => null,
            };
        }
    }
}