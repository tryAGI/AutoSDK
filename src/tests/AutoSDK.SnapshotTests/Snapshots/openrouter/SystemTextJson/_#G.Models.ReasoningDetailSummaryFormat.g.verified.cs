//HintName: G.Models.ReasoningDetailSummaryFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningDetailSummaryFormat
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
    public static class ReasoningDetailSummaryFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailSummaryFormat value)
        {
            return value switch
            {
                ReasoningDetailSummaryFormat.AnthropicClaudeV1 => "anthropic-claude-v1",
                ReasoningDetailSummaryFormat.AzureOpenaiResponsesV1 => "azure-openai-responses-v1",
                ReasoningDetailSummaryFormat.GoogleGeminiV1 => "google-gemini-v1",
                ReasoningDetailSummaryFormat.OpenaiResponsesV1 => "openai-responses-v1",
                ReasoningDetailSummaryFormat.Unknown => "unknown",
                ReasoningDetailSummaryFormat.XaiResponsesV1 => "xai-responses-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailSummaryFormat? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-claude-v1" => ReasoningDetailSummaryFormat.AnthropicClaudeV1,
                "azure-openai-responses-v1" => ReasoningDetailSummaryFormat.AzureOpenaiResponsesV1,
                "google-gemini-v1" => ReasoningDetailSummaryFormat.GoogleGeminiV1,
                "openai-responses-v1" => ReasoningDetailSummaryFormat.OpenaiResponsesV1,
                "unknown" => ReasoningDetailSummaryFormat.Unknown,
                "xai-responses-v1" => ReasoningDetailSummaryFormat.XaiResponsesV1,
                _ => null,
            };
        }
    }
}