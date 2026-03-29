//HintName: G.Models.EnterMessage2Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// user / assistant
    /// </summary>
    public enum EnterMessage2Role
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterMessage2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterMessage2Role value)
        {
            return value switch
            {
                EnterMessage2Role.Assistant => "assistant",
                EnterMessage2Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterMessage2Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => EnterMessage2Role.Assistant,
                "user" => EnterMessage2Role.User,
                _ => null,
            };
        }
    }
}