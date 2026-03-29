//HintName: G.Models.ChatEvalUserMessageMockRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message author.<br/>
    /// For a mock user message, the role is always 'user'<br/>
    /// @default 'user'<br/>
    /// Default Value: user
    /// </summary>
    public enum ChatEvalUserMessageMockRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatEvalUserMessageMockRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEvalUserMessageMockRole value)
        {
            return value switch
            {
                ChatEvalUserMessageMockRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEvalUserMessageMockRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatEvalUserMessageMockRole.User,
                _ => null,
            };
        }
    }
}