//HintName: G.Models.IChatPayloadMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IChatPayloadMessageRole
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
    public static class IChatPayloadMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IChatPayloadMessageRole value)
        {
            return value switch
            {
                IChatPayloadMessageRole.Assistant => "assistant",
                IChatPayloadMessageRole.System => "system",
                IChatPayloadMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IChatPayloadMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => IChatPayloadMessageRole.Assistant,
                "system" => IChatPayloadMessageRole.System,
                "user" => IChatPayloadMessageRole.User,
                _ => null,
            };
        }
    }
}