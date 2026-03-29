//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image" => ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type.Image,
                _ => null,
            };
        }
    }
}