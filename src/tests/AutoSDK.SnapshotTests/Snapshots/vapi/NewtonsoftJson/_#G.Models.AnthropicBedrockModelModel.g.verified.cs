//HintName: G.Models.AnthropicBedrockModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The specific Anthropic/Claude model that will be used via Bedrock.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnthropicBedrockModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-haiku-20241022")]
        Claude35Haiku20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-20240620")]
        Claude35Sonnet20240620,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-20241022")]
        Claude35Sonnet20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-7-sonnet-20250219")]
        Claude37Sonnet20250219,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-haiku-20240307")]
        Claude3Haiku20240307,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-opus-20240229")]
        Claude3Opus20240229,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-sonnet-20240229")]
        Claude3Sonnet20240229,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-haiku-4-5-20251001")]
        ClaudeHaiku4520251001,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-opus-4-20250514")]
        ClaudeOpus420250514,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-opus-4-5-20251101")]
        ClaudeOpus4520251101,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-opus-4-6")]
        ClaudeOpus46,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-20250514")]
        ClaudeSonnet420250514,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-5-20250929")]
        ClaudeSonnet4520250929,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-6")]
        ClaudeSonnet46,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBedrockModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBedrockModelModel value)
        {
            return value switch
            {
                AnthropicBedrockModelModel.Claude35Haiku20241022 => "claude-3-5-haiku-20241022",
                AnthropicBedrockModelModel.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                AnthropicBedrockModelModel.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                AnthropicBedrockModelModel.Claude37Sonnet20250219 => "claude-3-7-sonnet-20250219",
                AnthropicBedrockModelModel.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                AnthropicBedrockModelModel.Claude3Opus20240229 => "claude-3-opus-20240229",
                AnthropicBedrockModelModel.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                AnthropicBedrockModelModel.ClaudeHaiku4520251001 => "claude-haiku-4-5-20251001",
                AnthropicBedrockModelModel.ClaudeOpus420250514 => "claude-opus-4-20250514",
                AnthropicBedrockModelModel.ClaudeOpus4520251101 => "claude-opus-4-5-20251101",
                AnthropicBedrockModelModel.ClaudeOpus46 => "claude-opus-4-6",
                AnthropicBedrockModelModel.ClaudeSonnet420250514 => "claude-sonnet-4-20250514",
                AnthropicBedrockModelModel.ClaudeSonnet4520250929 => "claude-sonnet-4-5-20250929",
                AnthropicBedrockModelModel.ClaudeSonnet46 => "claude-sonnet-4-6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBedrockModelModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-20241022" => AnthropicBedrockModelModel.Claude35Haiku20241022,
                "claude-3-5-sonnet-20240620" => AnthropicBedrockModelModel.Claude35Sonnet20240620,
                "claude-3-5-sonnet-20241022" => AnthropicBedrockModelModel.Claude35Sonnet20241022,
                "claude-3-7-sonnet-20250219" => AnthropicBedrockModelModel.Claude37Sonnet20250219,
                "claude-3-haiku-20240307" => AnthropicBedrockModelModel.Claude3Haiku20240307,
                "claude-3-opus-20240229" => AnthropicBedrockModelModel.Claude3Opus20240229,
                "claude-3-sonnet-20240229" => AnthropicBedrockModelModel.Claude3Sonnet20240229,
                "claude-haiku-4-5-20251001" => AnthropicBedrockModelModel.ClaudeHaiku4520251001,
                "claude-opus-4-20250514" => AnthropicBedrockModelModel.ClaudeOpus420250514,
                "claude-opus-4-5-20251101" => AnthropicBedrockModelModel.ClaudeOpus4520251101,
                "claude-opus-4-6" => AnthropicBedrockModelModel.ClaudeOpus46,
                "claude-sonnet-4-20250514" => AnthropicBedrockModelModel.ClaudeSonnet420250514,
                "claude-sonnet-4-5-20250929" => AnthropicBedrockModelModel.ClaudeSonnet4520250929,
                "claude-sonnet-4-6" => AnthropicBedrockModelModel.ClaudeSonnet46,
                _ => null,
            };
        }
    }
}