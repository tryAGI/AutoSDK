//HintName: G.Models.ResponseEasyInputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message input. One of `user`, `assistant`, `system`, or `developer`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseEasyInputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
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
    public static class ResponseEasyInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEasyInputMessageRole value)
        {
            return value switch
            {
                ResponseEasyInputMessageRole.Assistant => "assistant",
                ResponseEasyInputMessageRole.Developer => "developer",
                ResponseEasyInputMessageRole.System => "system",
                ResponseEasyInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEasyInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponseEasyInputMessageRole.Assistant,
                "developer" => ResponseEasyInputMessageRole.Developer,
                "system" => ResponseEasyInputMessageRole.System,
                "user" => ResponseEasyInputMessageRole.User,
                _ => null,
            };
        }
    }
}