//HintName: G.Models.EvalAnthropicModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the specific model that will be used.
    /// </summary>
    public enum EvalAnthropicModelModel
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
    public static class EvalAnthropicModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalAnthropicModelModel value)
        {
            return value switch
            {
                EvalAnthropicModelModel.Claude35Haiku20241022 => "claude-3-5-haiku-20241022",
                EvalAnthropicModelModel.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                EvalAnthropicModelModel.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                EvalAnthropicModelModel.Claude37Sonnet20250219 => "claude-3-7-sonnet-20250219",
                EvalAnthropicModelModel.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                EvalAnthropicModelModel.Claude3Opus20240229 => "claude-3-opus-20240229",
                EvalAnthropicModelModel.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                EvalAnthropicModelModel.ClaudeHaiku4520251001 => "claude-haiku-4-5-20251001",
                EvalAnthropicModelModel.ClaudeOpus420250514 => "claude-opus-4-20250514",
                EvalAnthropicModelModel.ClaudeOpus4520251101 => "claude-opus-4-5-20251101",
                EvalAnthropicModelModel.ClaudeOpus46 => "claude-opus-4-6",
                EvalAnthropicModelModel.ClaudeSonnet420250514 => "claude-sonnet-4-20250514",
                EvalAnthropicModelModel.ClaudeSonnet4520250929 => "claude-sonnet-4-5-20250929",
                EvalAnthropicModelModel.ClaudeSonnet46 => "claude-sonnet-4-6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalAnthropicModelModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-20241022" => EvalAnthropicModelModel.Claude35Haiku20241022,
                "claude-3-5-sonnet-20240620" => EvalAnthropicModelModel.Claude35Sonnet20240620,
                "claude-3-5-sonnet-20241022" => EvalAnthropicModelModel.Claude35Sonnet20241022,
                "claude-3-7-sonnet-20250219" => EvalAnthropicModelModel.Claude37Sonnet20250219,
                "claude-3-haiku-20240307" => EvalAnthropicModelModel.Claude3Haiku20240307,
                "claude-3-opus-20240229" => EvalAnthropicModelModel.Claude3Opus20240229,
                "claude-3-sonnet-20240229" => EvalAnthropicModelModel.Claude3Sonnet20240229,
                "claude-haiku-4-5-20251001" => EvalAnthropicModelModel.ClaudeHaiku4520251001,
                "claude-opus-4-20250514" => EvalAnthropicModelModel.ClaudeOpus420250514,
                "claude-opus-4-5-20251101" => EvalAnthropicModelModel.ClaudeOpus4520251101,
                "claude-opus-4-6" => EvalAnthropicModelModel.ClaudeOpus46,
                "claude-sonnet-4-20250514" => EvalAnthropicModelModel.ClaudeSonnet420250514,
                "claude-sonnet-4-5-20250929" => EvalAnthropicModelModel.ClaudeSonnet4520250929,
                "claude-sonnet-4-6" => EvalAnthropicModelModel.ClaudeSonnet46,
                _ => null,
            };
        }
    }
}