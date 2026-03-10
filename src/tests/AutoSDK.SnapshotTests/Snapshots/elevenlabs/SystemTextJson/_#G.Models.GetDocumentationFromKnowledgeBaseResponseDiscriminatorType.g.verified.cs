//HintName: G.Models.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDocumentationFromKnowledgeBaseResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Folder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentationFromKnowledgeBaseResponseDiscriminatorType value)
        {
            return value switch
            {
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Url => "url",
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.File => "file",
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Text => "text",
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Folder => "folder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Url,
                "file" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.File,
                "text" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Text,
                "folder" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Folder,
                _ => null,
            };
        }
    }
}