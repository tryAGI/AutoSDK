//HintName: G.Models.ChatToolMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatToolMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatToolMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatToolMessageRole value)
        {
            return value switch
            {
                ChatToolMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatToolMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatToolMessageRole.Tool,
                _ => null,
            };
        }
    }
}