//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType value)
        {
            return value switch
            {
                ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType.Base64,
                _ => null,
            };
        }
    }
}