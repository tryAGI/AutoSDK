//HintName: G.Models.TrieveKnowledgeBaseProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This knowledge base is provided by Trieve.<br/>
    /// To learn more about Trieve, visit https://trieve.ai.
    /// </summary>
    public enum TrieveKnowledgeBaseProvider
    {
        /// <summary>
        /// //trieve.ai.
        /// </summary>
        Trieve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrieveKnowledgeBaseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrieveKnowledgeBaseProvider value)
        {
            return value switch
            {
                TrieveKnowledgeBaseProvider.Trieve => "trieve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrieveKnowledgeBaseProvider? ToEnum(string value)
        {
            return value switch
            {
                "trieve" => TrieveKnowledgeBaseProvider.Trieve,
                _ => null,
            };
        }
    }
}