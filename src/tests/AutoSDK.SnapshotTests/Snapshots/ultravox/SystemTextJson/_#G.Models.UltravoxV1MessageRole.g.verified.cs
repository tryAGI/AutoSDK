//HintName: G.Models.UltravoxV1MessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The message's role.
    /// </summary>
    public enum UltravoxV1MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        MESSAGEROLEUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        MESSAGEROLEUSER,
        /// <summary>
        /// 
        /// </summary>
        MESSAGEROLEAGENT,
        /// <summary>
        /// 
        /// </summary>
        MESSAGEROLETOOLCALL,
        /// <summary>
        /// 
        /// </summary>
        MESSAGEROLETOOLRESULT,
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
                UltravoxV1MessageRole.MESSAGEROLEUNSPECIFIED => "MESSAGE_ROLE_UNSPECIFIED",
                UltravoxV1MessageRole.MESSAGEROLEUSER => "MESSAGE_ROLE_USER",
                UltravoxV1MessageRole.MESSAGEROLEAGENT => "MESSAGE_ROLE_AGENT",
                UltravoxV1MessageRole.MESSAGEROLETOOLCALL => "MESSAGE_ROLE_TOOL_CALL",
                UltravoxV1MessageRole.MESSAGEROLETOOLRESULT => "MESSAGE_ROLE_TOOL_RESULT",
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
                "MESSAGE_ROLE_UNSPECIFIED" => UltravoxV1MessageRole.MESSAGEROLEUNSPECIFIED,
                "MESSAGE_ROLE_USER" => UltravoxV1MessageRole.MESSAGEROLEUSER,
                "MESSAGE_ROLE_AGENT" => UltravoxV1MessageRole.MESSAGEROLEAGENT,
                "MESSAGE_ROLE_TOOL_CALL" => UltravoxV1MessageRole.MESSAGEROLETOOLCALL,
                "MESSAGE_ROLE_TOOL_RESULT" => UltravoxV1MessageRole.MESSAGEROLETOOLRESULT,
                _ => null,
            };
        }
    }
}