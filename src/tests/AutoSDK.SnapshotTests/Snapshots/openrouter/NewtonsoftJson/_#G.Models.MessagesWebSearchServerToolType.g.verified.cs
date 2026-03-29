//HintName: G.Models.MessagesWebSearchServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesWebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openrouter:web_search")]
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