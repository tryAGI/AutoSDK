//HintName: G.Models.ChatEvalSystemMessageMockRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message author.<br/>
    /// For a mock system message, the role is always 'system'<br/>
    /// @default 'system'<br/>
    /// Default Value: system
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatEvalSystemMessageMockRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatEvalSystemMessageMockRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEvalSystemMessageMockRole value)
        {
            return value switch
            {
                ChatEvalSystemMessageMockRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEvalSystemMessageMockRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatEvalSystemMessageMockRole.System,
                _ => null,
            };
        }
    }
}