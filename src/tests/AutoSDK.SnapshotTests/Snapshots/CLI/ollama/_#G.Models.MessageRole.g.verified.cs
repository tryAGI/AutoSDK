﻿//HintName: G.Models.MessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageRole value)
        {
            return value switch
            {
                MessageRole.System => "system",
                MessageRole.User => "user",
                MessageRole.Assistant => "assistant",
                MessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => MessageRole.System,
                "user" => MessageRole.User,
                "assistant" => MessageRole.Assistant,
                "tool" => MessageRole.Tool,
                _ => null,
            };
        }
    }
}