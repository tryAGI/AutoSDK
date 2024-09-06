//HintName: G.Models.LemurModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model that is used for the final prompt after compression is performed.
    /// </summary>
    public enum LemurModel
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude35Sonnet,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude3Opus,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude3Haiku,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude3Sonnet,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude21,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude2,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaudeInstant12,
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
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
                LemurModel.AnthropicClaude35Sonnet => "anthropic/claude-3-5-sonnet",
                LemurModel.AnthropicClaude3Opus => "anthropic/claude-3-opus",
                LemurModel.AnthropicClaude3Haiku => "anthropic/claude-3-haiku",
                LemurModel.AnthropicClaude3Sonnet => "anthropic/claude-3-sonnet",
                LemurModel.AnthropicClaude21 => "anthropic/claude-2-1",
                LemurModel.AnthropicClaude2 => "anthropic/claude-2",
                LemurModel.Default => "default",
                LemurModel.AnthropicClaudeInstant12 => "anthropic/claude-instant-1-2",
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
                "anthropic/claude-3-5-sonnet" => LemurModel.AnthropicClaude35Sonnet,
                "anthropic/claude-3-opus" => LemurModel.AnthropicClaude3Opus,
                "anthropic/claude-3-haiku" => LemurModel.AnthropicClaude3Haiku,
                "anthropic/claude-3-sonnet" => LemurModel.AnthropicClaude3Sonnet,
                "anthropic/claude-2-1" => LemurModel.AnthropicClaude21,
                "anthropic/claude-2" => LemurModel.AnthropicClaude2,
                "default" => LemurModel.Default,
                "anthropic/claude-instant-1-2" => LemurModel.AnthropicClaudeInstant12,
                "basic" => LemurModel.Basic,
                "assemblyai/mistral-7b" => LemurModel.AssemblyaiMistral7b,
                _ => null,
            };
        }
    }
}