//HintName: G.Models.LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines how the Agent receives knowledge.&lt;/br&gt;<br/>
    /// - base_knowledge — Uses inline knowledge from prompt_knowledge<br/>
    /// - documents — Uses knowledge_id (RAG)<br/>
    /// (Default: documents)
    /// </summary>
    public enum LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource
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
    public static class LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}