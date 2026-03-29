//HintName: G.Models.ReasoningDetailEncryptedFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningDetailEncryptedFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaudeV1,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenaiResponsesV1,
        /// <summary>
        /// 
        /// </summary>
        GoogleGeminiV1,
        /// <summary>
        /// 
        /// </summary>
        OpenaiResponsesV1,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        XaiResponsesV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailEncryptedFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailEncryptedFormat value)
        {
            return value switch
            {
                ReasoningDetailEncryptedFormat.AnthropicClaudeV1 => "anthropic-claude-v1",
                ReasoningDetailEncryptedFormat.AzureOpenaiResponsesV1 => "azure-openai-responses-v1",
                ReasoningDetailEncryptedFormat.GoogleGeminiV1 => "google-gemini-v1",
                ReasoningDetailEncryptedFormat.OpenaiResponsesV1 => "openai-responses-v1",
                ReasoningDetailEncryptedFormat.Unknown => "unknown",
                ReasoningDetailEncryptedFormat.XaiResponsesV1 => "xai-responses-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailEncryptedFormat? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-claude-v1" => ReasoningDetailEncryptedFormat.AnthropicClaudeV1,
                "azure-openai-responses-v1" => ReasoningDetailEncryptedFormat.AzureOpenaiResponsesV1,
                "google-gemini-v1" => ReasoningDetailEncryptedFormat.GoogleGeminiV1,
                "openai-responses-v1" => ReasoningDetailEncryptedFormat.OpenaiResponsesV1,
                "unknown" => ReasoningDetailEncryptedFormat.Unknown,
                "xai-responses-v1" => ReasoningDetailEncryptedFormat.XaiResponsesV1,
                _ => null,
            };
        }
    }
}