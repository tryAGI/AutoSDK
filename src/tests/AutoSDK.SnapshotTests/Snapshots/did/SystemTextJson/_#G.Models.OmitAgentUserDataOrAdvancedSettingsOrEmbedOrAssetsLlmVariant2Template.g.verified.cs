//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        RagGrounded,
        /// <summary>
        /// 
        /// </summary>
        RagUngrounded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template value)
        {
            return value switch
            {
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template.Assistant => "assistant",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template.RagGrounded => "rag-grounded",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template.Assistant,
                "rag-grounded" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template.RagGrounded,
                "rag-ungrounded" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}