//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate.g.cs

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
    public enum OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate
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
    public static class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate value)
        {
            return value switch
            {
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate.Assistant => "assistant",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate.RagGrounded => "rag-grounded",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate.Assistant,
                "rag-grounded" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate.RagGrounded,
                "rag-ungrounded" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}