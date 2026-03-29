//HintName: G.Models.KnowledgeBaseSourceDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the knowledge base source.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseSourceDocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document")]
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseSourceDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseSourceDocumentType value)
        {
            return value switch
            {
                KnowledgeBaseSourceDocumentType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseSourceDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "document" => KnowledgeBaseSourceDocumentType.Document,
                _ => null,
            };
        }
    }
}