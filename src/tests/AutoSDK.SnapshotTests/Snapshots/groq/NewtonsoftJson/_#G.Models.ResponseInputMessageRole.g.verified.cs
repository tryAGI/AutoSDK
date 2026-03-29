//HintName: G.Models.ResponseInputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message input. One of `user`, `system`, or `developer`. Note: assistant role is not supported with explicit type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseInputMessageRole
    {
        /// <summary>
        /// assistant role is not supported with explicit type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// assistant role is not supported with explicit type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// assistant role is not supported with explicit type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputMessageRole value)
        {
            return value switch
            {
                ResponseInputMessageRole.Developer => "developer",
                ResponseInputMessageRole.System => "system",
                ResponseInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ResponseInputMessageRole.Developer,
                "system" => ResponseInputMessageRole.System,
                "user" => ResponseInputMessageRole.User,
                _ => null,
            };
        }
    }
}