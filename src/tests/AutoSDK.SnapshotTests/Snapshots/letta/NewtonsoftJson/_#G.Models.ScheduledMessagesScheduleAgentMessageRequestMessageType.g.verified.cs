//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesScheduleAgentMessageRequestMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesScheduleAgentMessageRequestMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestMessageType value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ScheduledMessagesScheduleAgentMessageRequestMessageType.Message,
                _ => null,
            };
        }
    }
}