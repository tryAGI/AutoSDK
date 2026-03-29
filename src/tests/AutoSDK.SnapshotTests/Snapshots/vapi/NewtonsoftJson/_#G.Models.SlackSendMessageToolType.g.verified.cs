//HintName: G.Models.SlackSendMessageToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "slack.message.send" for Slack Send Message tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SlackSendMessageToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack.message.send")]
        SlackMessageSend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SlackSendMessageToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SlackSendMessageToolType value)
        {
            return value switch
            {
                SlackSendMessageToolType.SlackMessageSend => "slack.message.send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SlackSendMessageToolType? ToEnum(string value)
        {
            return value switch
            {
                "slack.message.send" => SlackSendMessageToolType.SlackMessageSend,
                _ => null,
            };
        }
    }
}