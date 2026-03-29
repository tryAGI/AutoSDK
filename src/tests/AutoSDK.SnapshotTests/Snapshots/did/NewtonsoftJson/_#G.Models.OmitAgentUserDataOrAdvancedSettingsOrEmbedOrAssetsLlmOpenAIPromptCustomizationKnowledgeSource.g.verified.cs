//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource.g.cs

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
    public enum OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource
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
    public static class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource value)
        {
            return value switch
            {
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource.BaseKnowledge => "base_knowledge",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource? ToEnum(string value)
        {
            return value switch
            {
                "base_knowledge" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource.BaseKnowledge,
                "documents" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource.Documents,
                _ => null,
            };
        }
    }
}