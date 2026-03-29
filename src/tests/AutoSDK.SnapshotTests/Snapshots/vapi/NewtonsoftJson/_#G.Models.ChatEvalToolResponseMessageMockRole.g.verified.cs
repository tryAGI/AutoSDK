//HintName: G.Models.ChatEvalToolResponseMessageMockRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message author.<br/>
    /// For a mock tool response message, the role is always 'tool'<br/>
    /// @default 'tool'<br/>
    /// Default Value: tool
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatEvalToolResponseMessageMockRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatEvalToolResponseMessageMockRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEvalToolResponseMessageMockRole value)
        {
            return value switch
            {
                ChatEvalToolResponseMessageMockRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEvalToolResponseMessageMockRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatEvalToolResponseMessageMockRole.Tool,
                _ => null,
            };
        }
    }
}