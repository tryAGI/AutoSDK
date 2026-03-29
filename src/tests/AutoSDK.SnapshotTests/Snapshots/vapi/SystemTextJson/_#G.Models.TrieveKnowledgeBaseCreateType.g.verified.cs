//HintName: G.Models.TrieveKnowledgeBaseCreateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to create a new dataset on Trieve.
    /// </summary>
    public enum TrieveKnowledgeBaseCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrieveKnowledgeBaseCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrieveKnowledgeBaseCreateType value)
        {
            return value switch
            {
                TrieveKnowledgeBaseCreateType.Create => "create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrieveKnowledgeBaseCreateType? ToEnum(string value)
        {
            return value switch
            {
                "create" => TrieveKnowledgeBaseCreateType.Create,
                _ => null,
            };
        }
    }
}