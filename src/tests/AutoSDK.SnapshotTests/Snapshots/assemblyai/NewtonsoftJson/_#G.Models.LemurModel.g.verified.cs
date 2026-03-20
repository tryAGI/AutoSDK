//HintName: G.Models.LemurModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model that is used for the final prompt after compression is performed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LemurModel
    {
        /// <summary>
        /// Claude 3.5 Sonnet is Anthropic's most intelligent model to date, outperforming Claude 3 Opus on a wide range of evaluations, with the speed and cost of Claude 3 Sonnet.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic/claude-3-5-sonnet")]
        AnthropicClaude3_5_Sonnet,
        /// <summary>
        /// Claude 3 Opus is good at handling complex analysis, longer tasks with many steps, and higher-order math and coding tasks.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic/claude-3-opus")]
        AnthropicClaude3_Opus,
        /// <summary>
        /// Claude 3 Haiku is the fastest model that can execute lightweight actions.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic/claude-3-haiku")]
        AnthropicClaude3_Haiku,
        /// <summary>
        /// Claude 3 Sonnet is a legacy model with a balanced combination of performance and speed for efficient, high-throughput tasks.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic/claude-3-sonnet")]
        AnthropicClaude3_Sonnet,
        /// <summary>
        /// Claude 2.1 is a legacy model similar to Claude 2.0. The key difference is that it minimizes model hallucination and system prompts, has a larger context window, and performs better in citations.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic/claude-2-1")]
        AnthropicClaude2_1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic/claude-2")]
        AnthropicClaude2,
        /// <summary>
        /// Legacy model. The same as Claude 2.0.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// Claude Instant is a legacy model that is optimized for speed and cost. Claude Instant can complete requests up to 20% faster than Claude 2.0.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic/claude-instant-1-2")]
        AnthropicClaudeInstant1_2,
        /// <summary>
        /// Legacy model. The same as Claude Instant.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// LeMUR Mistral 7B is an LLM self-hosted by AssemblyAI. It's the fastest and cheapest of the LLM options. We recommend it for use cases like basic summaries and factual Q&amp;A.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assemblyai/mistral-7b")]
        AssemblyaiMistral7b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LemurModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LemurModel value)
        {
            return value switch
            {
                LemurModel.AnthropicClaude3_5_Sonnet => "anthropic/claude-3-5-sonnet",
                LemurModel.AnthropicClaude3_Opus => "anthropic/claude-3-opus",
                LemurModel.AnthropicClaude3_Haiku => "anthropic/claude-3-haiku",
                LemurModel.AnthropicClaude3_Sonnet => "anthropic/claude-3-sonnet",
                LemurModel.AnthropicClaude2_1 => "anthropic/claude-2-1",
                LemurModel.AnthropicClaude2 => "anthropic/claude-2",
                LemurModel.Default => "default",
                LemurModel.AnthropicClaudeInstant1_2 => "anthropic/claude-instant-1-2",
                LemurModel.Basic => "basic",
                LemurModel.AssemblyaiMistral7b => "assemblyai/mistral-7b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LemurModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-3-5-sonnet" => LemurModel.AnthropicClaude3_5_Sonnet,
                "anthropic/claude-3-opus" => LemurModel.AnthropicClaude3_Opus,
                "anthropic/claude-3-haiku" => LemurModel.AnthropicClaude3_Haiku,
                "anthropic/claude-3-sonnet" => LemurModel.AnthropicClaude3_Sonnet,
                "anthropic/claude-2-1" => LemurModel.AnthropicClaude2_1,
                "anthropic/claude-2" => LemurModel.AnthropicClaude2,
                "default" => LemurModel.Default,
                "anthropic/claude-instant-1-2" => LemurModel.AnthropicClaudeInstant1_2,
                "basic" => LemurModel.Basic,
                "assemblyai/mistral-7b" => LemurModel.AssemblyaiMistral7b,
                _ => null,
            };
        }
    }
}