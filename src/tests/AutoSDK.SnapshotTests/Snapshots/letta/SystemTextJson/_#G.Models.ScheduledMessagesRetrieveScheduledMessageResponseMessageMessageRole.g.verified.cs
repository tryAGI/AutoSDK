//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole
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
    public static class ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole value)
        {
            return value switch
            {
                ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole.Assistant => "assistant",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole.System => "system",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole.Assistant,
                "system" => ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole.System,
                "user" => ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole.User,
                _ => null,
            };
        }
    }
}