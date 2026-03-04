//HintName: G.Models.UltravoxV1MessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The message's role.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_ROLE_UNSPECIFIED")]
        MessageRoleUnspecified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_ROLE_USER")]
        MessageRoleUser,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_ROLE_AGENT")]
        MessageRoleAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_ROLE_TOOL_CALL")]
        MessageRoleToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_ROLE_TOOL_RESULT")]
        MessageRoleToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1MessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1MessageRole value)
        {
            return value switch
            {
                UltravoxV1MessageRole.MessageRoleUnspecified => "MESSAGE_ROLE_UNSPECIFIED",
                UltravoxV1MessageRole.MessageRoleUser => "MESSAGE_ROLE_USER",
                UltravoxV1MessageRole.MessageRoleAgent => "MESSAGE_ROLE_AGENT",
                UltravoxV1MessageRole.MessageRoleToolCall => "MESSAGE_ROLE_TOOL_CALL",
                UltravoxV1MessageRole.MessageRoleToolResult => "MESSAGE_ROLE_TOOL_RESULT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1MessageRole? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_ROLE_UNSPECIFIED" => UltravoxV1MessageRole.MessageRoleUnspecified,
                "MESSAGE_ROLE_USER" => UltravoxV1MessageRole.MessageRoleUser,
                "MESSAGE_ROLE_AGENT" => UltravoxV1MessageRole.MessageRoleAgent,
                "MESSAGE_ROLE_TOOL_CALL" => UltravoxV1MessageRole.MessageRoleToolCall,
                "MESSAGE_ROLE_TOOL_RESULT" => UltravoxV1MessageRole.MessageRoleToolResult,
                _ => null,
            };
        }
    }
}