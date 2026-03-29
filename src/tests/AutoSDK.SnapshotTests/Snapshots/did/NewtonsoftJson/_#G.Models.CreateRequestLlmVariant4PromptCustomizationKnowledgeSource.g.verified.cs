//HintName: G.Models.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource.g.cs

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
    public enum CreateRequestLlmVariant4PromptCustomizationKnowledgeSource
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
    public static class CreateRequestLlmVariant4PromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant4PromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                CreateRequestLlmVariant4PromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                CreateRequestLlmVariant4PromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant4PromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => CreateRequestLlmVariant4PromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => CreateRequestLlmVariant4PromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}