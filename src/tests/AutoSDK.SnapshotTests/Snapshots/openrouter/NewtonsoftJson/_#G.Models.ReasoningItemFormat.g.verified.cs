//HintName: G.Models.ReasoningItemFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningItemFormat
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
    public static class ReasoningItemFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningItemFormat value)
        {
            return value switch
            {
                ReasoningItemFormat.AnthropicClaudeV1 => "anthropic-claude-v1",
                ReasoningItemFormat.AzureOpenaiResponsesV1 => "azure-openai-responses-v1",
                ReasoningItemFormat.GoogleGeminiV1 => "google-gemini-v1",
                ReasoningItemFormat.OpenaiResponsesV1 => "openai-responses-v1",
                ReasoningItemFormat.Unknown => "unknown",
                ReasoningItemFormat.XaiResponsesV1 => "xai-responses-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningItemFormat? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-claude-v1" => ReasoningItemFormat.AnthropicClaudeV1,
                "azure-openai-responses-v1" => ReasoningItemFormat.AzureOpenaiResponsesV1,
                "google-gemini-v1" => ReasoningItemFormat.GoogleGeminiV1,
                "openai-responses-v1" => ReasoningItemFormat.OpenaiResponsesV1,
                "unknown" => ReasoningItemFormat.Unknown,
                "xai-responses-v1" => ReasoningItemFormat.XaiResponsesV1,
                _ => null,
            };
        }
    }
}