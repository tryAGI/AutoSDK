//HintName: G.Models.TrieveKnowledgeBaseSearchPlanSearchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the search method used when searching for relevant chunks from the vector store.
    /// </summary>
    public enum TrieveKnowledgeBaseSearchPlanSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        Bm25,
        /// <summary>
        /// 
        /// </summary>
        Fulltext,
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Semantic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrieveKnowledgeBaseSearchPlanSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrieveKnowledgeBaseSearchPlanSearchType value)
        {
            return value switch
            {
                TrieveKnowledgeBaseSearchPlanSearchType.Bm25 => "bm25",
                TrieveKnowledgeBaseSearchPlanSearchType.Fulltext => "fulltext",
                TrieveKnowledgeBaseSearchPlanSearchType.Hybrid => "hybrid",
                TrieveKnowledgeBaseSearchPlanSearchType.Semantic => "semantic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrieveKnowledgeBaseSearchPlanSearchType? ToEnum(string value)
        {
            return value switch
            {
                "bm25" => TrieveKnowledgeBaseSearchPlanSearchType.Bm25,
                "fulltext" => TrieveKnowledgeBaseSearchPlanSearchType.Fulltext,
                "hybrid" => TrieveKnowledgeBaseSearchPlanSearchType.Hybrid,
                "semantic" => TrieveKnowledgeBaseSearchPlanSearchType.Semantic,
                _ => null,
            };
        }
    }
}