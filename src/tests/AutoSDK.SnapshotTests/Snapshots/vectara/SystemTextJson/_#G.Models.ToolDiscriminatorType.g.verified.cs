//HintName: G.Models.ToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        DynamicVectara,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        CorporaSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        WebGet,
        /// <summary>
        /// 
        /// </summary>
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        StructuredIndexing,
        /// <summary>
        /// 
        /// </summary>
        SubAgent,
        /// <summary>
        /// 
        /// </summary>
        ArtifactCreate,
        /// <summary>
        /// 
        /// </summary>
        ArtifactRead,
        /// <summary>
        /// 
        /// </summary>
        ArtifactGrep,
        /// <summary>
        /// 
        /// </summary>
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        DocumentConversion,
        /// <summary>
        /// 
        /// </summary>
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