﻿//HintName: G.Models.ChatRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `CHATBOT`, `SYSTEM`, `TOOL` or `USER` to identify who the message is coming from.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHATBOT")]
        CHATBOT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYSTEM")]
        SYSTEM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER")]
        USER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOOL")]
        TOOL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRole value)
        {
            return value switch
            {
                ChatRole.CHATBOT => "CHATBOT",
                ChatRole.SYSTEM => "SYSTEM",
                ChatRole.USER => "USER",
                ChatRole.TOOL => "TOOL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRole? ToEnum(string value)
        {
            return value switch
            {
                "CHATBOT" => ChatRole.CHATBOT,
                "SYSTEM" => ChatRole.SYSTEM,
                "USER" => ChatRole.USER,
                "TOOL" => ChatRole.TOOL,
                _ => null,
            };
        }
    }
}