//HintName: G.Models.AnthropicModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The specific Anthropic/Claude model that will be used.
    /// </summary>
    public enum AnthropicModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Haiku20241022,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20241022,
        /// <summary>
        /// 
        /// </summary>
        Claude37Sonnet20250219,
        /// <summary>
        /// 
        /// </summary>
        Claude3Haiku20240307,
        /// <summary>
        /// 
        /// </summary>
        Claude3Opus20240229,
        /// <summary>
        /// 
        /// </summary>
        Claude3Sonnet20240229,
        /// <summary>
        /// 
        /// </summary>
        ClaudeHaiku4520251001,
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus420250514,
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus4520251101,
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus46,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet420250514,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet4520250929,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet46,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelModel value)
        {
            return value switch
            {
                AnthropicModelModel.Claude35Haiku20241022 => "claude-3-5-haiku-20241022",
                AnthropicModelModel.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                AnthropicModelModel.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                AnthropicModelModel.Claude37Sonnet20250219 => "claude-3-7-sonnet-20250219",
                AnthropicModelModel.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                AnthropicModelModel.Claude3Opus20240229 => "claude-3-opus-20240229",
                AnthropicModelModel.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                AnthropicModelModel.ClaudeHaiku4520251001 => "claude-haiku-4-5-20251001",
                AnthropicModelModel.ClaudeOpus420250514 => "claude-opus-4-20250514",
                AnthropicModelModel.ClaudeOpus4520251101 => "claude-opus-4-5-20251101",
                AnthropicModelModel.ClaudeOpus46 => "claude-opus-4-6",
                AnthropicModelModel.ClaudeSonnet420250514 => "claude-sonnet-4-20250514",
                AnthropicModelModel.ClaudeSonnet4520250929 => "claude-sonnet-4-5-20250929",
                AnthropicModelModel.ClaudeSonnet46 => "claude-sonnet-4-6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-20241022" => AnthropicModelModel.Claude35Haiku20241022,
                "claude-3-5-sonnet-20240620" => AnthropicModelModel.Claude35Sonnet20240620,
                "claude-3-5-sonnet-20241022" => AnthropicModelModel.Claude35Sonnet20241022,
                "claude-3-7-sonnet-20250219" => AnthropicModelModel.Claude37Sonnet20250219,
                "claude-3-haiku-20240307" => AnthropicModelModel.Claude3Haiku20240307,
                "claude-3-opus-20240229" => AnthropicModelModel.Claude3Opus20240229,
                "claude-3-sonnet-20240229" => AnthropicModelModel.Claude3Sonnet20240229,
                "claude-haiku-4-5-20251001" => AnthropicModelModel.ClaudeHaiku4520251001,
                "claude-opus-4-20250514" => AnthropicModelModel.ClaudeOpus420250514,
                "claude-opus-4-5-20251101" => AnthropicModelModel.ClaudeOpus4520251101,
                "claude-opus-4-6" => AnthropicModelModel.ClaudeOpus46,
                "claude-sonnet-4-20250514" => AnthropicModelModel.ClaudeSonnet420250514,
                "claude-sonnet-4-5-20250929" => AnthropicModelModel.ClaudeSonnet4520250929,
                "claude-sonnet-4-6" => AnthropicModelModel.ClaudeSonnet46,
                _ => null,
            };
        }
    }
}