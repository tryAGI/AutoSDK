//HintName: G.Models.MessageTargetRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message to target.<br/>
    /// If not specified, will find the position in the message history ignoring role (effectively `any`).<br/>
    /// Example: user
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageTargetRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageTargetRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageTargetRole value)
        {
            return value switch
            {
                MessageTargetRole.Assistant => "assistant",
                MessageTargetRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageTargetRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageTargetRole.Assistant,
                "user" => MessageTargetRole.User,
                _ => null,
            };
        }
    }
}