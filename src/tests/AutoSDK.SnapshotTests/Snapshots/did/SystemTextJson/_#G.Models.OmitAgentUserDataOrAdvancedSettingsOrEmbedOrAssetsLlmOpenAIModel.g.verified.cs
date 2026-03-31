//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oGlobal,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel value)
        {
            return value switch
            {
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt41 => "gpt-4.1",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt41Mini => "gpt-4.1-mini",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt41Nano => "gpt-4.1-nano",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt4oGlobal => "gpt-4o-global",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt4oMini => "gpt-4o-mini",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt5Mini => "gpt-5-mini",
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt41,
                "gpt-4.1-mini" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt41Mini,
                "gpt-4.1-nano" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt41Nano,
                "gpt-4o-global" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt4oGlobal,
                "gpt-4o-mini" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt4oMini,
                "gpt-5-mini" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt5Mini,
                "gpt-5-nano" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}