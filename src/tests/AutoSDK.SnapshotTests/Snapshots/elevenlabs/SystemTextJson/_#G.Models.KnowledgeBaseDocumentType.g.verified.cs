//HintName: G.Models.KnowledgeBaseDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeBaseDocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseDocumentType value)
        {
            return value switch
            {
                KnowledgeBaseDocumentType.File => "file",
                KnowledgeBaseDocumentType.Folder => "folder",
                KnowledgeBaseDocumentType.Text => "text",
                KnowledgeBaseDocumentType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "file" => KnowledgeBaseDocumentType.File,
                "folder" => KnowledgeBaseDocumentType.Folder,
                "text" => KnowledgeBaseDocumentType.Text,
                "url" => KnowledgeBaseDocumentType.Url,
                _ => null,
            };
        }
    }
}