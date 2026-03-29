//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template.g.cs

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
    public enum OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template
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
    public static class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template value)
        {
            return value switch
            {
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template.Assistant => "assistant",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template.RagGrounded => "rag-grounded",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template.Assistant,
                "rag-grounded" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template.RagGrounded,
                "rag-ungrounded" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template.RagUngrounded,
                _ => null,
            };
        }
    }
}