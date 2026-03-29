//HintName: G.Models.CreateSlackSendMessageToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "slack.message.send" for Slack Send Message tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSlackSendMessageToolDTOType
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