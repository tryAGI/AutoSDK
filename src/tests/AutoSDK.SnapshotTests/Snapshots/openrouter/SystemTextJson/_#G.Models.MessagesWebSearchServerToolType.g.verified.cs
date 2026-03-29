//HintName: G.Models.MessagesWebSearchServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesWebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesWebSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesWebSearchServerToolType value)
        {
            return value switch
            {
                MessagesWebSearchServerToolType.Openrouter_webSearch => "openrouter:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesWebSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:web_search" => MessagesWebSearchServerToolType.Openrouter_webSearch,
                _ => null,
            };
        }
    }
}