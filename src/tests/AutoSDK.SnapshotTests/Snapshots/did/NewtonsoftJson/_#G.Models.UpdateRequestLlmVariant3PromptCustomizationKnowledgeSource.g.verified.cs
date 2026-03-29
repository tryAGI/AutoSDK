//HintName: G.Models.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource.g.cs

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
    public enum UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource
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
    public static class UpdateRequestLlmVariant3PromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}