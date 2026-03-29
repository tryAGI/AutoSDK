//HintName: G.Models.ChatDeveloperMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatDeveloperMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatDeveloperMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDeveloperMessageRole value)
        {
            return value switch
            {
                ChatDeveloperMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDeveloperMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ChatDeveloperMessageRole.Developer,
                _ => null,
            };
        }
    }
}