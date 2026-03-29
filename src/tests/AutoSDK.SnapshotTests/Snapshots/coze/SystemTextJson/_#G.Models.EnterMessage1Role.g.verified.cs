//HintName: G.Models.EnterMessage1Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnterMessage1Role
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
    public static class EnterMessage1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterMessage1Role value)
        {
            return value switch
            {
                EnterMessage1Role.Assistant => "assistant",
                EnterMessage1Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterMessage1Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => EnterMessage1Role.Assistant,
                "user" => EnterMessage1Role.User,
                _ => null,
            };
        }
    }
}