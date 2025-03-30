//HintName: G.Models.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType value)
        {
            return value switch
            {
                GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.Url => "url",
                GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.Url,
                "file" => GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.File,
                _ => null,
            };
        }
    }
}