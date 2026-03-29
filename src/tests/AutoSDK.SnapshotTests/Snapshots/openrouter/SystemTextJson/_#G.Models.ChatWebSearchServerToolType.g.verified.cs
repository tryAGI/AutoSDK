//HintName: G.Models.ChatWebSearchServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatWebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchServerToolType value)
        {
            return value switch
            {
                ChatWebSearchServerToolType.Openrouter_webSearch => "openrouter:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:web_search" => ChatWebSearchServerToolType.Openrouter_webSearch,
                _ => null,
            };
        }
    }
}