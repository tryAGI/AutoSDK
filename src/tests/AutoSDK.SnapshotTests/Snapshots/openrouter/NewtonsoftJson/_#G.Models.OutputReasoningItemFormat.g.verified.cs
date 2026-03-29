//HintName: G.Models.OutputReasoningItemFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the reasoning content
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputReasoningItemFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-claude-v1")]
        AnthropicClaudeV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai-responses-v1")]
        AzureOpenaiResponsesV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google-gemini-v1")]
        GoogleGeminiV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-responses-v1")]
        OpenaiResponsesV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai-responses-v1")]
        XaiResponsesV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputReasoningItemFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputReasoningItemFormat value)
        {
            return value switch
            {
                OutputReasoningItemFormat.AnthropicClaudeV1 => "anthropic-claude-v1",
                OutputReasoningItemFormat.AzureOpenaiResponsesV1 => "azure-openai-responses-v1",
                OutputReasoningItemFormat.GoogleGeminiV1 => "google-gemini-v1",
                OutputReasoningItemFormat.OpenaiResponsesV1 => "openai-responses-v1",
                OutputReasoningItemFormat.Unknown => "unknown",
                OutputReasoningItemFormat.XaiResponsesV1 => "xai-responses-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputReasoningItemFormat? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-claude-v1" => OutputReasoningItemFormat.AnthropicClaudeV1,
                "azure-openai-responses-v1" => OutputReasoningItemFormat.AzureOpenaiResponsesV1,
                "google-gemini-v1" => OutputReasoningItemFormat.GoogleGeminiV1,
                "openai-responses-v1" => OutputReasoningItemFormat.OpenaiResponsesV1,
                "unknown" => OutputReasoningItemFormat.Unknown,
                "xai-responses-v1" => OutputReasoningItemFormat.XaiResponsesV1,
                _ => null,
            };
        }
    }
}