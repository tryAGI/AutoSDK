//HintName: G.Models.LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines how the Agent receives knowledge.&lt;/br&gt;<br/>
    /// - base_knowledge — Uses inline knowledge from prompt_knowledge<br/>
    /// - documents — Uses knowledge_id (RAG)<br/>
    /// (Default: documents)
    /// </summary>
    public enum LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource
    {
        /// <summary>
        /// 
        /// </summary>
        BaseKnowledge,
        /// <summary>
        /// documents)
        /// </summary>
        Documents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}