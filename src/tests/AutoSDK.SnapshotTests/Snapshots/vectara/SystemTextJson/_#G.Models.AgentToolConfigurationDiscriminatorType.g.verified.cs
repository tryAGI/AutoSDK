//HintName: G.Models.AgentToolConfigurationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentToolConfigurationDiscriminatorType
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
    public static class AgentToolConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolConfigurationDiscriminatorType value)
        {
            return value switch
            {
                AgentToolConfigurationDiscriminatorType.DynamicVectara => "dynamic_vectara",
                AgentToolConfigurationDiscriminatorType.Mcp => "mcp",
                AgentToolConfigurationDiscriminatorType.CorporaSearch => "corpora_search",
                AgentToolConfigurationDiscriminatorType.WebSearch => "web_search",
                AgentToolConfigurationDiscriminatorType.WebGet => "web_get",
                AgentToolConfigurationDiscriminatorType.Lambda => "lambda",
                AgentToolConfigurationDiscriminatorType.StructuredIndexing => "structured_indexing",
                AgentToolConfigurationDiscriminatorType.SubAgent => "sub_agent",
                AgentToolConfigurationDiscriminatorType.ArtifactRead => "artifact_read",
                AgentToolConfigurationDiscriminatorType.ArtifactGrep => "artifact_grep",
                AgentToolConfigurationDiscriminatorType.ImageRead => "image_read",
                AgentToolConfigurationDiscriminatorType.DocumentConversion => "document_conversion",
                AgentToolConfigurationDiscriminatorType.GetDocumentText => "get_document_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolConfigurationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic_vectara" => AgentToolConfigurationDiscriminatorType.DynamicVectara,
                "mcp" => AgentToolConfigurationDiscriminatorType.Mcp,
                "corpora_search" => AgentToolConfigurationDiscriminatorType.CorporaSearch,
                "web_search" => AgentToolConfigurationDiscriminatorType.WebSearch,
                "web_get" => AgentToolConfigurationDiscriminatorType.WebGet,
                "lambda" => AgentToolConfigurationDiscriminatorType.Lambda,
                "structured_indexing" => AgentToolConfigurationDiscriminatorType.StructuredIndexing,
                "sub_agent" => AgentToolConfigurationDiscriminatorType.SubAgent,
                "artifact_read" => AgentToolConfigurationDiscriminatorType.ArtifactRead,
                "artifact_grep" => AgentToolConfigurationDiscriminatorType.ArtifactGrep,
                "image_read" => AgentToolConfigurationDiscriminatorType.ImageRead,
                "document_conversion" => AgentToolConfigurationDiscriminatorType.DocumentConversion,
                "get_document_text" => AgentToolConfigurationDiscriminatorType.GetDocumentText,
                _ => null,
            };
        }
    }
}