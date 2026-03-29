//HintName: G.Models.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rag-grounded")]
        RagGrounded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rag-ungrounded")]
        RagUngrounded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate value)
        {
            return value switch
            {
                PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate.Assistant => "assistant",
                PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate.RagGrounded => "rag-grounded",
                PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate.Assistant,
                "rag-grounded" => PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate.RagGrounded,
                "rag-ungrounded" => PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}