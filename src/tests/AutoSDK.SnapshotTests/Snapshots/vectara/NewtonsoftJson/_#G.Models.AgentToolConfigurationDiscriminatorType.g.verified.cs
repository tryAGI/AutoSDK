//HintName: G.Models.AgentToolConfigurationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentToolConfigurationDiscriminatorType
    {
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
    public static class AgentToolConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolConfigurationDiscriminatorType value)
        {
            return value switch
            {
                AgentToolConfigurationDiscriminatorType.ArtifactGrep => "artifact_grep",
                AgentToolConfigurationDiscriminatorType.ArtifactRead => "artifact_read",
                AgentToolConfigurationDiscriminatorType.CorporaSearch => "corpora_search",
                AgentToolConfigurationDiscriminatorType.DocumentConversion => "document_conversion",
                AgentToolConfigurationDiscriminatorType.DynamicVectara => "dynamic_vectara",
                AgentToolConfigurationDiscriminatorType.GetDocumentText => "get_document_text",
                AgentToolConfigurationDiscriminatorType.ImageRead => "image_read",
                AgentToolConfigurationDiscriminatorType.Lambda => "lambda",
                AgentToolConfigurationDiscriminatorType.Mcp => "mcp",
                AgentToolConfigurationDiscriminatorType.StructuredIndexing => "structured_indexing",
                AgentToolConfigurationDiscriminatorType.SubAgent => "sub_agent",
                AgentToolConfigurationDiscriminatorType.WebGet => "web_get",
                AgentToolConfigurationDiscriminatorType.WebSearch => "web_search",
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
                "artifact_grep" => AgentToolConfigurationDiscriminatorType.ArtifactGrep,
                "artifact_read" => AgentToolConfigurationDiscriminatorType.ArtifactRead,
                "corpora_search" => AgentToolConfigurationDiscriminatorType.CorporaSearch,
                "document_conversion" => AgentToolConfigurationDiscriminatorType.DocumentConversion,
                "dynamic_vectara" => AgentToolConfigurationDiscriminatorType.DynamicVectara,
                "get_document_text" => AgentToolConfigurationDiscriminatorType.GetDocumentText,
                "image_read" => AgentToolConfigurationDiscriminatorType.ImageRead,
                "lambda" => AgentToolConfigurationDiscriminatorType.Lambda,
                "mcp" => AgentToolConfigurationDiscriminatorType.Mcp,
                "structured_indexing" => AgentToolConfigurationDiscriminatorType.StructuredIndexing,
                "sub_agent" => AgentToolConfigurationDiscriminatorType.SubAgent,
                "web_get" => AgentToolConfigurationDiscriminatorType.WebGet,
                "web_search" => AgentToolConfigurationDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}