//HintName: G.Models.TopicAutomationConfigEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TopicAutomationConfigEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="topic")]
        Topic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicAutomationConfigEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicAutomationConfigEventType value)
        {
            return value switch
            {
                TopicAutomationConfigEventType.Topic => "topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicAutomationConfigEventType? ToEnum(string value)
        {
            return value switch
            {
                "topic" => TopicAutomationConfigEventType.Topic,
                _ => null,
            };
        }
    }
}