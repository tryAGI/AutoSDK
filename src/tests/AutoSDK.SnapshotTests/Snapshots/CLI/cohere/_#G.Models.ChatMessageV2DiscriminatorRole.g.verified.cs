﻿//HintName: G.Models.ChatMessageV2DiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessageV2DiscriminatorRole
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
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageV2DiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageV2DiscriminatorRole value)
        {
            return value switch
            {
                ChatMessageV2DiscriminatorRole.Assistant => "assistant",
                ChatMessageV2DiscriminatorRole.System => "system",
                ChatMessageV2DiscriminatorRole.Tool => "tool",
                ChatMessageV2DiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageV2DiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageV2DiscriminatorRole.Assistant,
                "system" => ChatMessageV2DiscriminatorRole.System,
                "tool" => ChatMessageV2DiscriminatorRole.Tool,
                "user" => ChatMessageV2DiscriminatorRole.User,
                _ => null,
            };
        }
    }
}