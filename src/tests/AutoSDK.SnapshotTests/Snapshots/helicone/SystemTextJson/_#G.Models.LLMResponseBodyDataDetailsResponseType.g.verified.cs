//HintName: G.Models.LLMResponseBodyDataDetailsResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMResponseBodyDataDetailsResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Data,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMResponseBodyDataDetailsResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMResponseBodyDataDetailsResponseType value)
        {
            return value switch
            {
                LLMResponseBodyDataDetailsResponseType.Data => "data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMResponseBodyDataDetailsResponseType? ToEnum(string value)
        {
            return value switch
            {
                "data" => LLMResponseBodyDataDetailsResponseType.Data,
                _ => null,
            };
        }
    }
}