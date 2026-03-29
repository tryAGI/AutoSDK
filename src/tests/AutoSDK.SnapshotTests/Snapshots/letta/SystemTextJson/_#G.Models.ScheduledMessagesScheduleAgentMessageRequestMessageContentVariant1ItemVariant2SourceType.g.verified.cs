//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType.Base64,
                _ => null,
            };
        }
    }
}