//HintName: G.Models.AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource.g.cs

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
    public enum AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource
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
    public static class AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}