//HintName: G.Models.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseListResponseModelDocumentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseListResponseModelDocumentDiscriminatorType value)
        {
            return value switch
            {
                GetKnowledgeBaseListResponseModelDocumentDiscriminatorType.File => "file",
                GetKnowledgeBaseListResponseModelDocumentDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetKnowledgeBaseListResponseModelDocumentDiscriminatorType.File,
                "url" => GetKnowledgeBaseListResponseModelDocumentDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}