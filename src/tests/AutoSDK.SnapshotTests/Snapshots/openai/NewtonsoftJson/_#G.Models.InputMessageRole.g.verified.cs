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
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
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
                InputMessageRole.User => "user",
                InputMessageRole.System => "system",
                InputMessageRole.Developer => "developer",
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
                "user" => InputMessageRole.User,
                "system" => InputMessageRole.System,
                "developer" => InputMessageRole.Developer,
                _ => null,
            };
        }
    }
}