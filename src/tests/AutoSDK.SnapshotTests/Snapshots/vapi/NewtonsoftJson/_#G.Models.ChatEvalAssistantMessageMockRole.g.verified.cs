//HintName: G.Models.ChatEvalAssistantMessageMockRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message author.<br/>
    /// For a mock assistant message, the role is always 'assistant'<br/>
    /// @default 'assistant'<br/>
    /// Default Value: assistant
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatEvalAssistantMessageMockRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatEvalAssistantMessageMockRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEvalAssistantMessageMockRole value)
        {
            return value switch
            {
                ChatEvalAssistantMessageMockRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEvalAssistantMessageMockRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatEvalAssistantMessageMockRole.Assistant,
                _ => null,
            };
        }
    }
}