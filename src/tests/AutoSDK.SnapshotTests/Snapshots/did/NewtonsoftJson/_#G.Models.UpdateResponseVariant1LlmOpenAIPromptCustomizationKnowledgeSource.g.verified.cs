//HintName: G.Models.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource.g.cs

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
    public enum UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource
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
    public static class UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}