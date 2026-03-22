//HintName: G.Models.EasyInputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message input. One of `user`, `assistant`, `system`, or<br/>
    /// `developer`.
    /// </summary>
    public enum EasyInputMessageRole
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
    public static class EasyInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRole value)
        {
            return value switch
            {
                EasyInputMessageRole.Assistant => "assistant",
                EasyInputMessageRole.Developer => "developer",
                EasyInputMessageRole.System => "system",
                EasyInputMessageRole.User => "user",
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
                "assistant" => EasyInputMessageRole.Assistant,
                "developer" => EasyInputMessageRole.Developer,
                "system" => EasyInputMessageRole.System,
                "user" => EasyInputMessageRole.User,
                _ => null,
            };
        }
    }
}