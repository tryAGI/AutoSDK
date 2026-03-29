//HintName: G.Models.TrieveKnowledgeBaseImportType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is to import an existing dataset from Trieve.
    /// </summary>
    public enum TrieveKnowledgeBaseImportType
    {
        /// <summary>
        /// 
        /// </summary>
        Import,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrieveKnowledgeBaseImportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrieveKnowledgeBaseImportType value)
        {
            return value switch
            {
                TrieveKnowledgeBaseImportType.Import => "import",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrieveKnowledgeBaseImportType? ToEnum(string value)
        {
            return value switch
            {
                "import" => TrieveKnowledgeBaseImportType.Import,
                _ => null,
            };
        }
    }
}