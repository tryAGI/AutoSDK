//HintName: G.Models.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource.g.cs

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
    public enum CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource
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
    public static class CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}