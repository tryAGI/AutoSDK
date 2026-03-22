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
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="folder")]
        Folder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
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
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.File => "file",
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Folder => "folder",
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Text => "text",
                GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Url => "url",
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
                "file" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.File,
                "folder" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Folder,
                "text" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Text,
                "url" => GetDocumentationFromKnowledgeBaseResponseDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}