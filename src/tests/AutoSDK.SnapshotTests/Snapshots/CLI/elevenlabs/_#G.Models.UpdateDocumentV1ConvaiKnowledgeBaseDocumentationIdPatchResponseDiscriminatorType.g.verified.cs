//HintName: G.Models.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType value)
        {
            return value switch
            {
                UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType.Url => "url",
                UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType.File => "file",
                UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType.Url,
                "file" => UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType.File,
                "text" => UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}