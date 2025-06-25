﻿//HintName: G.Models.ChatCompletionRequestToolMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `tool`.
    /// </summary>
    public enum ChatCompletionRequestToolMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestToolMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestToolMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestToolMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestToolMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatCompletionRequestToolMessageRole.Tool,
                _ => null,
            };
        }
    }
}