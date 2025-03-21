//HintName: G.Models.EasyInputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message input. One of `user`, `assistant`, `system`, or<br/>
    /// `developer`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EasyInputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
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
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRole value)
        {
            return value switch
            {
                EasyInputMessageRole.User => "user",
                EasyInputMessageRole.Assistant => "assistant",
                EasyInputMessageRole.System => "system",
                EasyInputMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => EasyInputMessageRole.User,
                "assistant" => EasyInputMessageRole.Assistant,
                "system" => EasyInputMessageRole.System,
                "developer" => EasyInputMessageRole.Developer,
                _ => null,
            };
        }
    }
}