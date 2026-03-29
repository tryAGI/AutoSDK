//HintName: G.Models.LLMResponseBodyVectorDBDetailsResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMResponseBodyVectorDBDetailsResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        VectorDb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMResponseBodyVectorDBDetailsResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMResponseBodyVectorDBDetailsResponseType value)
        {
            return value switch
            {
                LLMResponseBodyVectorDBDetailsResponseType.VectorDb => "vector_db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMResponseBodyVectorDBDetailsResponseType? ToEnum(string value)
        {
            return value switch
            {
                "vector_db" => LLMResponseBodyVectorDBDetailsResponseType.VectorDb,
                _ => null,
            };
        }
    }
}