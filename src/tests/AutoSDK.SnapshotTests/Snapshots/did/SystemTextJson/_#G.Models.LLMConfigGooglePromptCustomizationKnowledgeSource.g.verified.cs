//HintName: G.Models.LLMConfigGooglePromptCustomizationKnowledgeSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines how the Agent receives knowledge.&lt;/br&gt;<br/>
    /// - base_knowledge — Uses inline knowledge from prompt_knowledge<br/>
    /// - documents — Uses knowledge_id (RAG)<br/>
    /// (Default: documents)
    /// </summary>
    public enum LLMConfigGooglePromptCustomizationKnowledgeSource
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
    public static class LLMConfigGooglePromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigGooglePromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                LLMConfigGooglePromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                LLMConfigGooglePromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigGooglePromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => LLMConfigGooglePromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => LLMConfigGooglePromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}