//HintName: G.Models.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines how the Agent receives knowledge.&lt;/br&gt;<br/>
    /// - base_knowledge — Uses inline knowledge from prompt_knowledge<br/>
    /// - documents — Uses knowledge_id (RAG)<br/>
    /// (Default: documents)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base_knowledge")]
        BaseKnowledge,
        /// <summary>
        /// documents)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="documents")]
        Documents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureOpenAIExternalLLMPromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}