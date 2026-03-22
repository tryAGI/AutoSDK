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
        [global::System.Runtime.Serialization.EnumMember(Value="artifact_create")]
        ArtifactCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact_grep")]
        ArtifactGrep,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact_read")]
        ArtifactRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="corpora_search")]
        CorporaSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document_conversion")]
        DocumentConversion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic_vectara")]
        DynamicVectara,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="get_document_text")]
        GetDocumentText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_read")]
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lambda")]
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
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
        [global::System.Runtime.Serialization.EnumMember(Value="web_get")]
        WebGet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search")]
        WebSearch,
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
                ToolDiscriminatorType.ArtifactCreate => "artifact_create",
                ToolDiscriminatorType.ArtifactGrep => "artifact_grep",
                ToolDiscriminatorType.ArtifactRead => "artifact_read",
                ToolDiscriminatorType.CorporaSearch => "corpora_search",
                ToolDiscriminatorType.DocumentConversion => "document_conversion",
                ToolDiscriminatorType.DynamicVectara => "dynamic_vectara",
                ToolDiscriminatorType.GetDocumentText => "get_document_text",
                ToolDiscriminatorType.ImageRead => "image_read",
                ToolDiscriminatorType.Lambda => "lambda",
                ToolDiscriminatorType.Mcp => "mcp",
                ToolDiscriminatorType.StructuredIndexing => "structured_indexing",
                ToolDiscriminatorType.SubAgent => "sub_agent",
                ToolDiscriminatorType.WebGet => "web_get",
                ToolDiscriminatorType.WebSearch => "web_search",
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
                "artifact_create" => ToolDiscriminatorType.ArtifactCreate,
                "artifact_grep" => ToolDiscriminatorType.ArtifactGrep,
                "artifact_read" => ToolDiscriminatorType.ArtifactRead,
                "corpora_search" => ToolDiscriminatorType.CorporaSearch,
                "document_conversion" => ToolDiscriminatorType.DocumentConversion,
                "dynamic_vectara" => ToolDiscriminatorType.DynamicVectara,
                "get_document_text" => ToolDiscriminatorType.GetDocumentText,
                "image_read" => ToolDiscriminatorType.ImageRead,
                "lambda" => ToolDiscriminatorType.Lambda,
                "mcp" => ToolDiscriminatorType.Mcp,
                "structured_indexing" => ToolDiscriminatorType.StructuredIndexing,
                "sub_agent" => ToolDiscriminatorType.SubAgent,
                "web_get" => ToolDiscriminatorType.WebGet,
                "web_search" => ToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}