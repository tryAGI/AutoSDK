//HintName: G.Models.EvalItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message input. One of `user`, `assistant`, `system`, or<br/>
    /// `developer`.
    /// </summary>
    public enum EvalItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                EvalItemRole.Assistant => "assistant",
                EvalItemRole.Developer => "developer",
                EvalItemRole.System => "system",
                EvalItemRole.User => "user",
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
                "assistant" => EvalItemRole.Assistant,
                "developer" => EvalItemRole.Developer,
                "system" => EvalItemRole.System,
                "user" => EvalItemRole.User,
                _ => null,
            };
        }
    }
}