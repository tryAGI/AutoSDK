﻿//HintName: G.Models.MessageStreamEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of a streaming event.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStreamEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_start")]
        MessageStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_delta")]
        MessageDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_stop")]
        MessageStop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_start")]
        ContentBlockStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_delta")]
        ContentBlockDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_stop")]
        ContentBlockStop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ping")]
        Ping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventType value)
        {
            return value switch
            {
                MessageStreamEventType.MessageStart => "message_start",
                MessageStreamEventType.MessageDelta => "message_delta",
                MessageStreamEventType.MessageStop => "message_stop",
                MessageStreamEventType.ContentBlockStart => "content_block_start",
                MessageStreamEventType.ContentBlockDelta => "content_block_delta",
                MessageStreamEventType.ContentBlockStop => "content_block_stop",
                MessageStreamEventType.Ping => "ping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_start" => MessageStreamEventType.MessageStart,
                "message_delta" => MessageStreamEventType.MessageDelta,
                "message_stop" => MessageStreamEventType.MessageStop,
                "content_block_start" => MessageStreamEventType.ContentBlockStart,
                "content_block_delta" => MessageStreamEventType.ContentBlockDelta,
                "content_block_stop" => MessageStreamEventType.ContentBlockStop,
                "ping" => MessageStreamEventType.Ping,
                _ => null,
            };
        }
    }
}