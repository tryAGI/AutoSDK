//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesScheduleAgentMessageRequestMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
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