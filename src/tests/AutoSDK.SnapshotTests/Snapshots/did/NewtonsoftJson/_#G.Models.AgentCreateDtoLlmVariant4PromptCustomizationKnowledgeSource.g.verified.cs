//HintName: G.Models.AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource.g.cs

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
    public enum AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource
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
    public static class AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}