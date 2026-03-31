//HintName: G.Models.IChatPayloadMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IChatPayloadMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
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