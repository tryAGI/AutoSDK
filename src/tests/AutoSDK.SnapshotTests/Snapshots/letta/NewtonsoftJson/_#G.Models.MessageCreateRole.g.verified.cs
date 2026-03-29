//HintName: G.Models.MessageCreateRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the participant.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageCreateRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageCreateRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageCreateRole value)
        {
            return value switch
            {
                MessageCreateRole.Assistant => "assistant",
                MessageCreateRole.System => "system",
                MessageCreateRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageCreateRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageCreateRole.Assistant,
                "system" => MessageCreateRole.System,
                "user" => MessageCreateRole.User,
                _ => null,
            };
        }
    }
}