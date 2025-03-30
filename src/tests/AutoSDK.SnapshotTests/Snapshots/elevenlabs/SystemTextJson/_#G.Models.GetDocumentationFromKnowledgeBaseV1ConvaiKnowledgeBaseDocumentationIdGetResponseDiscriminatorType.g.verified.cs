//HintName: G.Models.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType value)
        {
            return value switch
            {
                GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.Url => "url",
                GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.Url,
                "file" => GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.File,
                _ => null,
            };
        }
    }
}