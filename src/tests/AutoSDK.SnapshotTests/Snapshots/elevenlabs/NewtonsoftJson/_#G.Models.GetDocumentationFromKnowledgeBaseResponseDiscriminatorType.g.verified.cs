//HintName: G.Models.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDocumentationFromKnowledgeBaseResponseDiscriminatorType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="folder")]
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