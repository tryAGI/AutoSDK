//HintName: G.Models.ResponseRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRole
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
    public static class ResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRole value)
        {
            return value switch
            {
                ResponseRole.Assistant => "assistant",
                ResponseRole.Developer => "developer",
                ResponseRole.System => "system",
                ResponseRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponseRole.Assistant,
                "developer" => ResponseRole.Developer,
                "system" => ResponseRole.System,
                "user" => ResponseRole.User,
                _ => null,
            };
        }
    }
}