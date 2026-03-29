//HintName: G.Models.ChatRequestMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestMessageRole
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
    public static class ChatRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestMessageRole value)
        {
            return value switch
            {
                ChatRequestMessageRole.Assistant => "assistant",
                ChatRequestMessageRole.System => "system",
                ChatRequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatRequestMessageRole.Assistant,
                "system" => ChatRequestMessageRole.System,
                "user" => ChatRequestMessageRole.User,
                _ => null,
            };
        }
    }
}