//HintName: G.Models.ChatRole.g.cs

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
        Chatbot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYSTEM")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOOL")]
        Tool,
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
                ChatRole.Chatbot => "CHATBOT",
                ChatRole.System => "SYSTEM",
                ChatRole.User => "USER",
                ChatRole.Tool => "TOOL",
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
                "CHATBOT" => ChatRole.Chatbot,
                "SYSTEM" => ChatRole.System,
                "USER" => ChatRole.User,
                "TOOL" => ChatRole.Tool,
                _ => null,
            };
        }
    }
}