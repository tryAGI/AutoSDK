//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type.Text,
                _ => null,
            };
        }
    }
}