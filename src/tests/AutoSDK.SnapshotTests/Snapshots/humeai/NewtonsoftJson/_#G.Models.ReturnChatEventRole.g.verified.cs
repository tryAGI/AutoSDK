//HintName: G.Models.ReturnChatEventRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReturnChatEventRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASSISTANT")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYSTEM")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOOL")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnChatEventRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnChatEventRole value)
        {
            return value switch
            {
                ReturnChatEventRole.Assistant => "ASSISTANT",
                ReturnChatEventRole.System => "SYSTEM",
                ReturnChatEventRole.Tool => "TOOL",
                ReturnChatEventRole.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnChatEventRole? ToEnum(string value)
        {
            return value switch
            {
                "ASSISTANT" => ReturnChatEventRole.Assistant,
                "SYSTEM" => ReturnChatEventRole.System,
                "TOOL" => ReturnChatEventRole.Tool,
                "USER" => ReturnChatEventRole.User,
                _ => null,
            };
        }
    }
}