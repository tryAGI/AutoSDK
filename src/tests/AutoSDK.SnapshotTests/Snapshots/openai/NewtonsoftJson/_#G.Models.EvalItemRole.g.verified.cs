//HintName: G.Models.EvalItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message input. One of `user`, `assistant`, `system`, or<br/>
    /// `developer`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalItemRole
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
    public static class EvalItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalItemRole value)
        {
            return value switch
            {
                EvalItemRole.User => "user",
                EvalItemRole.Assistant => "assistant",
                EvalItemRole.System => "system",
                EvalItemRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalItemRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => EvalItemRole.User,
                "assistant" => EvalItemRole.Assistant,
                "system" => EvalItemRole.System,
                "developer" => EvalItemRole.Developer,
                _ => null,
            };
        }
    }
}