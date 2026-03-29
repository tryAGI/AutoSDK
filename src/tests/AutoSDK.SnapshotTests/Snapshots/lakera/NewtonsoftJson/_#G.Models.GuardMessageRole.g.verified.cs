//HintName: G.Models.GuardMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message author.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GuardMessageRole
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
    public static class GuardMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardMessageRole value)
        {
            return value switch
            {
                GuardMessageRole.Assistant => "assistant",
                GuardMessageRole.System => "system",
                GuardMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GuardMessageRole.Assistant,
                "system" => GuardMessageRole.System,
                "user" => GuardMessageRole.User,
                _ => null,
            };
        }
    }
}