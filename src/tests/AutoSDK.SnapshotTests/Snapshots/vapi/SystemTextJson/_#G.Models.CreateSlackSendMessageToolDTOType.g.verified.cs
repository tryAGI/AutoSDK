//HintName: G.Models.CreateSlackSendMessageToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "slack.message.send" for Slack Send Message tool.
    /// </summary>
    public enum CreateSlackSendMessageToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        SlackMessageSend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSlackSendMessageToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSlackSendMessageToolDTOType value)
        {
            return value switch
            {
                CreateSlackSendMessageToolDTOType.SlackMessageSend => "slack.message.send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSlackSendMessageToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "slack.message.send" => CreateSlackSendMessageToolDTOType.SlackMessageSend,
                _ => null,
            };
        }
    }
}