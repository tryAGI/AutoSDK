//HintName: G.Models.CreateChatCompletionRequestReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// qwen3 models support the following values<br/>
    /// Set to 'none' to disable reasoning.<br/>
    /// Set to 'default' or null to let Qwen reason.<br/>
    /// openai/gpt-oss-20b and openai/gpt-oss-120b support 'low', 'medium', or 'high'.<br/>
    /// 'medium' is the default value.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestReasoningEffort value)
        {
            return value switch
            {
                CreateChatCompletionRequestReasoningEffort.Default => "default",
                CreateChatCompletionRequestReasoningEffort.High => "high",
                CreateChatCompletionRequestReasoningEffort.Low => "low",
                CreateChatCompletionRequestReasoningEffort.Medium => "medium",
                CreateChatCompletionRequestReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateChatCompletionRequestReasoningEffort.Default,
                "high" => CreateChatCompletionRequestReasoningEffort.High,
                "low" => CreateChatCompletionRequestReasoningEffort.Low,
                "medium" => CreateChatCompletionRequestReasoningEffort.Medium,
                "none" => CreateChatCompletionRequestReasoningEffort.None,
                _ => null,
            };
        }
    }
}