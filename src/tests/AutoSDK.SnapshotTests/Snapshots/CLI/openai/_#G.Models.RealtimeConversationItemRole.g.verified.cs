﻿//HintName: G.Models.RealtimeConversationItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message sender (`user`, `assistant`, `system`), only <br/>
    /// applicable for `message` items.
    /// </summary>
    public enum RealtimeConversationItemRole
    {
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
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemRole value)
        {
            return value switch
            {
                RealtimeConversationItemRole.User => "user",
                RealtimeConversationItemRole.Assistant => "assistant",
                RealtimeConversationItemRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => RealtimeConversationItemRole.User,
                "assistant" => RealtimeConversationItemRole.Assistant,
                "system" => RealtimeConversationItemRole.System,
                _ => null,
            };
        }
    }
}