//HintName: G.Models.MessageStreamEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageStart,
        /// <summary>
        /// 
        /// </summary>
        MessageDelta,
        /// <summary>
        /// 
        /// </summary>
        MessageStop,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockStart,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockDelta,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockStop,
        /// <summary>
        /// 
        /// </summary>
        Ping,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventDiscriminatorType value)
        {
            return value switch
            {
                MessageStreamEventDiscriminatorType.MessageStart => "message_start",
                MessageStreamEventDiscriminatorType.MessageDelta => "message_delta",
                MessageStreamEventDiscriminatorType.MessageStop => "message_stop",
                MessageStreamEventDiscriminatorType.ContentBlockStart => "content_block_start",
                MessageStreamEventDiscriminatorType.ContentBlockDelta => "content_block_delta",
                MessageStreamEventDiscriminatorType.ContentBlockStop => "content_block_stop",
                MessageStreamEventDiscriminatorType.Ping => "ping",
                MessageStreamEventDiscriminatorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message_start" => MessageStreamEventDiscriminatorType.MessageStart,
                "message_delta" => MessageStreamEventDiscriminatorType.MessageDelta,
                "message_stop" => MessageStreamEventDiscriminatorType.MessageStop,
                "content_block_start" => MessageStreamEventDiscriminatorType.ContentBlockStart,
                "content_block_delta" => MessageStreamEventDiscriminatorType.ContentBlockDelta,
                "content_block_stop" => MessageStreamEventDiscriminatorType.ContentBlockStop,
                "ping" => MessageStreamEventDiscriminatorType.Ping,
                "error" => MessageStreamEventDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}