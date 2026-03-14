//HintName: G.Models.ToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic_vectara")]
        DynamicVectara,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="corpora_search")]
        CorporaSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search")]
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_get")]
        WebGet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lambda")]
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="structured_indexing")]
        StructuredIndexing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sub_agent")]
        SubAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact_create")]
        ArtifactCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact_read")]
        ArtifactRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact_grep")]
        ArtifactGrep,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_read")]
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document_conversion")]
        DocumentConversion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="get_document_text")]
        GetDocumentText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDiscriminatorType value)
        {
            return value switch
            {
                ToolDiscriminatorType.DynamicVectara => "dynamic_vectara",
                ToolDiscriminatorType.Mcp => "mcp",
                ToolDiscriminatorType.CorporaSearch => "corpora_search",
                ToolDiscriminatorType.WebSearch => "web_search",
                ToolDiscriminatorType.WebGet => "web_get",
                ToolDiscriminatorType.Lambda => "lambda",
                ToolDiscriminatorType.StructuredIndexing => "structured_indexing",
                ToolDiscriminatorType.SubAgent => "sub_agent",
                ToolDiscriminatorType.ArtifactCreate => "artifact_create",
                ToolDiscriminatorType.ArtifactRead => "artifact_read",
                ToolDiscriminatorType.ArtifactGrep => "artifact_grep",
                ToolDiscriminatorType.ImageRead => "image_read",
                ToolDiscriminatorType.DocumentConversion => "document_conversion",
                ToolDiscriminatorType.GetDocumentText => "get_document_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic_vectara" => ToolDiscriminatorType.DynamicVectara,
                "mcp" => ToolDiscriminatorType.Mcp,
                "corpora_search" => ToolDiscriminatorType.CorporaSearch,
                "web_search" => ToolDiscriminatorType.WebSearch,
                "web_get" => ToolDiscriminatorType.WebGet,
                "lambda" => ToolDiscriminatorType.Lambda,
                "structured_indexing" => ToolDiscriminatorType.StructuredIndexing,
                "sub_agent" => ToolDiscriminatorType.SubAgent,
                "artifact_create" => ToolDiscriminatorType.ArtifactCreate,
                "artifact_read" => ToolDiscriminatorType.ArtifactRead,
                "artifact_grep" => ToolDiscriminatorType.ArtifactGrep,
                "image_read" => ToolDiscriminatorType.ImageRead,
                "document_conversion" => ToolDiscriminatorType.DocumentConversion,
                "get_document_text" => ToolDiscriminatorType.GetDocumentText,
                _ => null,
            };
        }
    }
}