//HintName: G.Models.ReasoningDetailTextFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningDetailTextFormat
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
    public static class ReasoningDetailTextFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailTextFormat value)
        {
            return value switch
            {
                ReasoningDetailTextFormat.AnthropicClaudeV1 => "anthropic-claude-v1",
                ReasoningDetailTextFormat.AzureOpenaiResponsesV1 => "azure-openai-responses-v1",
                ReasoningDetailTextFormat.GoogleGeminiV1 => "google-gemini-v1",
                ReasoningDetailTextFormat.OpenaiResponsesV1 => "openai-responses-v1",
                ReasoningDetailTextFormat.Unknown => "unknown",
                ReasoningDetailTextFormat.XaiResponsesV1 => "xai-responses-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailTextFormat? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-claude-v1" => ReasoningDetailTextFormat.AnthropicClaudeV1,
                "azure-openai-responses-v1" => ReasoningDetailTextFormat.AzureOpenaiResponsesV1,
                "google-gemini-v1" => ReasoningDetailTextFormat.GoogleGeminiV1,
                "openai-responses-v1" => ReasoningDetailTextFormat.OpenaiResponsesV1,
                "unknown" => ReasoningDetailTextFormat.Unknown,
                "xai-responses-v1" => ReasoningDetailTextFormat.XaiResponsesV1,
                _ => null,
            };
        }
    }
}