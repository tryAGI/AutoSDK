//HintName: G.Models.InputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message input. One of `user`, `system`, or `developer`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
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
    public static class InputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageRole value)
        {
            return value switch
            {
                InputMessageRole.Developer => "developer",
                InputMessageRole.System => "system",
                InputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => InputMessageRole.Developer,
                "system" => InputMessageRole.System,
                "user" => InputMessageRole.User,
                _ => null,
            };
        }
    }
}