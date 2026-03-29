//HintName: G.Models.AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource.g.cs

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
    public enum AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource
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
    public static class AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}