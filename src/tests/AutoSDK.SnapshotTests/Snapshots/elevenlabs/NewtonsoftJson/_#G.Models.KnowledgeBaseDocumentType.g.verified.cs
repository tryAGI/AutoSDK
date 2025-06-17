//HintName: G.Models.KnowledgeBaseDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseDocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
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
                KnowledgeBaseDocumentType.Url => "url",
                KnowledgeBaseDocumentType.Text => "text",
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
                "url" => KnowledgeBaseDocumentType.Url,
                "text" => KnowledgeBaseDocumentType.Text,
                _ => null,
            };
        }
    }
}